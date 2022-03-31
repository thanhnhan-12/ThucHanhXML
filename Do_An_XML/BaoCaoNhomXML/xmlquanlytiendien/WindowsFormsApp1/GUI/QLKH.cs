using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI
{
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }
        private KhachHangBLL khachhangBLL = new KhachHangBLL();
        private KhachHangDTO khachhangDTO = new KhachHangDTO();

        private void btnNhap_Click(object sender, EventArgs e)
        {
            khachhangBLL.HienThi(dgvHotieuthu);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                khachhangDTO.MaKH = txtMaKH.Text.ToLower();
                khachhangDTO.HoTen = txtTenKH.Text;
                khachhangDTO.CMT = txtCMT.Text;
                khachhangDTO.DiaChi = txtDiaChi.Text;
                khachhangDTO.GioiTinh = cbGioiTinh.Text;
                khachhangDTO.NgaySinh = dtpNgaySinh.Text;
                khachhangDTO.SoDT = txtSDT.Text;
                khachhangDTO.NgayDK = dtpNgayDK.Text;
                //gọi BLL thực hiện
                khachhangBLL.Them(khachhangDTO);
                //hiện lên dgv
                khachhangBLL.HienThi(dgvHotieuthu);
            }
        }
      



        private void QLKH_Load(object sender, EventArgs e)
        {
          
        }

        private void dgvHotieuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                khachhangDTO.MaKH = txtMaKH.Text.ToLower();

                //gọi BLL thực hiện
                khachhangBLL.Xoa(khachhangDTO);
                //hiện lên dgv
                khachhangBLL.HienThi(dgvHotieuthu);
            }
        }

     

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                khachhangDTO.MaKH = txtMaKH.Text.ToLower();
                khachhangDTO.HoTen = txtTenKH.Text;
                khachhangDTO.CMT = txtCMT.Text;
                khachhangDTO.DiaChi = txtDiaChi.Text;
                khachhangDTO.GioiTinh = cbGioiTinh.Text;
                khachhangDTO.NgaySinh = dtpNgaySinh.Text;
                khachhangDTO.SoDT = txtSDT.Text;
                khachhangDTO.NgayDK = dtpNgayDK.Text;
                //gọi BLL thực hiện
                khachhangBLL.Sua(khachhangDTO);
                //hiện lên dgv
                khachhangBLL.HienThi(dgvHotieuthu);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                khachhangDTO.MaKH = txtMaKH.Text.ToLower();
                //gọi BLL thực hiện
                var khachhangTim = khachhangBLL.TimKiem2(khachhangDTO, dgvHotieuthu);
                //khác null là tìm thấy, thực hiện bind lên ui
                if (khachhangTim != null)
                {
                    txtMaKH.Text = khachhangTim.MaKH;
                    txtTenKH.Text = khachhangTim.HoTen;
                    txtCMT.Text = khachhangTim.CMT;
                    txtDiaChi.Text = khachhangTim.DiaChi;
                    cbGioiTinh.Text = khachhangTim.GioiTinh;
                    dtpNgaySinh.Text = khachhangTim.NgaySinh;
                    txtSDT.Text = khachhangTim.SoDT;
                    dtpNgayDK.Text = khachhangTim.NgayDK;
                }
                else
                {
                    //không thấy thì xóa trăng
                    txtMaKH.Text = txtTenKH.Text = txtCMT.Text = txtDiaChi.Text
                    = cbGioiTinh.Text = dtpNgaySinh.Text = txtSDT.Text = dtpNgayDK.Text = string.Empty;
                }
            }
        }

        private void dgvHotieuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            int numrow;
            numrow = e.RowIndex;
            txtMaKH.Text = dgvHotieuthu.Rows[numrow].Cells[0].Value.ToString();
            txtTenKH.Text = dgvHotieuthu.Rows[numrow].Cells[1].Value.ToString();
            txtCMT.Text = dgvHotieuthu.Rows[numrow].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvHotieuthu.Rows[numrow].Cells[3].Value.ToString();
            cbGioiTinh.Text = dgvHotieuthu.Rows[numrow].Cells[4].Value.ToString();
            dtpNgaySinh.Text = dgvHotieuthu.Rows[numrow].Cells[5].Value.ToString();
            txtSDT.Text = dgvHotieuthu.Rows[numrow].Cells[6].Value.ToString();
            dtpNgayDK.Text = dgvHotieuthu.Rows[numrow].Cells[7].Value.ToString();
        }
        public void TimKiemXSLT(string data, string tenFileXML, string tenfileXSLT)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(@"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\" + tenfileXSLT + ".xslt");
            XsltArgumentList argList = new XsltArgumentList();
            argList.AddParam("Data", "", data);
            XmlWriter writer = XmlWriter.Create("" + tenFileXML + ".html");
            xslt.Transform(new XPathDocument(@"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\" + tenFileXML + ".xml"), argList, writer);
            writer.Close();
            System.Diagnostics.Process.Start("" + tenFileXML + ".html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            TimKiemXSLT("tb_HoTieuThu", "tb_HoTieuThu", "tb_HoTieuThu");
        }

        private void dgvHotieuthu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
