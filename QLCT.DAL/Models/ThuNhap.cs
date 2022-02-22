using System;
using System.Collections.Generic;

namespace QLCT.DAL.Models
{
    public partial class ThuNhap
    {
        public int MaThu { get; set; }
        public int? SoTien { get; set; }
        public DateTime? NgayThu { get; set; }
        public int? MaNd { get; set; }

        public virtual NoiDung MaNdNavigation { get; set; }
    }
}
