using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.BLL
{
    class xmlfile
    {
        //string Conn = " Data Source = NGUYENTHANHNHAN\\SQLEXPRESS; Initial Catalog = ElectricityManagement; Integrated Security=true";
        string Conn = "Data Source = NGUYENTHANHNHAN\\SQLEXPRESS;Initial Catalog = ElectricityManagement; Integrated Security = True";
        
        public void TaoXML(string bang)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            string sql = "Select* from " + bang;
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable("'" + bang + "'");
            ad.Fill(dt);
            dt.WriteXml(@"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\" + bang + ".xml", XmlWriteMode.WriteSchema);
        }
        public void InsertOrUpDateSQL(string sql)
        {
            SqlConnection con = new SqlConnection(Conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Hienthi1(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = file;
            if (File.Exists(FilePath))
            {
                FileStream fsReadXML = new FileStream(FilePath, FileMode.Open);
                dt.ReadXml(fsReadXML);
                fsReadXML.Close();
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
            }

            return dt;
        }
    
    public DataTable HienThi(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = @"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\" + file;
            if (File.Exists(FilePath))
            {
                FileStream fsReadXML = new FileStream(FilePath, FileMode.Open);
                dt.ReadXml(fsReadXML);
                fsReadXML.Close();
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
            }

            return dt;
        }
    }
}
