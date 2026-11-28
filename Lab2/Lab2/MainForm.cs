using System.Drawing.Drawing2D;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private const string CsvFilter = "CSV files (*.csv)|*.csv";
        private readonly Editor _editor = Editor.Instance;
        private Table? _table;

        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            _editor.ShapesChanged += Editor_ShapesChanged;
            _editor.SelectionChanged += Editor_SelectionChanged;
            Disposed += (_, _) =>
            {
                _editor.ShapesChanged -= Editor_ShapesChanged;
                _editor.SelectionChanged -= Editor_SelectionChanged;
                _table?.Dispose();
            };

            move_btn.CheckOnClick = true;
            toolStrip2.ItemClicked += toolStrip2_ItemClicked;
            UpdateHistoryButtons();
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
                case nameof(oLineOToolStripMenuItem):
                    _editor.CurrentTool = ShapeType.oLineo;
                    break;
                case nameof(cubeToolStripMenuItem):
                    _editor.CurrentTool = ShapeType.Cube;
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

        private void load_btn_Click(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Load drawing",
                Filter = CsvFilter,
                DefaultExt = "csv",
                RestoreDirectory = true
            };
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            IReadOnlyList<Shape> shapes;
            try
            {
                shapes = FileController.Load(dialog.FileName, this);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or InvalidDataException)
            {
                MessageBox.Show(this, ex.Message, "Could not load drawing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _editor.ReplaceShapes(shapes);
        }

        private void save_btn_Click(object? sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Title = "Save drawing",
                Filter = CsvFilter,
                DefaultExt = "csv",
                AddExtension = true,
                OverwritePrompt = true,
                RestoreDirectory = true
            };
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                FileController.Save(dialog.FileName, _editor.Shapes);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or InvalidDataException)
            {
                MessageBox.Show(this, ex.Message, "Could not save drawing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            _editor.Clear();
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            _editor.Undo();
        }

        private void redo_btn_Click(object sender, EventArgs e)
        {
            _editor.Redo();
        }

        private void Editor_ShapesChanged(object? sender, EventArgs e)
        {
            UpdateHistoryButtons();
            if (_table is { IsDisposed: false })
                _table.Reload(_editor.Shapes);

            Invalidate();
        }

        private void Editor_SelectionChanged(object? sender, EventArgs e) => Invalidate();

        private void UpdateHistoryButtons()
        {
            undo_btn.Enabled = _editor.CanUndo;
            redo_btn.Enabled = _editor.CanRedo;
        }

        private void toolStrip2_ItemClicked(object? sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem != move_btn)
                move_btn.Checked = false;
        }

        private void move_btn_Click(object sender, EventArgs e)
        {

        }

        private void table_btn_Click(object sender, EventArgs e)
        {
            if (_table is null || _table.IsDisposed)
            {
                _table = new Table();
                _table.SelectedShapeChanged += shape => _editor.SelectedShape = shape;
                _table.DeleteRequested += _editor.RemoveShape;
                _table.Disposed += (_, _) => _editor.SelectedShape = null;
                _table.Reload(_editor.Shapes);
            }

            if (!_table.Visible)
                _table.Show();

            if (_table.WindowState == FormWindowState.Minimized)
                _table.WindowState = FormWindowState.Normal;

            _table.Activate();
        }
    }
}
