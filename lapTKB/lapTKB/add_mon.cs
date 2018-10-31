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
    public partial class add_mon : Form
    {
        datahelper dh;
        public add_mon()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");

        }
        public void show()
        {
            string cmd = "select * from mon";
            dataGridView1.DataSource = dh.getTable(cmd);
        }
        private void f6_show_bt_Click(object sender, EventArgs e)
        {
            string cmd = "select * from mon";
            dataGridView1.DataSource = dh.getTable(cmd);
        }

        private void f6_delete_bt_Click(object sender, EventArgs e)
        {
            string cmd = "delete from mon where monID ='"+dataGridView1.SelectedRows[0].Cells["monID"].Value.ToString()+"'";
            dh.exuteNonQuery(cmd);
        }

        private void f6_update_bt_Click(object sender, EventArgs e)
        {
            string cmd = "update mon set TenMon='"+textBox1.Text+"',sotiet='"+textBox2.Text+"'where monID='"+dataGridView1.SelectedRows[0].Cells["monID"].Value.ToString()+"'";
            dh.exuteNonQuery(cmd);
        }

        private void f6_add_bt_Click(object sender, EventArgs e)
        {
            add_gv_2 f = new add_gv_2();
            f.Show();
            f.x = show;
        }
    }
}
