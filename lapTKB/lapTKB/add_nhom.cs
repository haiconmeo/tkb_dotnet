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
    public partial class add_nhom : Form
    {
        datahelper dh;
        public add_nhom()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
        }
        public void show()
        {
            string cmd = "select * from nhom";
            dataGridView1.DataSource = dh.getTable(cmd); 
        }
        private void f5_show_bt_Click(object sender, EventArgs e)
        {
            show();
        }

        private void f5_delete_bt_Click(object sender, EventArgs e)
        {
            string cmd1 = "delete from phancong where nhomID='" + dataGridView1.SelectedRows[0].Cells["nhomID"].Value.ToString() + "'";
            string cmd = "delete from nhom where  nhomID='" + dataGridView1.SelectedRows[0].Cells["nhomID"].Value.ToString()+"'";
            dh.exuteNonQuery(cmd);
            show();
        }

        private void f5_update_bt_Click(object sender, EventArgs e)
        {
            string cmd = "update nhom set tenNhom='"+f4_name_tb.Text+"',khoa='"+f4_khoa_tb.Text+"',mail='"+f4_mail_tb.Text+"',chuNhiem='"+f4_chunhiem_tb.Text+ "' where nhomID= '" + dataGridView1.SelectedRows[0].Cells["nhomID"].Value.ToString() + "'";
            dh.exuteNonQuery(cmd);
            show();

        }

        private void f5_add_bt_Click(object sender, EventArgs e)
        {
            add_nhom_2 f = new add_nhom_2();
            f.Show();
            f.x = show;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            f4_name_tb.Text = dataGridView1.SelectedRows[0].Cells["tenNhom"].Value.ToString();
            f4_mail_tb.Text = dataGridView1.SelectedRows[0].Cells["mail"].Value.ToString();
            f4_khoa_tb.Text = dataGridView1.SelectedRows[0].Cells["khoa"].Value.ToString();
            f4_chunhiem_tb.Text = dataGridView1.SelectedRows[0].Cells["chuNhiem"].Value.ToString();
        }
    }
}
