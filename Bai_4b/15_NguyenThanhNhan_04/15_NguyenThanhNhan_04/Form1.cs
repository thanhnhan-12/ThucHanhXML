using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml; 
using System.Diagnostics; 
using System.IO;

namespace _15_NguyenThanhNhan_04
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        string sql = "";
        SqlDataAdapter da;
        string path = "student.xml";

        public Form1()
        {
            InitializeComponent();
            InitGrid(dgvXML);
            Connect();
        }

        private void Connect()
        {
            // Kết nối đến CSDL SQL Server
            string strCon = "Server=NGUYENTHANHNHAN\\SQLEXPRESS;Database=ute;Integrated Security = True; ";
            //con = new SqlConnection(strCon);
            
             //string server = Environment.MachineName + "NGUYENTHANHNHAN\\SQLEXPRESS";
          //   string user = "sa";
            // string pass = "nhan";
          //   string db = "ute";
            // Các khai báo trên tùy thuộc PC và sự cài đặt SQL Server
           //  string strCon = "Data Source=" + server + ";Initial Catalog=" +
          //   db + ";User ID=" + user + "; Password=" + pass +
          //  ";Persist Security Info=true;";
             con = new SqlConnection(strCon);
            
        }

        private void InitGrid(DataGridView dgv)
        {
            // Định dạng DataGridView
            if (dgv.Name == "dgvXML")
            {
                dgv.ColumnCount = 4;
                dgv.Columns[0].Name = "Code";
                dgv.Columns[1].Name = "Name";
                dgv.Columns[2].Name = "Class";
                dgv.Columns[3].Name = "Address";
            }
            dgv.Columns[0].Width = 70;
            dgv.Columns[1].Width = 170;
            dgv.Columns[2].Width = 75;
            dgv.Columns[3].Width = 170;
        }

        private void lklRDS2GRID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Mở kết nối, truy vấn, nạp dữ liệu vào datatable và grid
                con.Open();
                sql = "Select * from student";
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRDB.DataSource = dt; // nạp data vào grid
                InitGrid(dgvRDB);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lkl2XML_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sql = "Select * from student for xml auto";
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string xml = "<?xml version='1.0'?><ute>";
            xml += dt.Rows[0].ItemArray[0].ToString() + "</ute>";
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.LoadXml(xml); // nạp chuổi XML vào cây XML
            XmlDoc.Save(path);
            ViewXML(path);
        }

        void ViewXML(string path)
        {
            // Xem tệp XML, HTML trong trình duyệt
            var fullpath = Path.GetFullPath(path);
            //Process.Start("IExplore.exe",fullpath);
            //Process.Start("firefox.exe", fullpath);
            //Process.Start("Explorer.exe", fullpath);
            Process.Start("Chrome.exe", fullpath);
        }

        private void lklViewXML_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewXML(path);
        }

        public DataTable HienThi(string file)
        {
            DataTable dt = new DataTable();
            string FilePath = Application.StartupPath + "\\" + file;
            if (File.Exists(FilePath))
            {
                DataSet ds = new DataSet();

                FileStream fsReadXML = new System.IO.FileStream(FilePath, System.IO.FileMode.Open); ds.ReadXml(fsReadXML);
                DataView dv = new DataView(ds.Tables[0]);
                dt = dv.Table; fsReadXML.Close();
            }
            else
            {
                MessageBox.Show("File XML '" + file + "' không tồn tại");
            }
            return dt;
        }
        public void InsertOrUpDateSQL(string sql)
        {
            Connect(); con.Open(); SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery(); con.Close();
        }
        void CapNhapTungBang(string tenBang)
        {
            string duongDan = @"" + "student" + ".xml";
            DataTable table = HienThi(duongDan);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sql = "insert into " + tenBang + " values(";
                for (int j = 0; j < table.Columns.Count - 1; j++)
                {
                    sql += "N'" + table.Rows[i][j].ToString().Trim() + "',";
                }
                sql += "N'" + table.Rows[i][table.Columns.Count - 1].ToString().Trim() + "'";
                sql += ")";
                MessageBox.Show(sql);
                InsertOrUpDateSQL(sql);

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                try
                {// Xóa từng bảng dữliệu
                    InsertOrUpDateSQL("delete from student");

                    //Cập nhập toàn bộdữliệu các bảng
                    CapNhapTungBang("student");

                    MessageBox.Show("Cập nhập SQL server thành công");
                }
                catch (Exception ex) { MessageBox.Show("" + ex); }
            }
        }
    }
}
