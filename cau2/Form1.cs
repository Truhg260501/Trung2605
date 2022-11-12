using System;
using System.Windows.Forms;
namespace cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string user = txt_dangnhap.Text;
            string mk = txt_matkhau.Text;
            if (txt_dangnhap.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo !", MessageBoxButtons.OK);
                txt_dangnhap.Focus();
            }
            else if (txt_matkhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK);
                txt_matkhau.Focus();
            }
            else
            {
                MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                Form dn = new Form2();
                dn.Show();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_dangnhap.Text = "";
            txt_matkhau.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
