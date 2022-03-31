using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI
{
    public partial class ChiSoDien : Form
    {
        SqlConnection con;
        string sql = "";
        SqlDataAdapter da;
        string path = "xmlchisodien.xml";

        public ChiSoDien()
        {
            InitializeComponent();
            

        }
        private ChisodienBLL chisodienBLL = new ChisodienBLL();
        private ChiSoDienDTO chisodienDTO = new ChiSoDienDTO();

        private void dataGridchisso_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int numrow;
            numrow = e.RowIndex;
            txtMaKH.Text = dgvChiSoDien.Rows[numrow].Cells[0].Value.ToString();
            txtMathang.Text = dgvChiSoDien.Rows[numrow].Cells[1].Value.ToString();
            txtChisocu.Text = dgvChiSoDien.Rows[numrow].Cells[2].Value.ToString();
            txtChisomoi.Text = dgvChiSoDien.Rows[numrow].Cells[3].Value.ToString();
        }
        private void ChiSoDien_Load(object sender, EventArgs e)
        {
        
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
              chisodienBLL.HienThi(dgvChiSoDien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                chisodienDTO.MaKh = txtMaKH.Text.ToLower();
                chisodienDTO.MaThang = txtMathang.Text;
                chisodienDTO.ChiSoCu = int.Parse(txtChisocu.Text);
                chisodienDTO.ChiSoMoi = int.Parse(txtChisomoi.Text);
                //gọi BLL thực hiện
                chisodienBLL.Them(chisodienDTO);
                //hiện lên dgv
                chisodienBLL.HienThi(dgvChiSoDien);
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                chisodienDTO.MaKh = txtMaKH.Text.ToLower();
                chisodienDTO.MaThang = txtMathang.Text;
                chisodienDTO.ChiSoCu = int.Parse(txtChisocu.Text);
                chisodienDTO.ChiSoMoi = int.Parse(txtChisomoi.Text);
                //gọi BLL thực hiện
                chisodienBLL.Sua(chisodienDTO);
                //hiện lên dgv
                chisodienBLL.HienThi(dgvChiSoDien);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                chisodienDTO.MaKh = txtMaKH.Text.ToLower();

                //gọi BLL thực hiện
                chisodienBLL.Xoa(chisodienDTO);
                //hiện lên dgv
                chisodienBLL.HienThi(dgvChiSoDien);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                chisodienDTO.MaKh = txtMaKH.Text.ToLower();
                //gọi BLL thực hiện
                var csdTim = chisodienBLL.TimKiem2(chisodienDTO, dgvChiSoDien);
                //khác null là tìm thấy, thực hiện bind lên ui
                if (csdTim != null)
                {
                    txtMaKH.Text = csdTim.MaKh;
                    txtMathang.Text = csdTim.MaThang;
                    txtChisocu.Text = csdTim.ChiSoCu.ToString();
                    txtChisomoi.Text = csdTim.ChiSoMoi.ToString();
                }
                else
                {
                    //không thấy thì xóa trăng
                    txtMaKH.Text = txtMathang.Text = txtChisocu.Text = txtChisomoi.Text = string.Empty;
                }
            }
        }

        private void dgvChiSoDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        //private void Connect()
        //{
        //    // Kết nối đến CSDL SQL Server
        //    // string strCon = "Server=DESKTOP-AN2NVCS\\EXPRESSQUAN;Database=ute;Integrated Security = True; ";
        //    //con = new SqlConnection(strCon);

        //    string server = Environment.MachineName + "\\SQLExpress";
        //    string user = "sa";
        //    string pass = "nhan";
        //    string db = "ElectricityManagement";
        //    // Các khai báo trên tùy thuộc PC và sự cài đặt SQL Server
        //    string strCon = "Data Source=" + server + ";Initial Catalog=" +
        //    db + ";User ID=" + user + "; Password=" + pass +
        //   ";Persist Security Info=true;";
        //    con = new SqlConnection(strCon);

        //}

        private void ConvertSQL_Click(object sender, EventArgs e)
        {
            sql = "Select * from tb_ChiSoDien for xml auto";
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string xml = "<?xml version='1.0'?><ds>";
            xml += dt.Rows[0].ItemArray[0].ToString() + "</ds>";
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

    }
}
