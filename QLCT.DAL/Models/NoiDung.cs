using System;
using System.Collections.Generic;

namespace QLCT.DAL.Models
{
    public partial class NoiDung
    {
        public NoiDung()
        {
            ChiTieu = new HashSet<ChiTieu>();
            ThuNhap = new HashSet<ThuNhap>();
        }

        public int MaNd { get; set; }
        public string TenNd { get; set; }

        public virtual ICollection<ChiTieu> ChiTieu { get; set; }
        public virtual ICollection<ThuNhap> ThuNhap { get; set; }
    }
}
