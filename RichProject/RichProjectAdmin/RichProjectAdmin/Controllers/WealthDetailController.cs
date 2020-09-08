using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Web.Models;
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
            return View();
        }

        public async Task<IActionResult> DetailPage()
        {
            return View();
        }

        [DontWrapResult]
        public async Task<LayuiBackModel<List<WealthDetail>>> GetWealthDetail()
        {
            var detail = await _wealthDetailService.GetWealthDetail();
            return new LayuiBackModel<List<WealthDetail>>(){Code = 0,Count = detail.Count,Data=detail};
        }

        [DontWrapResult]
        public async Task<JsonResult> GetWealthDetailSimplify()
        {
            var detail= await _wealthDetailService.GetWealthDetail();
            var result=detail.Where(p => !p.IsDeleted).Select(p => new {Name = p.WealthArea, Value = p.Amount}).ToList();
            return Json(new { result = result});
        }

        [DontWrapResult]
        public async Task<JsonResult> GetWealthMonthSummary()
        {
            var amountSummary = await _wealthDetailService.GetMonthAmountSummary();
            return Json(new{result = amountSummary});
        }
    }
}