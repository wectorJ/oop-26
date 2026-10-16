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
    public partial class Module1 : Form
    {
        public String InputValueM1 { get; private set; }
        public Module1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(list_input.Text == null || list_input.Text == "")
            {
                InputValueM1 = "No input";
            }
            else
            {
                InputValueM1 = list_input.Text;
            }
        }

        private void btn_cnl_Click(object sender, EventArgs e)
        {

        }

        private void Module1_Load(object sender, EventArgs e)
        {

        }
    }
}
