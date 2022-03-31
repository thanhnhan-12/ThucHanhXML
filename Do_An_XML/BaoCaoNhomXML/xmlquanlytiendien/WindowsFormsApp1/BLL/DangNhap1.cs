using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp1.BLL
{
    class DangNhap1
    {
        xmlfile Fxml = new xmlfile();
        public void layMaQuyen()
        {

            XmlTextReader reader = new XmlTextReader(@"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\xmltaikhoan.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            reader.Close();
            XmlNode nodeMQ = doc.SelectSingleNode("NewDataSet/TaiKhoan/Quyen");


        }
        public bool kiemtraDangNhap(string MaNhanVien, string MatKhau)
        {
            XmlTextReader reader = new XmlTextReader(@"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\xmltaikhoan.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/TaiKhoan[MaNhanVien='" + MaNhanVien + "']");
            node = doc.SelectSingleNode("NewDataSet/TaiKhoan[MatKhau='" + MatKhau + "']");
            reader.Close();
            bool kq = true;
            if (node != null)
            {
                return kq = true;
            }
            else
            {
                return kq = false;

            }


        }

        public bool kiemtraTTTK(string MaNhanVien)
        {
            XmlTextReader reader = new XmlTextReader(@"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\xmltaikhoan.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);
            XmlNode node = doc.SelectSingleNode("NewDataSet/TaiKhoan[MaNhanVien='" + MaNhanVien + "']");
            reader.Close();
            bool kq = true;
            if (node != null)
            {
                return kq = true;
            }
            else
            {
                return kq = false;

            }
        }

        public bool kiemtraTTDN(string duongdan, string MaNhanVien, string MatKhau)
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi(duongdan);
            dt.DefaultView.RowFilter = "MaNhanVien ='" + MaNhanVien + "' AND MatKhau='" + MatKhau + "'";
            if (dt.DefaultView.Count > 0)
                return true;
            return false;

        }
    }
}
