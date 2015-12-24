using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CanBo
    {
        public string MaCanBo { get; set; }
        public string TenCanBo { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MaBoMon { get; set; }
        public string LoaiTaiKhoan { get; set; }


        public CanBo()
        {

        }

        public CanBo(string _ma,string _ten,DateTime _ns,string _email,string _sdt,string _dc,string _mbm,string _tk)
        {
            MaCanBo = _ma;
            TenCanBo = _ten;
            NgaySinh = _ns;
            Email = _email;
            SDT = _sdt;
            DiaChi = _dc;
            MaBoMon = _mbm;
            LoaiTaiKhoan = _tk;
        }
    }
}
