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
    public partial class add_nhom_2 : Form
    {
        datahelper dh;
        public delegate void ss();
        public ss x;
        public add_nhom_2()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
        }

        private void fnhom_add_bt_Click(object sender, EventArgs e)
        {
            string cmd = "insert into nhom(tenNhom,khoa,mail,chuNhiem) values ('" + fnhom_name_tb.Text + "','" + fnhom_khoa_tb.Text + "','"+fnhom_mail_tb.Text+"','"+fnhom_chunhiem_tb.Text+"'"+")";
            dh.exuteNonQuery(cmd);
            x();
            this.Close();
        }

        private void fnhom_cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
