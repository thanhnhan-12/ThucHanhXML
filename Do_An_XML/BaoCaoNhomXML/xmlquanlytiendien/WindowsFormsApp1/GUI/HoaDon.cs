using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI
{
    public partial class HoaDon : Form
    {
        QLKH ql = new QLKH();
        public HoaDon()
        {
            InitializeComponent();
        }
        private HoaDonBLL HoaDonBLL = new HoaDonBLL();
        private HoaDonDTO HoaDonDTO = new HoaDonDTO();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.ForeColor = Color.Black;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            HoaDonBLL.HienThi(dgvHoaDon);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                HoaDonDTO.MaHD = txtMaHD.Text.ToLower();
                HoaDonDTO.MaKH = txtMaKH.Text;
                HoaDonDTO.LoaiDien = cbLoaidien.Text;
                HoaDonDTO.LuongDienTT = int.Parse(txtLuongdien.Text);
                HoaDonDTO.ThanhTien = int.Parse(txtThanhtien.Text);

                //gọi BLL thực hiện
                HoaDonBLL.Them(HoaDonDTO);
                //hiện lên dgv
                HoaDonBLL.HienThi(dgvHoaDon);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                HoaDonDTO.MaHD = txtMaHD.Text.ToLower();
                HoaDonDTO.MaKH = txtMaKH.Text;
                HoaDonDTO.LoaiDien = cbLoaidien.Text;
                HoaDonDTO.LuongDienTT = int.Parse(txtLuongdien.Text);
                HoaDonDTO.ThanhTien = int.Parse(txtThanhtien.Text);

                //gọi BLL thực hiện
                HoaDonBLL.Sua(HoaDonDTO);
                //hiện lên dgv
                HoaDonBLL.HienThi(dgvHoaDon);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                HoaDonDTO.MaHD = txtMaHD.Text.ToLower();

                //gọi BLL thực hiện
                HoaDonBLL.Xoa(HoaDonDTO);
                //hiện lên dgv
                HoaDonBLL.HienThi(dgvHoaDon);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                HoaDonDTO.MaHD = txtMaHD.Text.ToLower();
                //gọi BLL thực hiện
                var hdTim = HoaDonBLL.TimKiem2(HoaDonDTO, dgvHoaDon);
                //khác null là tìm thấy, thực hiện bind lên ui
                if (hdTim != null)
                {
                    txtMaHD.Text = hdTim.MaHD;
                    txtMaHD.Text = hdTim.MaKH;
                    cbLoaidien.Text = hdTim.LoaiDien;
                    txtLuongdien.Text = hdTim.LuongDienTT.ToString();
                    txtThanhtien.Text = hdTim.ThanhTien.ToString();
                }
                else
                {
                    //không thấy thì xóa trăng
                    txtMaKH.Text =txtMaHD.Text =txtLuongdien.Text = txtThanhtien.Text = cbLoaidien.Text = string.Empty;
                }
            }
        }

      

        private void dgvHoaDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1) return;

            int numrow;
            numrow = e.RowIndex;
            txtMaHD.Text = dgvHoaDon.Rows[numrow].Cells[0].Value.ToString();
            txtMaKH.Text = dgvHoaDon.Rows[numrow].Cells[1].Value.ToString();
            cbLoaidien.Text = dgvHoaDon.Rows[numrow].Cells[2].Value.ToString();
            txtLuongdien.Text = dgvHoaDon.Rows[numrow].Cells[3].Value.ToString();
            txtThanhtien.Text = dgvHoaDon.Rows[numrow].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            ql.TimKiemXSLT("tb_HoaDon", "tb_HoaDon", "tb_HoaDon");
            
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
