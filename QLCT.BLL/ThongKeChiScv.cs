using System;
using System.Collections.Generic;
using System.Text;
using QLCT.BLL;
using QLCT.Common.Rsp;
using QLCT.Common.BLL;
using System.Linq;

namespace QLCT.BLL
{
    using DAL;
    using DAL.Models;

    public class ThongKeChiScv : GenericSvc<ThongKeChiReq, ViewTongChi>
    {
        #region -- Overrides --
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }

        public override SingleRsp Update(ViewTongChi m)
        {
            var res = new SingleRsp();

            var m1 = m.MaTk > 0 ? _rep.Read(m.MaTk) : _rep.Read(m.MaTk);
            if (m1 == null)
            {
                res.SetError("EZ103", "No data.");

            }
            else
            {
                res = base.Update(m);
                res.Data = m;
            }

            return res;
        }
        #endregion

        #region -- Methods --
        public object getChiTK(int id)
        {
            var tk = All.FirstOrDefault(x => x.MaTk == id);

            var thongThuTK = new
            {
                tk.HoTen,
                tk.NgayChi,
                tk.SoTien,
                tk.TenNd
            };

            return thongThuTK;
        }
        #endregion
    }
}
