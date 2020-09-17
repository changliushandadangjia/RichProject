using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using RichProjectDomain.Interface;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectApi.Controllers
{
    public class LargePayDetailController : AbpController
    {
        private readonly ILargePayDetailService _largePayDetailService;
        public LargePayDetailController(ILargePayDetailService largePayDetailService)
        {
            _largePayDetailService = largePayDetailService;
        }
        /// <summary>
        /// 获取所有大型支出列表
        /// </summary>
        /// <returns></returns>
        [DontWrapResult]
        [HttpGet("GetLargePayDetail")]
        public ActionResult<List<LargePayDetail>> GetLargePayDetailById()
        {
            return _largePayDetailService.GetLargePayDetail();
        }

        /// <summary>
        /// 更新大型支出详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpPut("UpdateLargePayDetail/ById")]
        public ActionResult<bool> UpdateLargePayDetailById([FromBody]LargePayDetail input)
        {
            return _largePayDetailService.UpdateLargePayDetailById(input);
        }

        /// <summary>
        /// 删除大型支出详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpDelete("DeleteLargePayDetail/ById")]
        public ActionResult<bool> DeleteLargePayDetailById(int id)
        {
            return _largePayDetailService.DeleteLargePayDetailById(id);
        }

        /// <summary>
        /// 新增大型支出详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpPost("AddLargePayDetail")]
        public ActionResult<bool> AddLargePayDetail([FromBody] LargePayDetail input)
        {
            return _largePayDetailService.AddLargePayDetail(input);
        }
    }
}