using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTV
{
    public class DBHelper
    {
        public static string str = "Data Source=.;Initial Catalog=MyKTV;Uid=sa;Pwd=980216";
        public static  SqlConnection conn = new SqlConnection(str);


        public void Open()
        {
            conn.Open();
        }
        public void Close()
        {
            conn.Close();
        }
    }
}
