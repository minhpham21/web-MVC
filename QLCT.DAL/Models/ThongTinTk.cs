using System;
using System.Collections.Generic;

namespace QLCT.DAL.Models
{
    public partial class ThongTinTk
    {
        public int MaTk { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public int MaId { get; set; }

        public virtual TaiKhoan Ma { get; set; }
    }
}
