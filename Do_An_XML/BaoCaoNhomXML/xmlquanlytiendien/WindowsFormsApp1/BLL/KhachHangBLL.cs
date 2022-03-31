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
    public class KhachHangBLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string fileName = @"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\tb_HoTieuThu.xml";

        public KhachHangBLL()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(KhachHangDTO khachhangThem)
        {
            //tạo nút kh
            XmlNode khachhang = doc.CreateElement("_x0027_tb_HoTieuThu_x0027_");

            //tạo nút con của khách hàng là makh
            XmlElement makh = doc.CreateElement("makh");
            makh.InnerText = khachhangThem.MaKH;//gán giá trị cho mã kh
            khachhang.AppendChild(makh);//thêm makh vào trong khách hàng(khachhang nhận makh là con)

            XmlElement hoten = doc.CreateElement("hoten");
            hoten.InnerText = khachhangThem.HoTen;
            khachhang.AppendChild(hoten);

            XmlElement cmt = doc.CreateElement("cmt");
            cmt.InnerText = khachhangThem.CMT.ToString();
            khachhang.AppendChild(cmt);

            XmlElement diachi = doc.CreateElement("diachi");
            diachi.InnerText = khachhangThem.DiaChi.ToString();
            khachhang.AppendChild(diachi);

            XmlElement gioitinh = doc.CreateElement("gioitinh");
            gioitinh.InnerText = khachhangThem.GioiTinh;
            khachhang.AppendChild(gioitinh);

            XmlElement ngaysinh = doc.CreateElement("ngaysinh");
            ngaysinh.InnerText = khachhangThem.NgaySinh;
            khachhang.AppendChild(ngaysinh);

            XmlElement sodt = doc.CreateElement("sodt");
            sodt.InnerText = khachhangThem.SoDT.ToString();
            khachhang.AppendChild(sodt);

            XmlElement ngaydk = doc.CreateElement("ngaydk");
            ngaydk.InnerText = khachhangThem.NgayDK.ToString();
            khachhang.AppendChild(ngaydk);
            //sau khi tạo xong khách hàng, thì thêm khách hàng vào gốc root
            root.AppendChild(khachhang);
            doc.Save(fileName);//lưu dữ liệu
        }

        public void Sua(KhachHangDTO khachhangSua)
        {
            //lấy vị trí cần sửa theo mã kh cũ đưa vào
            XmlNode khachhangCu = root.SelectSingleNode("_x0027_tb_HoTieuThu_x0027_[makh ='" + khachhangSua.MaKH + "']");
            if (khachhangCu != null)
            {
                XmlNode khSuaMoi = doc.CreateElement("_x0027_tb_HoTieuThu_x0027_");

                //tạo nút con của khách hàng là makh
                XmlElement makh = doc.CreateElement("makh");
                makh.InnerText = khachhangSua.MaKH;//gán giá trị cho mã kh
                khSuaMoi.AppendChild(makh);//thêm makh vào trong khách hàng(khachhang nhận makh là con)

                XmlElement hoten = doc.CreateElement("hoten");
                hoten.InnerText = khachhangSua.HoTen;
                khSuaMoi.AppendChild(hoten);

                XmlElement cmt = doc.CreateElement("cmt");
                cmt.InnerText = khachhangSua.CMT.ToString();
                khSuaMoi.AppendChild(cmt);

                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = khachhangSua.DiaChi.ToString();
                khSuaMoi.AppendChild(diachi);

                XmlElement gioitinh = doc.CreateElement("gioitinh");
                gioitinh.InnerText = khachhangSua.GioiTinh;
                khSuaMoi.AppendChild(gioitinh);

                XmlElement ngaysinh = doc.CreateElement("ngaysinh");
                ngaysinh.InnerText = khachhangSua.NgaySinh;
                khSuaMoi.AppendChild(ngaysinh);

                XmlElement sodt = doc.CreateElement("sodt");
                sodt.InnerText = khachhangSua.SoDT.ToString();
                khSuaMoi.AppendChild(sodt);

                XmlElement ngaydk = doc.CreateElement("ngaydk");
                ngaydk.InnerText = khachhangSua.NgayDK.ToString();
                khSuaMoi.AppendChild(ngaydk);

                //thay thế sách cũ bằng sách mới(sửa )
                root.ReplaceChild(khSuaMoi, khachhangCu);
                doc.Save(fileName);//lưu lại
            }
        }

        public void Xoa(KhachHangDTO khachhangXoa)
        {
            XmlNode khCanXoa = root.SelectSingleNode("_x0027_tb_HoTieuThu_x0027_[makh ='" + khachhangXoa.MaKH + "']");
            if (khCanXoa != null)
            {
                root.RemoveChild(khCanXoa);

                doc.Save(fileName);
            }
        }

        public void TimKiem(KhachHangDTO khachhangTim, DataGridView dgv)
        {
            dgv.Rows.Clear();
            XmlNode khCanTim = root.SelectSingleNode("_x0027_tb_HoTieuThu_x0027_[makh ='" + khachhangTim.MaKH + "']");

            if (khCanTim != null)
            {
                dgv.ColumnCount = 8;//khai báo số cột
                dgv.Rows.Add();//thêm một dòng mới

                //đưa dữ liệu vào dòng vừa tạo
                dgv.Rows[0].Cells[0].Value = khCanTim.SelectSingleNode("makh").InnerText;
                dgv.Rows[0].Cells[1].Value = khCanTim.SelectSingleNode("hoten").InnerText;
                dgv.Rows[0].Cells[2].Value = khCanTim.SelectSingleNode("cmt").InnerText;
                dgv.Rows[0].Cells[3].Value = khCanTim.SelectSingleNode("diachi").InnerText;
                dgv.Rows[0].Cells[4].Value = khCanTim.SelectSingleNode("gioitinh").InnerText;
                dgv.Rows[0].Cells[5].Value = khCanTim.SelectSingleNode("ngaysinh").InnerText;
                dgv.Rows[0].Cells[6].Value = khCanTim.SelectSingleNode("sodt").InnerText;
                dgv.Rows[0].Cells[7].Value = khCanTim.SelectSingleNode("ngaydk").InnerText;
            }
        }

        /// <summary>
        /// Tìm và trả về đối tượng sách tìm thấy, không thấy = null
        /// </summary>
        /// <param name="sachTim">Đối tượng chứa thông tin tìm kiếm</param>
        /// <param name="dgv">grid view hiển thị</param>
        /// <returns>tìm thấy nếu khác null</returns>
        public KhachHangDTO TimKiem2(KhachHangDTO khachhangTim, DataGridView dgv)
        {

            KhachHangDTO ketQua = null;
            dgv.Rows.Clear();
            XmlNode khCanTim = root.SelectSingleNode("_x0027_tb_HoTieuThu_x0027_[makh='" + khachhangTim.MaKH + "']");

            if (khCanTim != null)
            {

                dgv.ColumnCount = 8;//khai báo số cột
                dgv.Rows.Add();//thêm một dòng mới

                //đưa dữ liệu vào dòng vừa tạo
                dgv.Rows[0].Cells[0].Value = khCanTim.SelectSingleNode("makh").InnerText;
                dgv.Rows[0].Cells[1].Value = khCanTim.SelectSingleNode("hoten").InnerText;
                dgv.Rows[0].Cells[2].Value = khCanTim.SelectSingleNode("cmt").InnerText;
                dgv.Rows[0].Cells[3].Value = khCanTim.SelectSingleNode("diachi").InnerText;
                dgv.Rows[0].Cells[4].Value = khCanTim.SelectSingleNode("gioitinh").InnerText;
                dgv.Rows[0].Cells[5].Value = khCanTim.SelectSingleNode("ngaysinh").InnerText;
                dgv.Rows[0].Cells[6].Value = khCanTim.SelectSingleNode("sodt").InnerText;
                dgv.Rows[0].Cells[7].Value = khCanTim.SelectSingleNode("ngaydk").InnerText;


                ketQua = new KhachHangDTO();

                ketQua.MaKH = khCanTim.SelectSingleNode("makh").InnerText;
                ketQua.HoTen = khCanTim.SelectSingleNode("hoten").InnerText;
                ketQua.CMT = khCanTim.SelectSingleNode("cmt").InnerText;
                ketQua.DiaChi = khCanTim.SelectSingleNode("diachi").InnerText;
                ketQua.GioiTinh = khCanTim.SelectSingleNode("gioitinh").InnerText;
                ketQua.NgaySinh = khCanTim.SelectSingleNode("ngaysinh").InnerText;
                ketQua.SoDT = khCanTim.SelectSingleNode("sodt").InnerText;
                ketQua.NgayDK = khCanTim.SelectSingleNode("ngaydk").InnerText;
            }
            return ketQua;

        }

        public void HienThi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 8;

            XmlNodeList ds = root.SelectNodes("_x0027_tb_HoTieuThu_x0027_");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("makh").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("hoten").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("cmt").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("diachi").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("gioitinh").InnerText;
                dgv.Rows[sd].Cells[5].Value = item.SelectSingleNode("ngaysinh").InnerText;
                dgv.Rows[sd].Cells[6].Value = item.SelectSingleNode("sodt").InnerText;
                dgv.Rows[sd].Cells[7].Value = item.SelectSingleNode("ngaydk").InnerText;
                sd++;
            }
        }
    }
}
