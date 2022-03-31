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
    class ChisodienBLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string fileName = @"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\tb_ChiSoDien.xml";

        public ChisodienBLL()
        {
            
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(ChiSoDienDTO csdThem)
        {
            
            XmlNode csd = doc.CreateElement("_x0027_tb_ChiSoDien_x0027_");

         
            XmlElement makh = doc.CreateElement("makh");
            makh.InnerText = csdThem.MaKh;
            csd.AppendChild(makh);

            XmlElement mathang = doc.CreateElement("mathang");
            mathang.InnerText = csdThem.MaThang;
            csd.AppendChild(mathang);

            XmlElement chisocu = doc.CreateElement("chisocu");
            chisocu.InnerText = csdThem.ChiSoCu.ToString();
            csd.AppendChild(chisocu);

            XmlElement chisomoi = doc.CreateElement("chisomoi");
            chisomoi.InnerText = csdThem.ChiSoMoi.ToString();
            csd.AppendChild(chisomoi);

            root.AppendChild(csd);
            doc.Save(fileName);
        }

        public void Sua(ChiSoDienDTO csdSua)
        {
           
            XmlNode csdCu = root.SelectSingleNode("_x0027_tb_ChiSoDien_x0027_[makh ='" + csdSua.MaKh + "']");
            if (csdCu != null)
            {
                XmlNode csdSuaMoi = doc.CreateElement("_x0027_tb_ChiSoDien_x0027_");

                
                XmlElement makh = doc.CreateElement("makh");
                makh.InnerText = csdSua.MaKh;
               csdSuaMoi.AppendChild(makh);

                XmlElement mathang = doc.CreateElement("mathang");
                mathang.InnerText = csdSua.MaThang;
                csdSuaMoi.AppendChild(mathang);

                XmlElement chisocu = doc.CreateElement("chisocu");
                chisocu.InnerText = csdSua.ChiSoCu.ToString();
                csdSuaMoi.AppendChild(chisocu);

                XmlElement chisomoi = doc.CreateElement("chisomoi");
                chisomoi.InnerText = csdSua.ChiSoMoi.ToString();
                csdSuaMoi.AppendChild(chisomoi);

                
                root.ReplaceChild(csdSuaMoi, csdCu);
                doc.Save(fileName);
            }
        }

        public void Xoa(ChiSoDienDTO csdXoa)
        {
            XmlNode csdCanXoa = root.SelectSingleNode("_x0027_tb_ChiSoDien_x0027_[makh ='" + csdXoa.MaKh + "']"); 
            if (csdCanXoa != null)
            {
                root.RemoveChild(csdCanXoa);

                doc.Save(fileName);
            }
        }   

        /// <summary>
        /// Tìm và trả về đối tượng sách tìm thấy, không thấy = null
        /// </summary>
        /// <param name="sachTim">Đối tượng chứa thông tin tìm kiếm</param>
        /// <param name="dgv">grid view hiển thị</param>
        /// <returns>tìm thấy nếu khác null</returns>
        public ChiSoDienDTO TimKiem2(ChiSoDienDTO csdTim, DataGridView dgv)
        {
            ChiSoDienDTO ketQua = null;
            dgv.Rows.Clear();
            XmlNode csdCanTim = root.SelectSingleNode("_x0027_tb_ChiSoDien_x0027_[makh ='" + csdTim.MaKh + "']"); ;
            if (csdCanTim != null)
            {
                dgv.ColumnCount = 4;//khai báo số cột
                dgv.Rows.Add();//thêm một dòng mới

                //đưa dữ liệu vào dòng vừa tạo
                dgv.Rows[0].Cells[0].Value = csdTim.MaKh = csdCanTim.SelectSingleNode("makh").InnerText;
                dgv.Rows[0].Cells[1].Value = csdCanTim.SelectSingleNode("mathang").InnerText;
                dgv.Rows[0].Cells[2].Value = csdCanTim.SelectSingleNode("chisocu").InnerText;
                dgv.Rows[0].Cells[3].Value = csdCanTim.SelectSingleNode("chisomoi").InnerText;

                ketQua = new ChiSoDienDTO();

                ketQua.MaKh = csdCanTim.SelectSingleNode("makh").InnerText;
                ketQua.MaThang= csdCanTim.SelectSingleNode("mathang").InnerText;
                ketQua.ChiSoCu = int.Parse(csdCanTim.SelectSingleNode("chisocu").InnerText);
                ketQua.ChiSoMoi = int.Parse(csdCanTim.SelectSingleNode("chisomoi").InnerText);
            }

            return ketQua;
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;

            XmlNodeList ds = root.SelectNodes("_x0027_tb_ChiSoDien_x0027_");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("makh").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("mathang").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("chisocu").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("chisomoi").InnerText;
                sd++;
            }
        }
    }
}

