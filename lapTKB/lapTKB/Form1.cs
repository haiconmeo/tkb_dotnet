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
            int qh = dh.get_ms("select count(phancongID) from phancong");
            int sp=dh.get_ms("select count(PhongID) from phong");
            int sogv= dh.get_ms("select count(TeacherID) from teacher");
            List<int> _phancong = dh._getlist("select phancongID from phancong");
            List<int> _gv = dh._getlist("select teacherID from phancong");
            List<int> _phong = dh._getlist("select phongID from phong");
            qt = new quanthe( qh,  sp,  sogv,  _phancong,  _gv);
            xuly(sp, qh,_phancong,_phong);
        }
        void xuly(int soPhong,int qh,List<int> _phancong,List<int> phong)
        {
            string cmd2 = "DELETE FROM [dbo].[tkb]";
            dh.exuteNonQuery(cmd2);
            int[,] a = new int[10, soPhong];
            a = qt.loc();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < soPhong; j++)
                {
                    if (a[i,j] < qh)
                    {
                        string cmd = "insert into tkb(TimeID,PhongID,phancongID) values ('"+i+"','"+phong[j]+"','"+_phancong[a[i, j]]+"')";
                        dh.exuteNonQuery(cmd);
                        //string cmd = "[" + i + "]" + "[" + j + "]" + _phancong[a[i, j]];
                        //.Show(cmd);
                    }
                }
            }
            
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
    }
}
