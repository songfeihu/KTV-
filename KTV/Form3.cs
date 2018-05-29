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
    public partial class shuzi : Form
    {
        public shuzi()
        {
            InitializeComponent();
        }
           private  void shuzi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   

            //数字点歌 
            Form8 song = new  Form8();
            string sql1 = "select o.song_name,i.singer_name,o.song_play_count from song_info as o ,singer_info as i where i.singer_id = o.singer_id and o.song_word_count=" + txtFont.Text + "order by singer_name";
            song.sql = sql1;
            this.Hide();
            song.Show();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            KTV1 s = new KTV1();
            s.Show();
            this.Hide();
        }





    }
}
