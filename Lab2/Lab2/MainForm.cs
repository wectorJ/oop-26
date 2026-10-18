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
            base.OnMouseUp(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            _editor.Draw(e.Graphics);
            base.OnPaint(e);
        }

        private void obj_btn_Click(object sender, EventArgs e) //TODO remove this method
        {

        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _editor.CurrentTool = ShapeType.Dot;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _editor.CurrentTool = ShapeType.Rectangle;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _editor.CurrentTool = ShapeType.Line;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _editor.CurrentTool = ShapeType.Ellipse;
        }
    }
}
