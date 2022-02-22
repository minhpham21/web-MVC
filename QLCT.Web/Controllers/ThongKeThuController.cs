using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace QLCT.Web.Controllers
{
    using System.Collections.Generic;
    using BLL;
    using DAL.Models;
    using Common.Req;
    using QLCT.Common.Rsp;

    [Route("api/[controller]")]
    [ApiController]
    public class ThongKeThuController : ControllerBase
    {
        public ThongKeThuController()
        {
            _svc = new ThongKeThuScv();
        }

        [HttpPost("getTongThuTK-by-id")]
        public IActionResult getThongTinTKId([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            var tk = _svc.getThuTK(req.Id);
            res.Data = tk;
            //res = _svc.Read(req.Id);
            return Ok(res);
        }

        [HttpPost("getTongThuTK-all")]
        public IActionResult getAllThongTinTK()
        {
            var res = new SingleRsp();
            res.Data = _svc.All;
            return Ok(res);
        }
        private readonly ThongKeThuScv _svc;
    }
}
