using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV后台
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 新增歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.Show();
       
        }

        private void 歌曲管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chaxun S = new chaxun();
            S.Show();
       
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询歌手信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 s = new Form7();
            s.Show();
  
        }

        private void 退出ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 歌曲查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 S = new Form5();
            S.Show();
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 设置歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 S = new Form6();
            S.Show();
          
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            a.Show();
            this.Hide();
        }
    }
}
