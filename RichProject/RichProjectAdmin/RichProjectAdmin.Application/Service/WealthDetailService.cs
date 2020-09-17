using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Web;
using Newtonsoft.Json;
using RichProjectAdmin.Application.Service.Frame;
using RichProjectAdmin.Domain.Interface;
using RichProjectAdmin.Domain.Model;

namespace RichProjectAdmin.Application.Service
{
    public class WealthDetailService : IWealthDetailService, ITransientDependency
    {
        private readonly HttpClientCommonService _httpClientCommonService;
        public WealthDetailService( HttpClientCommonService httpClientCommonService)
        {
            _httpClientCommonService = httpClientCommonService;
        }

        /// <summary>
        /// 获取所有财富详情
        /// </summary>
        /// <returns></returns>
        public async Task<List<WealthDetail>> GetWealthDetail()
        {
            string url = "https://localhost:44399/GetWealthDetail";
            var str = await _httpClientCommonService.RemoteHelper(url, null,HttpVerb.Get);
            var result = JsonConvert.DeserializeObject<List<WealthDetail>>(str);
            return result;
        }

        /// <summary>
        /// 获取六个月每月财富总和
        /// </summary>
        /// <returns></returns>
        public async Task<List<DetailAmountSummary>> GetMonthAmountSummary()
        {
            string url = "https://localhost:44399/GetMonthAmountSummary";
            var str = await _httpClientCommonService.RemoteHelper(url, null,HttpVerb.Get);
            var result = JsonConvert.DeserializeObject<List<DetailAmountSummary>>(str);
            return result;
        }

        /// <summary>
        /// 删除财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteWealthDetail(int id)
        {
            string url = $"https://localhost:44399/DeleteWealthDetail/ById?id={id}";
            var str = await _httpClientCommonService.RemoteHelper(url, null,HttpVerb.Delete);
            var result = Convert.ToBoolean(str);
            return result;
        }

        /// <summary>
        /// 更新财富详情
        /// </summary>
        /// <returns></returns>
        public async Task<bool> UpdateWealthDetail(WealthDetail detail)
        {
            string url = "https://localhost:44399/UpdateWealthDetail/ById";
            Dictionary<string, string> dicParam = new Dictionary<string, string>();
            dicParam.Add("Id", detail.Id.ToString());
            dicParam.Add("WealthArea", detail.WealthArea);
            dicParam.Add("Amount", detail.Amount.ToString(CultureInfo.InvariantCulture));
            dicParam.Add("Remark", detail.Remark);
            HttpContent content = new FormUrlEncodedContent(dicParam);
            var str = await _httpClientCommonService.RemoteHelper(url, content,HttpVerb.Put);
            var result = Convert.ToBoolean(str);
            return result;
        }

        /// <summary>
        /// 增加财富详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public async Task<bool> AddWealthDetail(WealthDetail detail)
        {
            string url = "https://localhost:44399/AddWealthDetail";
            var content = (HttpContent) new StringContent(JsonConvert.SerializeObject(detail),Encoding.UTF8, "application/json");
            var str = await _httpClientCommonService.RemoteHelper(url, content, HttpVerb.Post);
            var result = Convert.ToBoolean(str);
            return result;
        }
    }
}
