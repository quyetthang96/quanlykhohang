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

        SqlConnection con = new SqlConnection("Data Source=QUYETTHANG;Initial Catalog=quanlykho;Integrated Security = True");
        //SqlConnection con = new SqlConnection("data source=8470P-PC\\CNTTSQL;initial catalog=quanlykho;integrated security=True;MultipleActiveResultSets=True");
        public Timkiem()
        {
            InitializeComponent();
        }
        void Hienthi()
        {
            con.Open();
            string str = string.Format("select * from hanghoa hh");
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg1.DataSource = dt;
            con.Close();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = string.Format("{0}_Timkiem", comboBox1.SelectedItem.ToString());
            SqlCommand sc = new SqlCommand(str, con);
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.Add(new SqlParameter("@keyword", txttim.Text));
            sc.ExecuteNonQuery();
            SqlDataReader dr = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dg1.DataSource = dt;
            con.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Timkiem_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string tk = "insert into hanghoa(ma_hh,ten_hh,dvt) values('" + txtmahang.Text+"','"+txtten.Text+"','"+cbmdvt.Text+"') ";
            SqlCommand comm = new SqlCommand(tk, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            comm.ExecuteNonQuery();
            con.Close();
            Hienthi();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string tk = "update  hanghoa set ten_hh ='"+ txtten.Text + "', dvt='" + cbmdvt.Text + "' where ma_hh ='"+txtmahang.Text+"' ";
            SqlCommand comm = new SqlCommand(tk, con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            comm.ExecuteNonQuery();
            con.Close();
            Hienthi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dg1.CurrentRow.Index;
            txtmahang.Text = dg1.Rows[index].Cells[0].Value.ToString();
            txtten.Text = dg1.Rows[index].Cells[1].Value.ToString();
            cbmdvt.Text = dg1.Rows[index].Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string tk = "delete  hanghoa where ma_hh ='" +txtmahang.Text + "' ";
            string kt = "delete CTphieuxuat where  ma_hh ='" + txtmahang.Text + "' ";
            string xoa = " delete chitietphieunhap where  ma_hh ='" + txtmahang.Text + "' ";
            SqlCommand comm = new SqlCommand(tk, con);
            SqlCommand comm2 = new SqlCommand(kt, con);
            SqlCommand comm3 = new SqlCommand(xoa, con);      
            comm.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
            comm3.ExecuteNonQuery();
            con.Close();
            Hienthi();

        }

       
    }
}
