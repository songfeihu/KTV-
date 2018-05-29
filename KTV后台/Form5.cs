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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public void show()
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


        public void showw() 
        {
            DBHelper db = new DBHelper();
            SqlConnection conn = new SqlConnection(DBHelper.str);
            string sql = "  select * from   singer_type";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();




            da.Fill(ds, "s");


        }








        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "请选择文件";
            openFileDialog1.Filter = "所有文件(*.jpg)|*jpg"; //设置要选择的文件的类型
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;//返回文件的完整路径        
                //textBox4.Text = Text.FromFile(file);

            }
        }
        }
    }
