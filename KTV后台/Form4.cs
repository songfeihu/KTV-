using KTV;
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

namespace KTV后台
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
          private void Form4_Load(object sender, EventArgs e)
        {
            Showw();
        }


        public void Showw()
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(DBHelper.str);
            string sql = "  select * from   singer_type";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds, "s");
            DataRow rows = ds.Tables["s"].NewRow();
            rows["singertype_id"] = -1;
            rows["singertype_name"] = "请选择";
            ds.Tables["s"].Rows.InsertAt(rows, 0);

            comboBox1.DataSource = ds.Tables["s"];
            comboBox1.DisplayMember = "singertype_name";
            comboBox1.ValueMember = "singertype_id";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "请选择文件";
            openFileDialog1.Filter = "所有文件(*.jpg)|*jpg"; //设置要选择的文件的类型
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;//返回文件的完整路径        
                pictureBox1.Image = Image.FromFile(file);

            }
        }



        string fileName = "";

        public void SongInfoAdd()
        {
            DBHelper db = new DBHelper();
            string name = textBox2.Text;//歌手姓名
            string type = "";//类别
            if (radioButton1.Checked)
            {
                type = "男";
            }
            else if (radioButton2.Checked)
            {
                type = "女";
            }
            else if (radioButton3.Checked)
            {
                type = "组合";
            }
            int id = Convert.ToInt32(comboBox1.SelectedValue);//类型            
            string description = textBox2.Text;//描述
            SqlConnection con = new SqlConnection(DBHelper.str);
            string sql = "insert into singer_info values('" + name + "'," + id + ",'" + type + "','" + fileName + "','" + description + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                  
                    MessageBox.Show("歌手添加成功");
                }
                else
                {
                    MessageBox.Show("歌手添加失败");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("歌手加载失败"); ;
            }
            finally
            {
                con.Close();//关闭
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SongInfoAdd();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}