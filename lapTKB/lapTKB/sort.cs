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
    
    public partial class sort : Form
    {
       public delegate void ss(string s);
       public ss xx;
        public sort()
        {
            InitializeComponent();
        }

        private void fs_sort_bt_Click(object sender, EventArgs e)
        {
            string s = "";
            if (fs_check_cbb.Text== "giáo viên")
            {
                s = "TeacherName";
            }
            if (fs_check_cbb.Text == "học phần")
            {
                s = "TenMon";
            }
                if (fs_check_cbb.Text == "nhóm")
            {
                s = "tenNhom";
            }
            if (fs_check_cbb.Text == "phòng")
            {
                s = "tenPhong";
            }

            xx(s);
            this.Close();
        }
    }
}
