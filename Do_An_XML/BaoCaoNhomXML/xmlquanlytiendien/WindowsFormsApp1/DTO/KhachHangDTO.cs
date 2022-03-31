using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class KhachHangDTO
    {
        private string _MaKH;
        private string _HoTen;
        private string _CMT;
        private string _DiaChi;
        private string _GioiTinh;
        private string _NgaySinh;
        private string _SoDT;
        private string _NgayDK;


        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string CMT { get => _CMT; set => _CMT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SoDT { get => _SoDT; set => _SoDT = value; }
        public string NgayDK { get => _NgayDK; set => _NgayDK = value; }
      
    }
}
