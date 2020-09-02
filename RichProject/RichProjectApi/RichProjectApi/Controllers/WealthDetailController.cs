using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RichProjectDomain.Interface;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectApi.Controllers
{
    public class WealthDetailController : AbpController
    {
        private readonly IWealthDetailService _wealthDetailService;
        public WealthDetailController(IWealthDetailService wealthDetailService)
        {
            _wealthDetailService = wealthDetailService;
        }
        [DontWrapResult]
        [HttpGet("GetWealthDetail")]
        public ActionResult<WealthDetail> GetWealthDetail(int id)
        {
            return _wealthDetailService.GetWealthDetail(id);
        }
    }
}