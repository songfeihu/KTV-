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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            KTV1 s = new KTV1();
            s.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
              Form6 S = new Form6();
              S.typeName = Convert.ToInt32(listView1.SelectedItems[0].Tag);
              S.Show();
              this.Hide();

           
        }
    }
}
