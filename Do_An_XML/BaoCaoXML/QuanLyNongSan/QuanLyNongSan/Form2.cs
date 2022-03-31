using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNongSan
{
    public partial class Form2 : Form
    {
        static public Form3 form3;
        static public Form4 form4;
        public static String nameEmployee;
        public String maNV = "";
        public Form2()
        {
            InitializeComponent();
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonNhapNS_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();

        }

        private void buttonXuatNS_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
        }

        private void buttonQLKhachHang_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            FormSaoLuuData form6 = new FormSaoLuuData();
            form6.Show();
        }

   
    }
}
