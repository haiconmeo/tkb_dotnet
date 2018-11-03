using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace lapTKB
{
    class datahelper
    {
        SqlConnection cnn;
        public datahelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public int get_ms(string s)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, this.cnn);

            SqlDataReader reader = cmd.ExecuteReader();
            int a=0;
            while (reader.Read())
                //MessageBox.Show(reader.GetInt32(0).ToString());
                a = reader.GetInt32(0);
            //MessageBox.Show(a);
            cnn.Close();
            return a;
            

        }
        public List<string> getlist(string query)
        {
            List<string> li = new List<string>();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, this.cnn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string hazz = reader.GetString(0);
                li.Add(hazz);
            }
            cnn.Close();
            return li;
        }
        public DataTable getTable(string cmd)
        {
            DataTable db = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd, this.cnn);
            sda.Fill(db);
            return db;
        }
        public void exuteNonQuery(string query)
        {

            SqlCommand cmd = new SqlCommand(query, this.cnn);
            this.cnn.Open();
            cmd.ExecuteNonQuery();
            this.cnn.Close();
        }
    }
}
