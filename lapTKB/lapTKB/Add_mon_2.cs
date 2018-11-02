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
    public partial class Add_mon_2 : Form
    {
        datahelper dh;
        public delegate void ss();
        public ss x;
        public Add_mon_2()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
        }

        private void fmon_add_bt_Click(object sender, EventArgs e)
        {
            string cmd = "insert into mon(TenMon,sotiet) values ('"+fmon_name_tb.Text+"','"+fmon_sotiet_tb.Text+"')";
            dh.exuteNonQuery(cmd);
            x();
            this.Close();
        }

        private void fmon_cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
