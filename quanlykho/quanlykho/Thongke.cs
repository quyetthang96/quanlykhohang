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

namespace quanlykho
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
               // SqlConnection con = new SqlConnection("server = HP6460B-PC\\SQLEXPRESS; database = QLKH; integrated security = SSPI");
            SqlConnection con = new SqlConnection("Data Source = QUYETTHANG; Initial Catalog = quanlykho; Integrated Security = True");
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand sc1 = new SqlCommand("ht_hangnhap", con);
                sc1.CommandType = CommandType.StoredProcedure;
                sc1.Parameters.Add(new SqlParameter("ngay1", dtp1.Value.ToString("MM-dd-yyyy")));
                sc1.Parameters.Add(new SqlParameter("ngay2", dtp2.Value.ToString("MM-dd-yyyy")));
                SqlDataAdapter da1 = new SqlDataAdapter(sc1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                SqlCommand sc2 = new SqlCommand("ht_hangnhap", con);
                sc2.CommandType = CommandType.StoredProcedure;
                sc2.Parameters.Add(new SqlParameter("ngay1", dtp1.Value.ToString("MM-dd-yyyy")));
                sc2.Parameters.Add(new SqlParameter("ngay2", dtp2.Value.ToString("MM-dd-yyyy")));
                SqlDataAdapter da2 = new SqlDataAdapter(sc2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                con.Close();
                dataGridView1.DataSource = dt1;
                dataGridView1.Show();
                dataGridView2.DataSource = dt2;
                dataGridView2.Show();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {

        }
    }
}
