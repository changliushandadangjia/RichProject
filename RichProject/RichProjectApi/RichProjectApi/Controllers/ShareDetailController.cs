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
using RichProjectDomain.Model.InputModel;

namespace RichProjectApi.Controllers
{
    public class ShareDetailController : AbpController
    {
        private readonly IShareDetailService _shareDetailService;

        public ShareDetailController(IShareDetailService shareDetailService)
        {
            _shareDetailService = shareDetailService;
        }

        /// <summary>
        /// 获取股票交易详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpPost("GetShareDealDetail")]
        public List<ShareDealDetail> GetShareDealDetail([FromBody] ShareDetailQueryInputDto input)
        {
            return _shareDetailService.GetShareDealDetail(input);
        }

        /// <summary>
        /// 新增股票交易详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpPost("AddShareDealDetail")]
        public bool AddShareDealDetail([FromBody] ShareDealDetail detail)
        {
            return _shareDetailService.AddShareDealDetail(detail);
        }

        /// <summary>
        /// 更新股票交易详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        [DontWrapResult]
        [HttpPut("UpdateShareDealDetail")]
        public bool UpdateShareDealDetail([FromBody] ShareDealDetail detail)
        {
            return _shareDetailService.UpdateShareDealDetail(detail);
        }
    }
}