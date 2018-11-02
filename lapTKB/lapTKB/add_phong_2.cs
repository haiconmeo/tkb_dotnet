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
    public partial class add_phong_2 : Form
    {
        datahelper dh;
        public delegate void ss();
        public ss x;
        public add_phong_2()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
        }

        private void fphong_add_bt_Click(object sender, EventArgs e)
        {
            string cmd = "insert into phong(tenPhong,quanly,std) values ('" + fphong_name_tb.Text + "','" + fphong_quanly_tb.Text +"','"+fphong_sdt_t.Text+"')";
            dh.exuteNonQuery(cmd);
            x();
        }

        private void fphong_cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
