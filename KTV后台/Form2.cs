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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private bool CheckUser()
        {
            //返回值
            bool isReact = false;
            //创建工具类对象
            DBHelper db = new DBHelper();
            //连接字符串
            SqlConnection conn = new SqlConnection(DBHelper.str);
            //接受用户输入的用户名和密码
            string user = this.txtUser.Text.Trim();
            string pwd = this.txtPwd.Text.Trim();
            try
            {
                //打开数据库
                conn.Open();
                //创建SQl语句
                string sql = "select count(*) from dbo.admin_info where admin_name = '" + user + "' and admin_pwd = '" + pwd + "'";
                //创建命令对像
                SqlCommand comm = new SqlCommand(sql, conn);
                //接收受影响的行数
                int num = Convert.ToInt32(comm.ExecuteScalar());
                //判断是否有受影响的行数
                if (num == 1)
                {
                    isReact = true;
                    return isReact; //返回结果
                }
                else
                {
                    isReact = false;
                    return isReact; //返回结果
                }
            }
            catch (Exception ex)
            {
                //抛出异常
                MessageBox.Show("发生异常" + ex);
                return isReact;
            }
            finally
            {
                conn.Close();//数据库关闭
            }
        }

        /// <summary>
        /// 检查用户是否输入数据
        /// </summary>
        public bool CheckInput()
        {
            if (this.txtUser.Text == string.Empty)
            {
                MessageBox.Show("请输入用户名");
                this.txtUser.Focus();
                return false;
            }
            else if (this.txtPwd.Text == string.Empty)
            {
                MessageBox.Show("请输入密码");
                this.txtPwd.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (CheckInput() == true)
            {
                //如果返回值为false，则登陆失败
                if (CheckUser() == true)
                {
                    Form3 frm = new   Form3();//创建窗体对象
                    frm.Show(); // 窗体显示
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
