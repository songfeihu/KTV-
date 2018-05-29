using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string sql = "select o.song_name,i.singer_name from song_info as o ,singer_info as i where i.singer_id = o.singer_id  order by song_play_count  desc";

        public int typeName;


        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            DBHelper db = new DBHelper();
            StringBuilder sql = new StringBuilder();
            SqlConnection conn = new SqlConnection(DBHelper.str);
            sql.AppendLine(" select * from singer_info,song_info");
            sql.AppendLine(" where singer_info.singer_id = song_info.singer_id");
            sql.AppendFormat(" and songtype_id = {0}", typeName);
           
            SqlDataAdapter da = new SqlDataAdapter(sql.ToString(),DBHelper.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "1");
            dataGridView1.DataSource = ds.Tables["1"];

           
        }



        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.Show();
            this.Hide();           
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(DBHelper.str);
            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" select * from singer_info,song_info");
            sql.AppendLine(" where singer_info.singer_id = song_info.singer_id");
            sql.AppendFormat(" and songtype_id = {0}", typeName);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql.ToString(), conn);
                string url = comm.ExecuteScalar().ToString();
                Form9 frm = new Form9();
                frm.url = frm.url + "\\" + url;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.Close();
                this.Hide();
            }
        }














        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void tp2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

     

    }
}
