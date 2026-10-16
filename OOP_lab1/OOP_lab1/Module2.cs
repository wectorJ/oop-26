using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab1
{
    public partial class Module2 : Form
    {
        public String InputValueM2 { get; private set; }
        public Module2()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null || textBox1.Text == "")
            {
                InputValueM2 = "No input";
            }
            else
            {
                InputValueM2 = textBox1.Text;
            }
        }

        private void btn_cnl_Click(object sender, EventArgs e)
        {

        }

        private void Module2_Load(object sender, EventArgs e)
        {

        }
    }
}
