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
            string cmd1 = "delete from phancong where monID ='" + dataGridView1.SelectedRows[0].Cells["monID"].Value.ToString() + "'";
            dh.exuteNonQuery(cmd1);
            string cmd = "delete from mon where monID ='"+dataGridView1.SelectedRows[0].Cells["monID"].Value.ToString()+"'";
            dh.exuteNonQuery(cmd);
            show();
        }

        private void f6_update_bt_Click(object sender, EventArgs e)
        {
            string cmd = "update mon set TenMon='"+f6_tenmon_tb.Text+"',sotiet='"+f6_sotiet_tb.Text+"'where monID='"+dataGridView1.SelectedRows[0].Cells["monID"].Value.ToString()+"'";
            dh.exuteNonQuery(cmd);
            show();
        }

        private void f6_add_bt_Click(object sender, EventArgs e)
        {
            Add_mon_2 f = new Add_mon_2();
            f.Show();
            f.x = show;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            f6_tenmon_tb.Text = dataGridView1.SelectedRows[0].Cells["TenMon"].Value.ToString();
            f6_sotiet_tb.Text = dataGridView1.SelectedRows[0].Cells["sotiet"].Value.ToString();
        }
    }
}
