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
    public partial class Xuathang : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QUYETTHANG;Initial Catalog=quanlykho;Integrated Security=True");
        public Xuathang()
        {
            InitializeComponent();
        }

        private void Xuathang_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void hienthi()
        {
            conn.Open();
            string tk = "select ct.so_px,ngayxuat,ct.ma_kho,ma_khach,ct.ma_hh,ct.soluong,ct.dongia  from CTphieuxuat ct, phieuxuat px where ct.so_px=px.so_px";
            SqlDataAdapter da = new SqlDataAdapter(tk, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dg1.DataSource = tb;
            dg1.Columns[0].HeaderText = "Mã phiếu xuất";
            dg1.Columns[0].Width = 130;
            dg1.Columns[1].HeaderText = "Ngày xuất hàng";
            dg1.Columns[1].Width = 130;
            dg1.Columns[2].HeaderText = "Mã Kho";
            dg1.Columns[2].Width = 130;
            dg1.Columns[3].HeaderText = "Mã khách hàng";
            dg1.Columns[3].Width = 150;   
            dg1.Columns[4].HeaderText = "Mã Hàng Hóa";
            dg1.Columns[4].Width = 130;
            dg1.Columns[5].HeaderText = "Số lượng";
            dg1.Columns[5].Width = 130;
            dg1.Columns[6].HeaderText = "Đơn giá";
            dg1.Columns[6].Width = 130;
            conn.Close();
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}
