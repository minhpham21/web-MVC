using System;
using System.Collections.Generic;

namespace QLCT.DAL.Models
{
    public partial class ThongKeThuNhap
    {
        public int MaTk { get; set; }
        public int MaThu { get; set; }

        public virtual ThuNhap MaThuNavigation { get; set; }
        public virtual ThongTinTk MaTkNavigation { get; set; }
    }
}
