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
    public partial class chaxun : Form
    {
        public chaxun()
        {
            InitializeComponent();
        }
        public void show() 
        {
            //工具类对象
            DBHelper db = new DBHelper();
            //连接数据库
            SqlConnection conn;
            DataSet ds = new DataSet();
            conn = new SqlConnection(DBHelper.str);
            //创建SQL语句  
            string sql = "select song_name,singertype_name,song_play_count from dbo.song_info as s1,dbo.singer_type as s2 where s2.singertype_id = s1.songtype_id and s2.singertype_name = '"+comboBox1.Text+"' and s1.song_name = '"+textBox1.Text+"'";
            //创建适配器对象
            SqlDataAdapter da = new SqlDataAdapter(sql.ToString(), conn);
            //创建数据集对象
            ds = new DataSet();
            //填充数据集
            da.Fill(ds, "com");
            //绑定数据源
            dataGridView1.DataSource = ds.Tables["com"];

        }
        public void show1()
        {
            //工具类对象
            DBHelper db = new DBHelper();
            //连接数据库
            SqlConnection conn;
            DataSet ds = new DataSet();
            conn = new SqlConnection(DBHelper.str);
            //创建SQL语句  
            string sql = "select song_name,singertype_name,song_play_count from dbo.song_info as s1,dbo.singer_type as s2 where s2.singertype_id = s1.songtype_id";
            //创建适配器对象
            SqlDataAdapter da = new SqlDataAdapter(sql.ToString(), conn);
            //创建数据集对象
            ds = new DataSet();
            //填充数据集
            da.Fill(ds, "com");
            //绑定数据源
            dataGridView1.DataSource = ds.Tables["com"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }

        private void chaxun_Load(object sender, EventArgs e)
        {
            show1();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
