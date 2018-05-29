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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }







        public string sql = "select o.song_name,i.singer_name from song_info as o ,singer_info as i where i.singer_id = o.singer_id  order by song_play_count  desc";
        private void Form7_Load(object sender, EventArgs e)
        {

            DBHelper db = new DBHelper();
            SqlDataAdapter da = new SqlDataAdapter(sql, DBHelper.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "1");
            dgvSS.DataSource = ds.Tables["1"];

        }






        private void pictureBox10_Click(object sender, EventArgs e)
        {
            KTV1 s = new  KTV1();
            s.Show();
            this.Hide();
        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KTV1 s = new  KTV1();
            s.Show();
            this.Hide();
        }





      
        private void dgvSS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection conn = new SqlConnection(DBHelper.str);
            StringBuilder sql = new StringBuilder();
            s = "select o.song_name,i.singer_name from song_info as o ,singer_info as i where i.singer_id = o.singer_id  order by song_play_count  desc";

           try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(s.ToString(), conn);
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
















        private void dgvSS_Click(object sender, EventArgs e)
        {


        }




        private void tp2_Click(object sender, EventArgs e)
        {
        }

        public string s { get; set; }
    }
}
