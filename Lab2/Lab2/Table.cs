using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing && !e.Cancel) // error handling
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }
    }
}
