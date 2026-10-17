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

        protected override void OnMouseDown(MouseEventArgs e){
            _editor.MouseDown(e.Location); 
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e){
            _editor.MouseMove(e.Location);
            Invalidate();
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e){
            _editor.MouseUp(e.Location);
            Invalidate();
            base.OnMouseUp(e);
        }
        protected override void OnPaint(PaintEventArgs e){
            _editor.Draw(e.Graphics);
            base.OnPaint(e);
        }
    }
}
