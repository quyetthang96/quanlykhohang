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
            string connString = "Data Source = QUYETTHANG; Initial Catalog = quanlykho; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
