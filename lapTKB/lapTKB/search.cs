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
    public partial class search : Form
    {
        public delegate void ss(string s,string x);
        public ss xx;
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = "";
            if (fs_search_cbb.Text == "giáo viên")
            {
                s = "TeacherName";
            }
            if (fs_search_cbb.Text == "môn")
            {
                s = "TenMon";
            }
            if (fs_search_cbb.Text == "nhóm")
            {
                s = "tenNhom";
            }
            if (fs_search_cbb.Text == "phòng")
            {
                s = "tenPhong";
            }

            xx(s,textBox1.Text);
            this.Close();
        }
    }
}
