using System;
using System.Collections.Generic;

namespace QLCT.DAL.Models
{
    public partial class ChiTieu
    {
        public int MaChi { get; set; }
        public int? SoTien { get; set; }
        public DateTime? NgayChi { get; set; }
        public int? MaNd { get; set; }

        public virtual NoiDung MaNdNavigation { get; set; }
    }
}
