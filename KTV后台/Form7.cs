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
    public partial class Form7 : Form
    {
        public Form7()
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
        string sql = @" select singer_name,singertype_name,singer_gender,singer_description from singer_info
        inner join singer_type as S1
          on singer_info.singertype_id  =S1.singertype_id
          where singer_name='" + textBox1.Text + "'";
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

        private void Form7_Load(object sender, EventArgs e)
        {
           
         //   DBHelper db = new DBHelper();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
