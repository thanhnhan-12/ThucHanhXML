using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class ChiSoDienDTO
    {
        private string _MaKh;
        private string _MaThang;
        private int _ChiSoCu;
        private int _ChiSoMoi;

        public string MaKh { get => _MaKh; set => _MaKh = value; }
        public string MaThang { get => _MaThang; set => _MaThang = value; }
        public int ChiSoCu { get => _ChiSoCu; set => _ChiSoCu = value; }
        public int ChiSoMoi { get => _ChiSoMoi; set => _ChiSoMoi = value; }
    }
}

