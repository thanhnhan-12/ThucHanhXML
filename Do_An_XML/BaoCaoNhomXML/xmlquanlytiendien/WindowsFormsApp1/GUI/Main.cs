using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.GUI
{
    public partial class Main : Form
    {
        xmlfile Fxml = new xmlfile();

        public Main()
        {
            InitializeComponent();
        }

        private void QuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        public void TaoXML()
        {
          
            Fxml.TaoXML("tb_HoTieuThu");

            Fxml.TaoXML("tb_HoaDon");
            Fxml.TaoXML("tb_ChiSoDien");
        }
        void CapNhapTungBang(string tenBang)
        {
            string duongDan = @"D:\XML\Do_An_XML\BaoCaoNhomXML\xmlquanlytiendien\WindowsFormsApp1\" + tenBang + ".xml";
            DataTable table = Fxml.Hienthi1(duongDan);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sql = "insert into " + tenBang + " values(";
                for (int j = 0; j < table.Columns.Count - 1; j++)
                {
                    sql += "N'" + table.Rows[i][j].ToString().Trim() + "',";
                }
                sql += "'" + table.Rows[i][table.Columns.Count - 1].ToString().Trim() + "'";
                sql += ")";
                //MessageBox.Show(sql);
                Fxml.InsertOrUpDateSQL(sql);
            }
        }
        public void CapNhapSQL()
        {
            //Xóa toàn bộ dữ liệu các bảng
            Fxml.InsertOrUpDateSQL("delete from tb_HoaDon");
            Fxml.InsertOrUpDateSQL("delete from tb_ChiSoDien");
            Fxml.InsertOrUpDateSQL("delete from tb_HoTieuThu");
            //Fxml.InsertOrUpDateSQL("delete from tb_HoaDon");
            
            //Cập nhập toàn bộ dữ liệu các bảng

            //CapNhapTungBang("tb_ChiSoDien");
            CapNhapTungBang("tb_HoTieuThu");
            CapNhapTungBang("tb_ChiSoDien");
            CapNhapTungBang("tb_HoaDon");
         
        }
        private void HóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            HoaDon frm = new HoaDon();
            frm.ShowDialog();
            Show();
        }

        private void KháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            QLKH frm = new QLKH();
            frm.ShowDialog();
            Show();
        }

        private void ChỉSốĐiệnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ChiSoDien frm = new ChiSoDien();
            frm.ShowDialog();
            Show();
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sqlSangXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TaoXML();
                MessageBox.Show("Tạo XML thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void xmlSangSqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhapSQL();
                MessageBox.Show("Cập nhập SQL server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
