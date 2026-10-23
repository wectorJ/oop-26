using System.Drawing.Drawing2D;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private readonly Editor _editor = new();
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Text = _editor.CurrentTool.ToString();
            _editor.MouseDown(e.Location);
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            _editor.MouseMove(e.Location);
            Invalidate();
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            _editor.MouseUp(e.Location);
            Invalidate();
            Text = "Lab2";
            base.OnMouseUp(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            _editor.Draw(e.Graphics);
            base.OnPaint(e);
        }

        private void objectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem? item = sender as ToolStripMenuItem;
            if (item is null) throw new InvalidOperationException("The menu item click sender is invalid.");

            switch (item.Name)
            {
                case nameof(dotToolStripMenuItem):
                    _editor.CurrentTool = ShapeType.Dot;
                    break;
                case nameof(lineToolStripMenuItem):
                    _editor.CurrentTool = ShapeType.Line;
                    break;
                case nameof(rectangleToolStripMenuItem):
                    _editor.CurrentTool = ShapeType.Rectangle;
                    break;
                case nameof(ellipseToolStripMenuItem):
                    _editor.CurrentTool = ShapeType.Ellipse;
                    break;
                default:
                    throw new InvalidOperationException($"Unknown menu item: {item.Name}");
            }
        }

        private void borderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem? item = sender as ToolStripMenuItem;
            if (item is null) throw new InvalidOperationException("The menu item click sender is invalid.");

            switch (item.Name)
            {
                case nameof(solidToolStripMenuItem):
                    _editor.SetBorderStyle(DashStyle.Solid);
                    break;
                case nameof(dotedToolStripMenuItem):
                    _editor.SetBorderStyle(DashStyle.Dot);
                    break;
                case nameof(dashDotedToolStripMenuItem):
                    _editor.SetBorderStyle(DashStyle.DashDot);
                    break;
                default:
                    throw new InvalidOperationException($"Unknown border menu item: {item.Name}");
            }

            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem? item = sender as ToolStripMenuItem;
            if (item is null) throw new InvalidOperationException("The menu item click sender is invalid.");

            Color color = item.Name switch
            {
                nameof(redToolStripMenuItem) => Color.Red,
                nameof(blackToolStripMenuItem) => Color.Black,
                nameof(greenToolStripMenuItem) => Color.Green,
                nameof(blueToolStripMenuItem) => Color.Blue,
                _ => throw new InvalidOperationException($"Unknown color menu item: {item.Name}")
            };

            _editor.SetColor(color);
            Invalidate();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            _editor.Clear();
            Invalidate();
        }
    }
}
