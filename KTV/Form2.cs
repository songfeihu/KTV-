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
    public partial class qinyindiange : Form
    {
        public qinyindiange()
        {
            InitializeComponent();
        }
        //拼音点歌
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DBHelper db = new DBHelper();//创建帮助类
            SqlConnection conn = new SqlConnection(DBHelper.str);

            StringBuilder sql = new StringBuilder();
            sql.AppendLine(" select song_name,singer_name");
            sql.AppendLine(" from song_info,singer_info");
            sql.AppendLine(" where singer_info.singer_id = song_info.singer_id");
            sql.AppendFormat(" and (song_ab like '%{0}%' or song_name like '%{1}%')",
                this.textBox1.Text, this.textBox1.Text);

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql.ToString(), conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader["song_name"].ToString();
                        string s = reader["singer_name"].ToString();
                        ListViewItem item = new ListViewItem(name);
                        item.SubItems.Add(s);
                        this.listView1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("未查询到数据");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常！" + ex);
            }
            finally
            {
                conn.Close();
          
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            { string name = this.listView1.SelectedItems[0].Text;
                string singer = this.listView1.SelectedItems[0].SubItems[1].Text;
                MessageBox.Show(name + ":" + singer);
                DBHelper db = new DBHelper();
                SqlConnection conn = new SqlConnection(DBHelper.str);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine(" select song_url from song_info,singer_info");
                sql.AppendLine(" where song_info.singer_id = singer_info.singer_id");
                sql.AppendFormat(" and song_name = '{0}' and singer_name = '{1}'", name, singer);
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
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
                KTV1 s = new KTV1();
            s.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void qinyindiange_Load(object sender, EventArgs e)
        {

        }

    }
}
