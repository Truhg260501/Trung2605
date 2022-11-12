using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        bool ktra(string ma)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == ma) return true;
            }
            return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string magv = txt_magv.Text;
            if (ktra(magv) == true)
            {
                MessageBox.Show("Trùng mã");
                txt_magv.Focus();
            }
            else
            {
                string tengv = txt_tengv.Text;
                if (tengv == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên giáo viên");
                    txt_tengv.Focus();
                }
                else
                {
                    string qquan = txt_quequan.Text;
                    if (qquan == "")
                    {
                        MessageBox.Show("bạn chưa nhập quê quán");
                        txt_quequan.Focus();
                    }
                    else
                    {
                        string hsl = txt_hsl.Text;
                        if (hsl == "")
                        {
                            MessageBox.Show("Bạn chưa nhập hệ số lương");
                            txt_hsl.Focus();
                        }
                        else
                        {
                            string namsinh = txt_namsinh.Text;
                            if (namsinh == "")
                            {
                                MessageBox.Show("Bạn chưa nhập năm xuất bản");
                                txt_namsinh.Focus();
                            }
                            else
                            {
                                ListViewItem item = new ListViewItem();

                                item.Text = magv;
                                item.SubItems.Add(tengv);
                                item.SubItems.Add(qquan);
                                item.SubItems.Add(hsl);
                                item.SubItems.Add(namsinh);

                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Checked) listView1.Items.RemoveAt(i);
            }

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.RemoveAt(item.Index);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == txt_magv.Text)
                {
                    listView1.Items[i].SubItems[1].Text = txt_tengv.Text;
                    listView1.Items[i].SubItems[2].Text = txt_quequan.Text;
                    listView1.Items[i].SubItems[3].Text = txt_hsl.Text;
                    listView1.Items[i].SubItems[4].Text = txt_namsinh.Text;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    txt_magv.Text = listView1.Items[i].Text;
                    txt_tengv.Text = listView1.Items[i].SubItems[1].Text;
                    txt_quequan.Text = listView1.Items[i].SubItems[2].Text;
                    txt_hsl.Text = listView1.Items[i].SubItems[3].Text;
                    txt_namsinh.Text = listView1.Items[i].SubItems[4].Text;
                }
            }
        }
    }
}
