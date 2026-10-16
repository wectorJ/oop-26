namespace OOP_lab1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void module1_Click(object sender, EventArgs e)
        {
            using (Module1 module1_dlg = new Module1())
            {
                if (module1_dlg.ShowDialog() == DialogResult.OK)
                {
                    string inputValue = module1_dlg.InputValueM1;
                    label1.Text = $"Module1 result: {inputValue}";
                }
            }
        }

        private void module2_Click(object sender, EventArgs e)
        {
            using (Module2 module2_dlg = new Module2())
            {
                if (module2_dlg.ShowDialog() == DialogResult.OK)
                {
                    string inputValue = module2_dlg.InputValueM2;
                    label2.Text = $"Module2 result: {inputValue}";
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            label1.Text = "Module1 result";
            label2.Text = "Module2 result";
        }
    }
}
