using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Subject
    {
        public string MaBoMon { get; set; }
        public string TenBoMon { get; set; }
        public string MaTruongBoMon { get; set; }
        public string MaKhoa { get; set; }

        public Subject()
        {

        }

        public Subject(string _mabm,string _TenBoMon,string _MaTruongBoMon,string _MaKhoa)
        {
            MaBoMon = _mabm;
            TenBoMon = _TenBoMon;
            MaTruongBoMon = _MaTruongBoMon;
            MaKhoa = _MaKhoa;
        }
    }
}
