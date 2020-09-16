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

        /// <summary>
        /// 根据Id查询财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpGet("GetWealthDetail/ById")]
        public ActionResult<WealthDetail> GetWealthDetailById(int id)
        {
            return _wealthDetailService.GetWealthDetailById(id);
        }

        /// <summary>
        /// 获取所有财富详情
        /// </summary>
        /// <returns></returns>
        [DontWrapResult]
        [HttpGet("GetWealthDetail")]
        public ActionResult<List<WealthDetail>> GetWealthDetail()
        {
            return _wealthDetailService.GetWealthDetail();
        }

        /// <summary>
        /// 获取每月财富详情汇总
        /// </summary>
        /// <returns></returns>
        [DontWrapResult]
        [HttpGet("GetMonthAmountSummary")]
        public ActionResult<List<MonthAmountSummary>> GetMonthAmountSummary()
        {
            return _wealthDetailService.GetMonthAmountSummary();
        }

        /// <summary>
        /// 更新财富详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpPut("UpdateWealthDetail/ById")]
        public ActionResult<bool> UpdateWealthDetailById(WealthDetail input)
        {
            return _wealthDetailService.UpdateWealthDetailById(input);
        }

        /// <summary>
        /// 删除财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpDelete("DeleteWealthDetail/ById")]
        public ActionResult<bool> DeleteWealthDetailById(int id)
        {
            return _wealthDetailService.DeleteWealthDetailById(id);
        }

        /// <summary>
        /// 新增详情
        /// </summary>
        /// <param name="input">财富实体</param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpPost("AddWealthDetail")]
        public ActionResult<bool> AddWealthDetail([FromBody] WealthDetail input)
        {
            return _wealthDetailService.AddWealthDetail(input);
        }
    }
}