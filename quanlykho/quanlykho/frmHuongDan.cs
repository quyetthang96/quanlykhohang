using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykho
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void tmns_huongdan_Click(object sender, EventArgs e)
        {   
            string file = "F:\\HDSD\\HDSD.mhtml";
            //file = "HDSD.mhtml";
            //string html = System.IO.File.ReadAllText(file);
            //wbw_huongdan.DocumentText = html;
            wbw_huongdan.Url = new Uri(file);
        }

        private void frmHuongDan_Load(object sender, EventArgs e)
        {
            tmns_huongdan_Click(sender, e);
        }

        private void tmns_nhaphang_Click(object sender, EventArgs e)
        {
            string file = "F:\\HDSD\\Nhập hàng.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void tmns_xuathang_Click(object sender, EventArgs e)
        {
            string file = "F:\\HDSD\\Xuất hàng.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void tmns_timkiem_Click(object sender, EventArgs e)
        {
            string file = "F:\\HDSD\\Tìm kiếm.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void tmns_thongke_Click(object sender, EventArgs e)
        {
            string file = "F:\\HDSD\\Thống kê.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void wbw_huongdan_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
