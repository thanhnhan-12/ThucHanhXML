using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
        public class HoaDonDTO
    {
        private string _MaHD;
        private string _MaKH;
        private int _LuongDienTT;
        private string _LoaiDien;
        private double _ThanhTien;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public int LuongDienTT { get => _LuongDienTT; set => _LuongDienTT = value; }
        public string LoaiDien { get => _LoaiDien; set => _LoaiDien = value; }
        public double ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
    }
}
