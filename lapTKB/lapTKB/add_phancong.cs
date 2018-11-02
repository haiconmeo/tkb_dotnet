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
    public partial class add_phancong : Form
    {
        datahelper dh;

        public add_phancong()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
            load_cbb();
        }
        void load_cbb()
        {
            string cmd1 = "select tenNhom from nhom";
            foreach (string s in dh.getlist(cmd1))
            {
                f8_nhom_ccb.FindStringExact(s);
            }
            string cmd2 = "select TenMon from mon";
            foreach (string s in dh.getlist(cmd2))
            {
                f8_mon_cbb.FindStringExact(s);
            }
            string cmd3 = "select TeacherName from teacher";
            foreach (string s in dh.getlist(cmd3))
            {
                f8_giangvien_cbb.FindStringExact(s);
            }
        }
        private void f8_show_bt_Click(object sender, EventArgs e)
        {
            string cmd = "";
            dataGridView1.DataSource = dh.getTable(cmd);
        }

        private void f8_add_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = "";
                dh.exuteNonQuery(cmd);
            }
            catch
            {
                MessageBox.Show("nhap thieu");
            }
        }

        private void f8_delete_bt_Click(object sender, EventArgs e)
        {
            string cmd = "";
            dh.exuteNonQuery(cmd);
        }
    }
}
