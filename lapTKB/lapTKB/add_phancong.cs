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
        int ms_mon(string s)
        {
            string cmd = "select MonID from mon where TenMon='" + s + "'";
            return dh.get_ms(cmd);
        }
        int ms_gv(string s)
        {
            string cmd = "select teacherID from teacher where TeacherName='" + s + "'";
            return dh.get_ms(cmd);
        }
        int ms_nhom(string s)
        {
            string cmd = "select nhomID from nhom where TenNhom='" + s + "'";
            return dh.get_ms(cmd);
        }
        void load_cbb()
        {
            string cmd1 = "select tenNhom from nhom";
            foreach (string s in dh.getlist(cmd1))
            {
               if (f8_nhom_ccb.Items.IndexOf(s) < 0)
                    f8_nhom_ccb.Items.Add(s);
            }
            string cmd2 = "select TenMon from mon";
            foreach (string s in dh.getlist(cmd2))
            {
                if (f8_mon_cbb.Items.IndexOf(s) < 0)
                {
                    f8_mon_cbb.Items.Add(s);
                }
            }
            string cmd3 = "select TeacherName from teacher";
            foreach (string s in dh.getlist(cmd3))
            {
               if(f8_giangvien_cbb.Items.IndexOf(s) < 0)
                {
                    f8_giangvien_cbb.Items.Add(s);
                }
            }
        }
        private void f8_show_bt_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT phancong.phancongID,teacher.TeacherName, mon.tenmon, nhom.tennhom FROM(((phancong " +
                "INNER JOIN teacher ON phancong.teacherID = teacher.teacherID) " +
                "INNER JOIN nhom ON phancong.nhomID = nhom.nhomID) " +
                "INNER JOIN mon ON phancong.MonID = mon.MonID); ";
            dataGridView1.DataSource = dh.getTable(cmd);
        }
        void show()
        {
            string cmd = "SELECT phancong.phancongID,teacher.TeacherName, mon.tenmon, nhom.tennhom FROM(((phancong " +
               "INNER JOIN teacher ON phancong.teacherID = teacher.teacherID) " +
               "INNER JOIN nhom ON phancong.nhomID = nhom.nhomID) " +
               "INNER JOIN mon ON phancong.MonID = mon.MonID); ";
            dataGridView1.DataSource = dh.getTable(cmd);
        }
        private void f8_add_bt_Click(object sender, EventArgs e)
        {
            //try
            //{
                string cmd = "insert into phancong(teacherID,MonID,nhomID) values ('"+ms_gv(f8_giangvien_cbb.Text)+"','"+ms_mon(f8_mon_cbb.Text)+"','"+ms_nhom(f8_nhom_ccb.Text)+"')";
                MessageBox.Show(cmd);
                dh.exuteNonQuery(cmd);
            show();
            //}*/
            /*
            catch
            {
                MessageBox.Show("nhap thieu");
            }*/
        }

        private void f8_delete_bt_Click(object sender, EventArgs e)
        {
            string cmd = "delete from phancong where phancongID='"+dataGridView1.SelectedRows[0].Cells["phancongID"].Value.ToString()+"'";
            dh.exuteNonQuery(cmd);
            show();
        }
    }
}
