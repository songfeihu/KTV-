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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string ccc;
        private void Form6_Load(object sender, EventArgs e)
        {
                DBHelper db = new DBHelper();//工具类对象
            //连接数据库
            SqlConnection conn = new SqlConnection(DBHelper.str);
            //SQL语句
            StringBuilder sql = new StringBuilder();
            string stc = "Data Source=.;Initial Catalog=MyKTV;Integrated Security=True";
           string o = "select resource_path from dbo.resource_path where resource_path='C:\\Users\\Administrator\\Desktop\\KTV素材\\新建文件夹'";
           SqlConnection connc = new SqlConnection(stc);
           try
           {
               connc.Open();
               SqlCommand comm = new SqlCommand(o, connc);
               SqlDataReader dr = comm.ExecuteReader();
               if (dr != null)
               {
                   if (dr.HasRows)
                   {
                       while (dr.Read())
                       {
                           ccc = dr["resource_path"].ToString();
                       }
                       dr.Close();
                   }
               }
               textBox1.Text = ccc;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
           finally 
           {
               connc.Close();
           }
        }

        public void show() 
        {


        }









        private void button1_Click(object sender, EventArgs e)
        {
          
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }
    }
}