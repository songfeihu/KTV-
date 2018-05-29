using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{
    public partial class KTV1 : Form
    {
        public KTV1()
        {
            InitializeComponent();
        }

        private void KTV1_Load(object sender, EventArgs e)
        {
            
        }   
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //跳转歌星点歌
             Form5 frm = new  Form5();//创建窗体对象
             frm.Show(); // 窗体显示
             this.Hide();//隐藏窗体

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
             //跳转歌曲列表  // 金曲排行
            Form7 s = new Form7();
            s.Show();
            this.Hide();
        
        }

        private void tp2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {   
            //跳转拼音点歌
           qinyindiange s = new  qinyindiange ();
            s.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //跳转数字点歌
            shuzi S = new shuzi();
            S.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //跳转分类点歌
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }
    }
}
