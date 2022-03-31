using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNongSan
{
    class Restore
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KQDGKVB\\SQLEXPRESS;Initial Catalog=BanNongSan;Integrated Security=True");
        public void RestoreData() {
            RestoreData("select * from NhanVien_table","NhanVien");
            RestoreData("select * from KhachHang_table", "KhachHang");
            RestoreData("select * from DanhMucNongSan_table", "DanhMucNongSan");
            RestoreData("select * from ChiTietNongSan_table", "ChiTietNongSan");
            RestoreData("select * from HoaDonNhapXuat_table", "HoaDonNhapXuat");
            RestoreData("select * from ChiTietHoaDon_table", "ChiTietHoaDon");
        }
        public void RestoreData(String query,String XMLName)
        {
          
          
            try { 

            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(query, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, XMLName);
            ds.DataSetName = XMLName + "s";
            ds.WriteXml(XMLName+"s"+".xml");}
            catch(Exception e){
                Console.WriteLine(e.ToString());

            }
        }
    }
}
