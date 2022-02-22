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
    public class ThongTInTKSvc : GenericSvc<ThongTinTKReq, ThongTinTk>
    {

        #region -- Overrides --
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }

        public override SingleRsp Update(ThongTinTk m)
        {
            var res = new SingleRsp();

            var m1 = m.MaId > 0 ? _rep.Read(m.MaId) : _rep.Read(m.MaId);
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
        public object getTaiKhoanID(int id)
        {
            var tk = All.FirstOrDefault(x => x.MaId == id);

            var thongTinTK = new
            {
                tk.HoTen,
                tk.NgaySinh,
                tk.GioiTinh,
                tk.QueQuan
            };

            return thongTinTK;
        }
        #endregion


    }
}
