using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;


namespace WindowsFormsApp1.GUI
{
    public partial class DangNhap : Form
    {
        DangNhap1 dn = new DangNhap1();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Equals("") || txtMK.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống các trường!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTenDN.Focus();
            }
            else
            {

                if (dn.kiemtraTTDN("xmltaikhoan.xml", txtTenDN.Text, txtMK.Text) == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Hide();
                    Main frm1 = new Main();
                    frm1.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDN.Text = "";
                    txtMK.Text = "";
                    txtTenDN.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
