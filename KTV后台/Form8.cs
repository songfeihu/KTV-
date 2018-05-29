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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //接收用户输入的数据
            //string oldPassword = txtOldPwd.Text.Trim();
            string newPassword = txtNewPwd.Text.Trim();
            //string retry = txtRetry.Text.Trim();
            DBHelper db = new DBHelper();//工具类对象
            //连接数据库
            SqlConnection conn = new SqlConnection(DBHelper.str);
            //SQL语句
            StringBuilder a = new StringBuilder();


            //连接字符串

            string sql = "update dbo.admin_info set admin_pwd='"+txtNewPwd.Text+"'   where admin_pwd ='" + txtOldPwd.Text + "'";

            //判断两次密码输入是否一致
            if (newPassword == txtRetry.Text)
            {
               
                try
                {
                    conn.Open();//打开数据库
                    SqlCommand comm = new SqlCommand(sql.ToString(), conn);//创建命令对象
                    int num = comm.ExecuteNonQuery();//执行命令，接收返回值
                    if (num > 0)
                    {
                        MessageBox.Show("修改成功！");
                    }
                    else 
                    {
                        MessageBox.Show("原密码输入错误");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();//数据库关闭
                }
            }
            else
            {
                MessageBox.Show("两次输入的密码不符");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();//本窗口关闭
        }

        private void Form8_Load(object sender, EventArgs e)
        {


        }


    }
    }

