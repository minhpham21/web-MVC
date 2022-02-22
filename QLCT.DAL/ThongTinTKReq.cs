using System;
using System.Collections.Generic;
using System.Text;
using QLCT.Common.DAL;
using System.Linq;

namespace QLCT.DAL
{
    using Models;
    public class ThongTinTKReq : GenericRep<QuanLyChiTieuContext, ThongTinTk>
    {
        #region -- Overrides --
        public override ThongTinTk Read(int id)
        {
            var res = All.FirstOrDefault(p => p.MaId == id);
            return res;
        }

        public int Remove(int id)
        {
            var m = base.All.First(i => i.MaId == id);
            m = base.Delete(m); //TODO
            return m.MaId;
        }

        #endregion
    }
}