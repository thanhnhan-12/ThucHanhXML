using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNongSan.Model;
using System.Xml;

namespace QuanLyNongSan
{
    public partial class Form5 : Form
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        public Form5()
        {
            InitializeComponent();
        }

        void capNhatBang() {
            stt = 0;
            dataGridView1.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("KhachHangs.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/KhachHangs/KhachHang");
            foreach (XmlNode x in nodeList)
            {
                dataGridView1.Rows.Add(++stt,
                    x.ChildNodes[1].InnerText,
                    x.ChildNodes[0].InnerText,
                    x.ChildNodes[2].InnerText,
                    x.ChildNodes[3].InnerText,
                    x.ChildNodes[4].InnerText);

            }

        }


        private void Form5_Load(object sender, EventArgs e)
        {
            capNhatBang();

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try {
                if (textBoxTenKH.Text.Equals("") && textBoxNamSinh.Text.Equals("") && textBoxDiaChi.Text.Equals(""))
                {
                    MessageBox.Show("Nhập THiếu Thông Tin \nVui Lòng Nhập Đày Đủ");
                }
                else {
                    int namSinh = int.Parse(textBoxNamSinh.Text);
                    KhachHang kh = new KhachHang();

                    if (kh.themKhachHang(textBoxTenKH.Text, namSinh, textBoxDiaChi.Text))
                        MessageBox.Show("Thêm Khách Hàng Thành Công","Thông Báo");
                    capNhatBang();
                }

            }
            catch{
                MessageBox.Show("Có gì đó sai sai");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();

            if(kh.suaThongTin(dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                textBoxTenKH.Text,int.Parse(textBoxNamSinh.Text),textBoxDiaChi.Text))
                MessageBox.Show("Đã Sửa Thông Tin Thành Công","Thông Báo");
            else
                MessageBox.Show("Sửa Thông Tin ĐÃ Thất Bại","Thông Báo");
            capNhatBang();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắc Về Việc Này", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                try
                {
                    KhachHang kh = new KhachHang();
                    if(kh.xoaThongTin(dataGridView1.CurrentRow.Cells[2].Value.ToString()))
                    capNhatBang();

                }
                catch { }

            }
           

        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxNamSinh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxDiaChi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch { }
        }
    }
}
