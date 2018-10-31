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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void f3_addgv_b_Click(object sender, EventArgs e)
        {
            add_gv fgv = new add_gv();
            fgv.Show();
        }

        private void f3_nhom_b_Click(object sender, EventArgs e)
        {
            add_nhom fnh = new add_nhom();
            fnh.Show();
        }

        private void f3_mon_b_Click(object sender, EventArgs e)
        {
            add_mon fmon = new add_mon();
            fmon.Show();

        }

        private void f3_phong_bt_Click(object sender, EventArgs e)
        {
            add_phong fph = new add_phong();
            fph.Show();
        }

        private void f3_phancong_b_Click(object sender, EventArgs e)
        {
            add_phancong fpc = new add_phancong();
            fpc.Show();
        }
    }
}
