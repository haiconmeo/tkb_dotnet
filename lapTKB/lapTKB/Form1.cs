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
        public quanthe qt;
         datahelper dh;
        public Form1()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
            
        }
        void show(string s)
        {
            string cmd = "SELECT phong.TenPhong,phancong.phancongID,Time.Thu,Time.buoi,teacher.TeacherName,nhom.tenNhom FROM tkb" +
                " INNER JOIN phong ON tkb.PhongID = phong.PhongID INNER JOIN Time ON tkb.TimeID = Time.TimeID " +
                "INNER JOIN phancong ON tkb.phancongID = phancong.phancongID INNER JOIN mon ON mon.MonID = phancong.MonID " +
                "INNER JOIN teacher ON teacher.teacherID = phancong.teacherID" +
                " INNER JOIN nhom ON nhom.nhomID = phancong.nhomID order by "+s+"";
            dataGridView1.DataSource = dh.getTable(cmd);
        }
        void show2(string s,string x)
        {
            string cmd = "SELECT phong.TenPhong,phancong.phancongID,Time.Thu,Time.buoi,teacher.TeacherName,nhom.tenNhom FROM tkb" +
                " INNER JOIN phong ON tkb.PhongID = phong.PhongID INNER JOIN Time ON tkb.TimeID = Time.TimeID " +
                "INNER JOIN phancong ON tkb.phancongID = phancong.phancongID INNER JOIN mon ON mon.MonID = phancong.MonID " +
                "INNER JOIN teacher ON teacher.teacherID = phancong.teacherID" +
                " INNER JOIN nhom ON nhom.nhomID = phancong.nhomID where  " + s + " like '%" +x+"%'";
            dataGridView1.DataSource = dh.getTable(cmd);
        }
        private void f1_show_b_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT phong.TenPhong,phancong.phancongID,Time.Thu,Time.buoi,teacher.TeacherName,nhom.tenNhom FROM tkb" +
                " INNER JOIN phong ON tkb.PhongID = phong.PhongID INNER JOIN Time ON tkb.TimeID = Time.TimeID " +
                "INNER JOIN phancong ON tkb.phancongID = phancong.phancongID INNER JOIN mon ON mon.MonID = phancong.MonID " +
                "INNER JOIN teacher ON teacher.teacherID = phancong.teacherID" +
                " INNER JOIN nhom ON nhom.nhomID = phancong.nhomID";
            dataGridView1.DataSource = dh.getTable(cmd);
        }

        private void f1_add_b_Click(object sender, EventArgs e)
        {
            add f = new add();
            f.Show();
        }

        private void f1_exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f1_sort_b_Click(object sender, EventArgs e)
        {
            sort f = new sort();
            f.Show();
            f.xx = show;
        }

        private void f1_search_b_Click(object sender, EventArgs e)
        {
            search f = new search();
            f.Show();
            f.xx = show2;
        }
    }
}
