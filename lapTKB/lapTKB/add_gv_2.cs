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
    public partial class add_gv_2 : Form
    {
        public delegate void ds();
        public ds x; 
        datahelper dh;
        public add_gv_2()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
        }

        private void fgv_add_bt_Click(object sender, EventArgs e)
        {
            string cmd = "insert into teacher(TeacherName,TeacherSdt,TeacherHocvi,TeacherChuyenNganh) values ('"+
                fgv_name_b.Text+"','"+fgv_sdt_tb.Text +"','"+fgv_hocvi_tb.Text +"','"+fgv_chuyennanh_tb.Text+"')";
            dh.exuteNonQuery(cmd);
            x();
            this.Close();
        }

        private void fgv_cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
