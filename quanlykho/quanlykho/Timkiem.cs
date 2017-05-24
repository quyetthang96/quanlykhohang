using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlykho
{
    public partial class Timkiem : Form
    {
        SqlConnection con = new SqlConnection("data source=8470P-PC\\CNTTSQL;initial catalog=quanlykho;integrated security=True;MultipleActiveResultSets=True");
        public Timkiem()
        {
            InitializeComponent();
        }
        void Hienthi()
        {
            con.Open();
            string str = string.Format("select hh.ma_hh as[mã hàng hóa],hh.ten_hh as [Tên hàng hóa],hh.ma_nhom as[Nhóm hàng hóa],hh.dvt as[dvt] from hanghoa hh");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = string.Format("{0}_Timkiem", comboBox1.SelectedItem.ToString());
            SqlCommand sc = new SqlCommand(str, con);
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add(new SqlParameter("@keyword", txttim.Text));
            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
