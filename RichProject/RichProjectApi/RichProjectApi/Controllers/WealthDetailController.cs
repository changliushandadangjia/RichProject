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
        [HttpGet("GetWealthDetail/ById")]
        public ActionResult<WealthDetail> GetWealthDetailById(int id)
        {
            return _wealthDetailService.GetWealthDetailById(id);
        }

        [DontWrapResult]
        [HttpGet("GetWealthDetail")]
        public ActionResult<List<WealthDetail>> GetWealthDetail()
        {
            return _wealthDetailService.GetWealthDetail();
        }

        [DontWrapResult]
        [HttpGet("GetMonthAmountSummary")]
        public ActionResult<List<MonthAmountSummary>> GetMonthAmountSummary()
        {
            return _wealthDetailService.GetMonthAmountSummary();
        }
    }
}