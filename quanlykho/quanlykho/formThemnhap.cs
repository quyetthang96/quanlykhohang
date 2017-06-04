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
    public partial class formThemnhap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QUYETTHANG;Initial Catalog=quanlykho;Integrated Security=True");
        public formThemnhap()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            conn.Open();
            string tk = "select ct.so_pn,ngaynhap,ma_ncc,nguoigiao,noidung,taikhoan,ct.ma_kho ,ct.ma_hh,ct.soluong,ct.dongia  from chitietphieunhap ct, phieunhap1 pn1 where ct.so_pn=pn1.so_pn";
            SqlDataAdapter da = new SqlDataAdapter(tk, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dg1.DataSource = tb;
            dg1.Columns[0].HeaderText = "Mã phiếu nhập";
            dg1.Columns[0].Width = 130;
            dg1.Columns[0].HeaderText = "Ngày nhập hàng";
            dg1.Columns[0].Width = 130;
            dg1.Columns[0].HeaderText = "Mã Nhà cung cấp";
            dg1.Columns[0].Width = 150;
            dg1.Columns[0].HeaderText = "Người giao";
            dg1.Columns[0].Width = 130;
            dg1.Columns[0].HeaderText = "Nội dung";
            dg1.Columns[0].Width = 130;
            dg1.Columns[0].HeaderText = "Tài khoản ";
            dg1.Columns[0].Width = 130;
            dg1.Columns[0].HeaderText = "Mã Kho";
            dg1.Columns[0].Width = 130;
            dg1.Columns[0].HeaderText = "Mã Hàng Hóa";
            dg1.Columns[0].Width = 130;
            dg1.Columns[0].HeaderText = "Số lượng";
            dg1.Columns[0].Width = 130;
            dg1.Columns[0].HeaderText = "Đơn giá";
            dg1.Columns[0].Width = 130;
            conn.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void formThemnhap_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                string tk = "insert into phieunhap1(so_pn,ngaynhap,ma_ncc,nguoigiao,noidung,taikhoan,ma_kho) values ('" + txtmpn.Text + "', '" + datenn.Text + " ', '" + cbnhacc.Text + "','" + txtnggiao.Text + "','" + txtnd.Text + "','" + txttaikhoan.Text + "','" + cbmakho.Text + "')  insert into chitietphieunhap values('" + txtmpn.Text + "','" + cbmahh.Text + "','" + cbmakho.Text + "','" + txtsoluong.Text + "','" + txtdongia.Text + "' )";
                SqlCommand comm = new SqlCommand(tk, conn);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thành công .", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch
            {
                MessageBox.Show("Không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            hienthi();


        }

        private void dg1_Click(object sender, EventArgs e)
        {
            int index = dg1.CurrentRow.Index;
            txtmpn.Text = dg1.Rows[index].Cells[0].Value.ToString();
            datenn.Text = dg1.Rows[index].Cells[1].Value.ToString();
            cbnhacc.Text = dg1.Rows[index].Cells[2].Value.ToString();
            txtnggiao.Text = dg1.Rows[index].Cells[3].Value.ToString();
            txtnd.Text = dg1.Rows[index].Cells[4].Value.ToString();
            txttaikhoan.Text = dg1.Rows[index].Cells[5].Value.ToString();
            cbmakho.Text = dg1.Rows[index].Cells[6].Value.ToString();
            cbmahh.Text = dg1.Rows[index].Cells[7].Value.ToString();
            txtsoluong.Text = dg1.Rows[index].Cells[8].Value.ToString();
            txtdongia.Text = dg1.Rows[index].Cells[9].Value.ToString();
        }

        private void showcbmakho()
        {
        }
        private void cbmakho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string tk = "update phieunhap1 set ngaynhap='" + datenn.Text + "' ,ma_ncc= '" + cbnhacc.Text + "',nguoigiao = '" + txtnggiao.Text + "',noidung ='" + txtnd.Text + "',taikhoan= '" + txttaikhoan.Text + "',ma_kho = '" + cbmakho.Text + "'where so_pn='" + txtmpn.Text + "' update chitietphieunhap set ma_hh= '" + cbmahh.Text + "' ,ma_kho= '" + cbmakho.Text + "', soluong='" + txtsoluong.Text + "',dongia='" + txtdongia.Text + "' where so_pn='" + txtmpn.Text + "'";
                SqlCommand comm = new SqlCommand(tk, conn);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                conn.Close();
                hienthi();

            }
            catch
            {
                MessageBox.Show("Sửa lôi");
            }




        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string tk = "delete from phieunhap1 where so_pn='" + txtmpn.Text + "' delete from chitietphieunhap where so_pn='" + txtmpn.Text + "' ";
                SqlCommand comm = new SqlCommand(tk, conn);
                SqlDataAdapter da = new SqlDataAdapter(comm);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                hienthi();

            }
            catch
            {
                MessageBox.Show("Xóa lỗi");
            }

           
        }


    }
}
