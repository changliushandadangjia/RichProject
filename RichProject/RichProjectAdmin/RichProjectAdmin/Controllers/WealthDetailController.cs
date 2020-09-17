using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using RichProjectAdmin.Domain.Interface;
using RichProjectAdmin.Domain.Model;

namespace RichProjectAdmin.Web.Controllers
{
    public class WealthDetailController : AbpController
    {
        private readonly IWealthDetailService _wealthDetailService;
        private readonly ILargePayDetailService _largePayDetailService;

        public WealthDetailController(IWealthDetailService wealthDetailService, ILargePayDetailService largePayDetailService)
        {
            _wealthDetailService = wealthDetailService;
            _largePayDetailService = largePayDetailService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> DetailPage()
        {
            return View();
        }

        public async Task<IActionResult> LargePayPage()
        {
            return View();
        }

        [DontWrapResult]
        public async Task<LayuiBackModel<List<WealthDetail>>> GetWealthDetail()
        {
            var detail = await _wealthDetailService.GetWealthDetail();
            detail = detail.Where(p => !p.IsDeleted).Select(p => p).ToList();
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

        #region WealthDetail

        [DontWrapResult]
        public async Task<LayuiBackModel<List<WealthDetail>>> GetWealthDetailFetch(int page, int limit)
        {
            var detail = await _wealthDetailService.GetWealthDetail();
            detail = detail.Where(p => !p.IsDeleted).Select(p => p).ToList();
            var count = detail.Count;
            detail = detail.Skip((page - 1) * limit).Take(limit).ToList();
            return new LayuiBackModel<List<WealthDetail>>() { Code = 0, Count = count, Data = detail };
        }

        [DontWrapResult]
        public async Task<JsonResult> AddWealthDetail(WealthDetail detail)
        {
            var result = await _wealthDetailService.AddWealthDetail(detail);
            return Json(new {result = result});
        }

        [DontWrapResult]
        public async Task<JsonResult> UpdateWealthDetailById(WealthDetail detail)
        {
            var result = await _wealthDetailService.UpdateWealthDetail(detail);
            return Json(new { result = result });
        }

        [DontWrapResult]
        public async Task<JsonResult> DeleteWealthDetailById(int id)
        {
            var result = await _wealthDetailService.DeleteWealthDetail(id);
            return Json(new { result = result });
        }

        #endregion

        #region LargePayDetail 

        [DontWrapResult]
        public async Task<LayuiBackModel<List<LargePayDetail>>> GetLargePayDetail(int page, int limit)
        {
            var detail = await _largePayDetailService.GetLargePayDetail();
            detail = detail.Where(p => !p.IsDeleted).Select(p => p).ToList();
            var count = detail.Count;
            detail = detail.Skip((page - 1) * limit).Take(limit).ToList();
            return new LayuiBackModel<List<LargePayDetail>>() { Code = 0, Count = count, Data = detail };
        }


        [DontWrapResult]
        public async Task<JsonResult> AddLargePayDetail(LargePayDetail detail)
        {
            var result = await _largePayDetailService.AddLargePayDetail(detail);
            return Json(new { result = result });
        }

        [DontWrapResult]
        public async Task<JsonResult> UpdateLargePayDetailById(LargePayDetail detail)
        {
            var result = await _largePayDetailService.UpdateLargePayDetail(detail);
            return Json(new { result = result });
        }

        [DontWrapResult]
        public async Task<JsonResult> DeleteLargePayDetailById(int id)
        {
            var result = await _largePayDetailService.DeleteLargePayDetail(id);
            return Json(new { result = result });
        }

        #endregion
    }
}