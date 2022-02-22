using System;
using System.Collections.Generic;
using System.Text;
using QLCT.Common.DAL;
using System.Linq;

namespace QLCT.DAL
{
    using Models;
    public class ThongKeThuReq : GenericRep<QuanLyChiTieuContext, ViewTongThu>
    {
        #region -- Overrides --
        public override ViewTongThu Read(int id)
        {
            var res = All.FirstOrDefault(p => p.MaTk == id);
            return res;
        }

        public int Remove(int id)
        {
            var m = base.All.First(i => i.MaTk == id);
            m = base.Delete(m); //TODO
            return m.MaTk;
        }

        #endregion
    }
}
