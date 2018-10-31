using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lapTKB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void f1_show_b_Click(object sender, EventArgs e)
        {

        }

        private void f1_add_b_Click(object sender, EventArgs e)
        {
            add f = new add();
            f.Show();
        }
    }
}
