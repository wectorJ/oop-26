using System.Drawing.Drawing2D;
using System.Globalization;
using Microsoft.VisualBasic.FileIO;

namespace Lab2
{
    public static class FileController
    {
        private const string Header = "Type,StartX,StartY,EndX,EndY,Color,BorderStyle";
        private static readonly string[] Columns = Header.Split(',');

        public static IReadOnlyList<Shape> Load(string path, IWin32Window? owner = null)
        {
            using var parser = new TextFieldParser(path);
            parser.SetDelimiters(",");
            parser.HasFieldsEnclosedInQuotes = true;

            try
            {
                string[]? header = parser.ReadFields();
                if (header is null || !Columns.SequenceEqual(header, StringComparer.OrdinalIgnoreCase))
                    throw new InvalidDataException($"Expected CSV header: {Header}");

                var shapes = new List<Shape>();
                while (parser.ReadFields() is { } fields)
                    shapes.Add(ReadShape(fields, shapes.Count + 2, owner));

                return shapes;
            }
            catch (MalformedLineException ex)
            {
                throw new InvalidDataException($"Malformed CSV at line {ex.LineNumber}.", ex);
            }
        }

        public static void Save(string path, IEnumerable<Shape> shapes)
        {
            string destination = Path.GetFullPath(path);
            string temporaryPath = Path.Combine(Path.GetDirectoryName(destination)!, Path.GetRandomFileName());
            var stream = new FileStream(temporaryPath, FileMode.CreateNew, FileAccess.Write);

            try
            {
                using (stream)
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine(Header);
                    foreach (Shape shape in shapes)
                        writer.WriteLine(WriteShape(shape));
                }

                File.Move(temporaryPath, destination, overwrite: true);
            }
            finally
            {
                File.Delete(temporaryPath);
            }
        }

        private static Shape ReadShape(string[] fields, int record, IWin32Window? owner)
        {
            if (fields.Length != Columns.Length)
                throw new InvalidDataException($"CSV record {record}: expected {Columns.Length} fields.");

            if (!TryReadName(fields[0], out ShapeType type))
                throw new InvalidDataException($"CSV record {record}: unknown figure type '{fields[0]}'.");

            var start = new PointF(ReadCoordinate(fields, 1, record), ReadCoordinate(fields, 2, record));
            var end = new PointF(ReadCoordinate(fields, 3, record), ReadCoordinate(fields, 4, record));
            string color = fields[5];
            if (color.Length != 9 || color[0] != '#' ||
                !uint.TryParse(color.AsSpan(1), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out uint argb))
                throw new InvalidDataException($"CSV record {record}: color must use #AARRGGBB.");

            if (!TryReadName(fields[6], out DashStyle style) || style == DashStyle.Custom)
                throw new InvalidDataException($"CSV record {record}: unsupported border style '{fields[6]}'.");

            if (type == ShapeType.Dot && start != end)
            {
                start = end;
                MessageBox.Show(owner,
                    $"CSV record {record}: the dot's start and end coordinates differ. The end coordinates will be used.",
                    "Drawing import warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); //TODO to list
            }

            Shape shape = Shape.Create(type, start, end)
                ?? throw new InvalidDataException($"CSV record {record}: unsupported figure type '{type}'.");
            shape.Color = Color.FromArgb(unchecked((int)argb));
            shape.BorderStyle = style;
            return shape;
        }

        private static float ReadCoordinate(string[] fields, int index, int record)
        {
            if (float.TryParse(fields[index], NumberStyles.Float, CultureInfo.InvariantCulture, out float value) &&
                float.IsFinite(value))
                return value;

            throw new InvalidDataException($"CSV record {record}: invalid coordinate '{Columns[index]}'.");
        }

        private static bool TryReadName<T>(string text, out T value) where T : struct, Enum =>
            Enum.TryParse(text, ignoreCase: true, out value) &&
            string.Equals(Enum.GetName(value), text, StringComparison.OrdinalIgnoreCase);

        private static string WriteShape(Shape shape)
        {
            ShapeType type = shape switch
            {
                DotShape => ShapeType.Dot,
                LineShape => ShapeType.Line,
                RectangleShape => ShapeType.Rectangle,
                EllipseShape => ShapeType.Ellipse,
                oLineoShape => ShapeType.oLineo,
                CubeShape => ShapeType.Cube,
                _ => throw new InvalidDataException($"Unsupported figure type '{shape.GetType().Name}'.")
            };

            PointF start = shape.Start;
            PointF end = shape.End;
            if (!float.IsFinite(start.X) || !float.IsFinite(start.Y) ||
                !float.IsFinite(end.X) || !float.IsFinite(end.Y) ||
                (type == ShapeType.Dot && start != end))
                throw new InvalidDataException($"Invalid coordinates for '{type}'.");

            if (!Enum.IsDefined(shape.BorderStyle) || shape.BorderStyle == DashStyle.Custom)
                throw new InvalidDataException($"Unsupported border style '{shape.BorderStyle}'.");

            uint argb = unchecked((uint)shape.Color.ToArgb());
            return FormattableString.Invariant($"{type},{start.X:R},{start.Y:R},{end.X:R},{end.Y:R},#{argb:X8},{shape.BorderStyle}");
        }
    }
}
