using System;
using System.Collections.Generic;

namespace QLCT.DAL.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            ThongTinTk = new HashSet<ThongTinTk>();
        }

        public int Id { get; set; }
        public string TenTk { get; set; }
        public string MatKhauTk { get; set; }

        public virtual ICollection<ThongTinTk> ThongTinTk { get; set; }
    }
}
