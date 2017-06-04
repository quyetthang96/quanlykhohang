using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlykho
{
    class ketnoi
    {

        public static SqlConnection Conn()
        {
            string connString = "server = HP6460B - PC\\SQLEXPRESS; database = QLHH; integrated security = SSPI";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
