using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BLL
{
    public class HoaDonBLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string fileName = @"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\tb_HoaDon.xml";

        public object LuongDienTT { get; private set; }

        public HoaDonBLL()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(HoaDonDTO HoaDonThem)
        {
            
            XmlNode HoaDon = doc.CreateElement("_x0027_tb_HoaDon_x0027_");

            
            XmlElement MaHD = doc.CreateElement("mahd");
            MaHD.InnerText = HoaDonThem.MaHD;
            HoaDon.AppendChild(MaHD);

            XmlElement MaKH = doc.CreateElement("makh");
            MaKH.InnerText = HoaDonThem.MaKH;
            HoaDon.AppendChild(MaKH);

            XmlElement LuongDienTT = doc.CreateElement("luongdientt");
            LuongDienTT.InnerText =HoaDonThem.LuongDienTT.ToString();
            HoaDon.AppendChild(LuongDienTT);

            XmlElement LoaiDien = doc.CreateElement("loaidien");
            LoaiDien.InnerText = HoaDonThem.LoaiDien;
            HoaDon.AppendChild(LoaiDien);

            XmlElement ThanhTien = doc.CreateElement("thanhtien");
            ThanhTien.InnerText = HoaDonThem.ThanhTien.ToString();
            HoaDon.AppendChild(ThanhTien);

           
            root.AppendChild(HoaDon);
            doc.Save(fileName);//lưu dữ liệu
        }

        public void Sua(HoaDonDTO HoaDonSua)
        {
           
            XmlNode HoaDonCu = root.SelectSingleNode("_x0027_tb_HoaDon_x0027_[mahd='" + HoaDonSua.MaHD+ "']");
            if (HoaDonCu != null)
            {
                XmlNode HDSuaMoi = doc.CreateElement("_x0027_tb_HoaDon_x0027_");

             
                XmlElement MaHD = doc.CreateElement("mahd");
                MaHD.InnerText = HoaDonSua.MaHD;
                HDSuaMoi.AppendChild(MaHD);

                XmlElement MaKH = doc.CreateElement("makh");
                MaKH.InnerText = HoaDonSua.MaKH;
                HDSuaMoi.AppendChild(MaKH);

                XmlElement LuongDienTT = doc.CreateElement("luongdientt");
                LuongDienTT.InnerText = HoaDonSua.LuongDienTT.ToString();
                HDSuaMoi.AppendChild(LuongDienTT);

                XmlElement LoaiDien = doc.CreateElement("loaidien");
                LoaiDien.InnerText = HoaDonSua.LoaiDien;
                HDSuaMoi.AppendChild(LoaiDien);

                XmlElement ThanhTien = doc.CreateElement("thanhtien");
                ThanhTien.InnerText = HoaDonSua.ThanhTien.ToString();
                HDSuaMoi.AppendChild(ThanhTien);


               
                root.ReplaceChild(HDSuaMoi, HoaDonCu);
                doc.Save(fileName);
            }
        }

        public void Xoa(HoaDonDTO HoaDonXoa)
        {
            XmlNode HDCanXoa = root.SelectSingleNode("_x0027_tb_HoaDon_x0027_[mahd='" + HoaDonXoa.MaHD + "']");
            if (HDCanXoa != null)
            {
                root.RemoveChild(HDCanXoa);

                doc.Save(fileName);
            }
        }

        public void TimKiem(HoaDonDTO HoaDonTim, DataGridView dgv)
        {
            dgv.Rows.Clear();
            XmlNode HDCanTim = root.SelectSingleNode("_x0027_tb_HoaDon_x0027_[mahd='" + HoaDonTim.MaHD + "']");

            if (HDCanTim != null)
            {
                dgv.ColumnCount = 5;//khai báo số cột
                dgv.Rows.Add();//thêm một dòng mới

                //đưa dữ liệu vào dòng vừa tạo
                dgv.Rows[0].Cells[0].Value = HDCanTim.SelectSingleNode("maHD").InnerText;
                dgv.Rows[0].Cells[1].Value = HDCanTim.SelectSingleNode("maKH").InnerText;
                dgv.Rows[0].Cells[2].Value = HDCanTim.SelectSingleNode("loaiDien").InnerText;
                dgv.Rows[0].Cells[3].Value = HDCanTim.SelectSingleNode("luongDienTT").InnerText;
                dgv.Rows[0].Cells[4].Value = HDCanTim.SelectSingleNode("thanhTien").InnerText;

            }
        }

        /// <summary>
        /// Tìm và trả về đối tượng sách tìm thấy, không thấy = null
        /// </summary>
        /// <param name="sachTim">Đối tượng chứa thông tin tìm kiếm</param>
        /// <param name="dgv">grid view hiển thị</param>
        /// <returns>tìm thấy nếu khác null</returns>
        public HoaDonDTO TimKiem2(HoaDonDTO HoaDonTim, DataGridView dgv)
        {

            HoaDonDTO ketQua = null;
            dgv.Rows.Clear();
            XmlNode HDCanTim = root.SelectSingleNode("_x0027_tb_HoaDon_x0027_[mahd='" + HoaDonTim.MaHD + "']");

            if (HDCanTim != null)
            {

                dgv.ColumnCount = 5;//khai báo số cột
                dgv.Rows.Add();//thêm một dòng mới

                //đưa dữ liệu vào dòng vừa tạo
                dgv.Rows[0].Cells[0].Value = HDCanTim.SelectSingleNode("mahd").InnerText;
                dgv.Rows[0].Cells[1].Value = HDCanTim.SelectSingleNode("makh").InnerText;                
                dgv.Rows[0].Cells[2].Value = HDCanTim.SelectSingleNode("loaidien").InnerText;
                dgv.Rows[0].Cells[3].Value = HDCanTim.SelectSingleNode("luongdientt").InnerText;
                dgv.Rows[0].Cells[4].Value = HDCanTim.SelectSingleNode("thanhtien").InnerText;

                ketQua = new HoaDonDTO();

                ketQua.MaHD = HDCanTim.SelectSingleNode("mahd").InnerText;
                ketQua.MaKH = HDCanTim.SelectSingleNode("makh").InnerText;
                ketQua.LoaiDien = HDCanTim.SelectSingleNode("loaidien").InnerText;
                ketQua.LuongDienTT = int.Parse(HDCanTim.SelectSingleNode("luongdientt").InnerText);
                ketQua.ThanhTien =double.Parse(HDCanTim.SelectSingleNode("thanhtien").InnerText);

            }
            return ketQua;

        }

        public void HienThi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 5;

            XmlNodeList ds = root.SelectNodes("_x0027_tb_HoaDon_x0027_");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("mahd").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("makh").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("loaidien").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("luongdientt").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("thanhtien").InnerText;
                sd++;
            }
        }
    }
}
