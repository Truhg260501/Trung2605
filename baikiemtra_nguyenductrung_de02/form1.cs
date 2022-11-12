using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baikiemtra_nguyenductrung_de02
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int n, kq = 1;
            bool kt;
            kt = int.TryParse(txt_nhapn.Text.Trim(), out n);
            if (kt == false)
            {
                txt_ketqua.Text = "bạn vừa nhập sai";
                txt_nhapn.Focus();
            }
            else if (n < 0)
            {
                txt_nhapn.Text = "bạn vừa nhập số âm";
                txt_ketqua.Focus();
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    kq *= i;
                }
                txt_ketqua.Text = kq.ToString();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_nhapn.Text = "";
            txt_ketqua.Text = "";
        }

        private void txt_ketqua_TextChanged(object sender, EventArgs e)
        {
            txt_ketqua.Enabled = false;
        }
    }
}
