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
    public partial class Form4 : Form
    {

        XMLFile XmlFile = new XMLFile();
        XmlDocument XDoc;
        XmlDocument XDocKhachHang;
        int sTT = 0;


        public Form4()
        {
            InitializeComponent();
        }


        void loadTable() {
            dataGridView1.Rows.Clear();
            XDoc = XmlFile.getXmlDocument("ChiTietNongSans.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/ChiTietNongSans/ChiTietNongSan");
            foreach (XmlNode x in nodeList)
            {
                dataGridView1.Rows.Add(x.ChildNodes[0].InnerText, x.ChildNodes[1].InnerText, x.ChildNodes[3].InnerText, x.ChildNodes[2].InnerText, x.ChildNodes[5].InnerText);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBoxMaKhachHang.Text = "";
            XDocKhachHang = XmlFile.getXmlDocument("KhachHangs.xml");
            loadTable();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuongMua = int.Parse(textBoxSoLuong.Text);
                if ( soLuongMua > 0 && int.Parse(textBoxSoLuong.Text) <= int.Parse(dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString()))
                {
                    dataGridView2.Rows.Add(
                        ++sTT,
                        dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString(),
                        dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString(),
                        soLuongMua,
                        dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString(),
                        (soLuongMua * int.Parse(dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString()))
                        );
                }
                else
                    MessageBox.Show("Đầu Vào Sai","Thông Báo");
                textBoxSoLuong.Text = "";
            }
            catch { }
            capNhatTongTien();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try { dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index); }
                catch{}
            capNhatTongTien();
        }

        void capNhatTongTien() {
            int tongTien = 0;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++) {
                tongTien += int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString());
            }
            labelTongTien.Text = tongTien.ToString();
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
            Image image = Image.FromFile("imgs/"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+".jpg");

          
            pictureBox1.Image = image;
        }

        private void textBoxMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                XDocKhachHang = XmlFile.getXmlDocument("KhachHangs.xml");
                XmlNodeList nodeList = XDocKhachHang.SelectNodes("/KhachHangs/KhachHang[maKH ='" + textBoxMaKhachHang.Text + "']");
                if (nodeList.Count != 0)
                {
                    labelDanhSachNS.Text = nodeList[0].ChildNodes[1].InnerText;
                }
            }
            catch { }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataGridView2.CurrentRow.Cells[5].Value = (int.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()) * int.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString())).ToString();
                capNhatTongTien();
            }
            catch { }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            List<XmlNode> nodeList = new List<XmlNode>();
            XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietHoaDons.xml");
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {

                XmlElement node = XDoc.CreateElement("ChiTietHoaDon");

                XmlElement maNS = XDoc.CreateElement("maNS");
                Console.WriteLine(i);


                maNS.InnerText = dataGridView2.Rows[i].Cells[1].Value.ToString();


                XmlElement soLuong = XDoc.CreateElement("soLuong");

                soLuong.InnerText = dataGridView2.Rows[i].Cells[3].Value.ToString();
                XmlElement donGia = XDoc.CreateElement("DonGia");
                donGia.InnerText = dataGridView2.Rows[i].Cells[4].Value.ToString(); ;

                node.AppendChild(maNS);
                node.AppendChild(soLuong);
                node.AppendChild(donGia);
                nodeList.Add(node);
            }
            HoaDon hoaDon = new HoaDon();

          
            String maKH = textBoxMaKhachHang.Text;
            Console.WriteLine(maKH+"123");
            if (maKH.Equals(""))
                maKH = "KH00000";
            
            XmlNodeList n = XDocKhachHang.SelectNodes("/KhachHangs/KhachHang[maKH = '" + maKH  + "']");
            n[0].ChildNodes[2].InnerText = (int.Parse(n[0].ChildNodes[2].InnerText) + int.Parse(labelTongTien.Text)).ToString();
            XDocKhachHang.Save("KhachHangs.xml");


          
               hoaDon.add(XDoc, nodeList, maKH, "X");
        
          

            loadTable();
            MessageBox.Show("Đã Thanh Toán Thành Công");
        }

        void resetAll() {
            dataGridView2.Rows.Clear();
            textBoxMaKhachHang.Text = "";
            labelDanhSachNS.Text = "";
            labelTongTien.Text = "";
        }

     
     
   





    }
}
