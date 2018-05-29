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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        public String Sex;
        public String type;
        public String name;
        public string sql;




        //隐藏窗口 
        private void lvGender_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (lvGender.SelectedItems[0] != null)
            {
                Sex = lvGender.SelectedItems[0].Text; 
                lvGender.Visible = false;
                lvCity.Visible = true;
            }
            lvGender.Dock = DockStyle.Fill;
            lvCity.Visible = false;//第二个窗口隐藏
            lvSinger.Visible = false;
            button1.Visible = false;
        }

        private void lvGender_Click(object sender, EventArgs e)
        {
            lvCity.Visible = true;
            lvGender.Visible = false;
            lvSinger.Visible = false;
            //让第二个和第一个位置重叠
            lvCity.Dock = DockStyle.Fill;
            //获取性别
            string gender = (string)lvGender.SelectedItems[0].Tag;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;//隐藏表单
            show();
            lvGender.Dock = DockStyle.Fill;
            lvCity.Visible = false;//第二个窗口隐藏
            lvSinger.Visible = false;
        }




        private void lvCity_Click(object sender, EventArgs e)
        {
            lvCity.Visible = false;
            lvGender.Visible = false;
            lvSinger.Visible = true;
            //让第二个和第一个位置重叠

            lvSinger.Location =lvCity.Location;
            lvSinger.Dock = DockStyle.Fill;
            ListViewItem lvItem = new ListViewItem();


            if (lvCity.SelectedItems[0] != null)
            {
                type = lvCity.SelectedItems[0].Text;
                lvCity.Visible = false;
                lvSinger.Visible = true;
                show();
            }
            button1.Visible = true;
        }






        //动态获取歌手信息
        public void show()
        {
   

            DBHelper db = new DBHelper();
            string sql = "select s.singer_photo_url,s.singer_name from singer_info as s ,singer_type as t where s.singertype_id = t.singertype_id and s.singer_gender='" + Sex + "' and t.singertype_name ='" + type + "'";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.conn);
            db.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;

            while (dr.Read())
            {

                string name = dr["singer_name"].ToString();
                string url = dr["singer_photo_url"].ToString();
                this.imageList3.Images.Add(Image.FromFile("C:\\Users\\Administrator\\Desktop\\KTV素材\\" + (url)));
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = Convert.ToString(dr["singer_name"]);
                item.Font = new Font("楷体", 16, item.Font.Style | FontStyle.Bold);
                i++;
                lvSinger.Items.Add(item);
            }

            db.Close();


        }




        private void button2_Click(object sender, EventArgs e)
        {
            KTV1 v = new KTV1();
            v.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lvGender.Visible = true;
            lvGender.Dock = DockStyle.Fill;
            lvCity.Visible = false;//第二个窗口隐藏
            lvSinger.Visible = false;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (lvGender.Visible == true)
            {
                this.Close();
            }
            else if (lvCity.Visible == true)
            {
                Form5 frm = new Form5();
                frm.Show();
                this.Close();
            }
            else if (lvSinger.Visible == true)
            {
                Form5 frm = new Form5();
                frm.Show();
                this.Close();
            }

        }

        public ImageList imgDynamic { get; set; }





        private void lvSinger_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Show();
            string a = lvSinger.SelectedItems[0].Text.ToString();
            
            string str1 = "Data Source=.;Initial Catalog=MyKTV;Integrated Security=True";
             string sqla = "select song_id ,song_name ,singer_name from song_info s ,singer_info a where s.song_id=a.singer_id and singer_name='"+a+"'";
             SqlConnection conn = new SqlConnection(str1);
             try
             {
                
                 SqlDataAdapter da = new SqlDataAdapter(sqla,conn);
                 DataSet ds = new DataSet();
                 da.Fill(ds,"aa");
                 dataGridView1.DataSource = ds.Tables["aa"];
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

        }



       
        public string url;
        public void showw()
        {
            
            string a = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
            string strr = "Data Source=.;Initial Catalog=MyKTV;Integrated Security=True";
            string sqll = "select song_url from song_info where song_name ='" + a + "'";
            SqlConnection conn = new SqlConnection(strr);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sqll, conn);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    url = dr["song_url"].ToString();
                }
                
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                this.Hide();
               
            }
        
        }




        private void dataGridView1_Click(object sender, EventArgs e)
        {
            showw();
            this.Hide();
            Form9 frm = new Form9();
            frm.url = frm.url + "\\" + url;
            frm.ShowDialog();
            
        }









        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void lvSinger_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lvCity_DoubleClick(object sender, EventArgs e)
        {
        }
        private void lvCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
