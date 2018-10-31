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
    public partial class add_phong : Form
    {
        datahelper dh;
        public add_phong()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
        }
        public void show()
        {
            string cmd = "select * from phong";
            dataGridView1.DataSource = dh.getTable(cmd);
        }
        private void f7_show_bt_Click(object sender, EventArgs e)
        {
            string cmd = "select 8 from phong";
            dataGridView1.DataSource= dh.getTable(cmd);
        }

        private void f7_add_bt_Click(object sender, EventArgs e)
        {
            add_phong_2 f = new add_phong_2();
            f.Show();
            f.x = show;
        }

        private void f7_delete_bt_Click(object sender, EventArgs e)
        {
            string cmd = "delete from nhom where ='"+dataGridView1.SelectedRows[0].Cells["phongID"].Value.ToString()+"'";
            dh.exuteNonQuery(cmd);
        }

        private void f7_update_bt_Click(object sender, EventArgs e)
        {
            string cmd = "update nhom set tenPhong ='"+f7_name_tb.Text+"',quanly='"+f7_quanly_tb.Text+"',std='"+f7_sdt_tb.Text+"'";
            dh.exuteNonQuery(cmd);
        }
    }
}
