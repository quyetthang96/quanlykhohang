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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuse.Text.CompareTo("admin")==0 && txtpass.Text.CompareTo("admin") == 0)
            {
                menu t = new menu();
                t.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show(" Bạn chắc muốn thoát?","Confirm",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(di == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
