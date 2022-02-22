using System;
using System.Collections.Generic;

namespace QLCT.DAL.Models
{
    public partial class ThongKeChiTieu
    {
        public int MaTk { get; set; }
        public int MaChi { get; set; }

        public virtual ChiTieu MaChiNavigation { get; set; }
        public virtual ThongTinTk MaTkNavigation { get; set; }
    }
}
