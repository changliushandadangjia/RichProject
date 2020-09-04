using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using RichProjectAdmin.Domain.Interface;
using RichProjectAdmin.Domain.Model;

namespace RichProjectAdmin.Web.Controllers
{
    public class WealthDetailController : AbpController
    {
        private readonly IWealthDetailService _wealthDetailService;

        public WealthDetailController(IWealthDetailService wealthDetailService)
        {
            _wealthDetailService = wealthDetailService;
        }

        public async Task<IActionResult> Index()
        {
            //var detail = await _wealthDetailService.GetWealthDetail();
            return View();
        }

        public async Task<LayuiBackModel<List<WealthDetail>>> GetWealthDetail()
        {
            var detail = await _wealthDetailService.GetWealthDetail();
            return new LayuiBackModel<List<WealthDetail>>(){Code = 0,Count = detail.Count,Data=detail};
        }
    }
}