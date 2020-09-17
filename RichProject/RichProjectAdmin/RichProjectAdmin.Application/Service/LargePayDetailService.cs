using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class LargePayDetailService: ILargePayDetailService,ITransientDependency
    {
        private readonly HttpClientCommonService _httpClientCommonService;
        public LargePayDetailService(HttpClientCommonService httpClientCommonService)
        {
            _httpClientCommonService = httpClientCommonService;
        }

        /// <summary>
        /// 获取大型支出详情
        /// </summary>
        /// <returns></returns>
        public async Task<List<LargePayDetail>> GetLargePayDetail()
        {
            string url = "https://localhost:44399/GetLargePayDetail";
            var str = await _httpClientCommonService.RemoteHelper(url, null, HttpVerb.Get);
            var result = JsonConvert.DeserializeObject<List<LargePayDetail>>(str);
            return result;
        }

        /// <summary>
        /// 删除财富详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteLargePayDetail(int id)
        {
            string url = $"https://localhost:44399/DeleteLargePayDetail/ById?id={id}";
            var str = await _httpClientCommonService.RemoteHelper(url, null, HttpVerb.Delete);
            var result = Convert.ToBoolean(str);
            return result;
        }

        /// <summary>
        /// 更新财富详情
        /// </summary>
        /// <returns></returns>
        public async Task<bool> UpdateLargePayDetail(LargePayDetail detail)
        {
            string url = "https://localhost:44399/UpdateLargePayDetail/ById";
            var content = (HttpContent)new StringContent(JsonConvert.SerializeObject(detail), Encoding.UTF8, "application/json");
            var str = await _httpClientCommonService.RemoteHelper(url, content, HttpVerb.Put);
            var result = Convert.ToBoolean(str);
            return result;
        }

        /// <summary>
        /// 增加财富详情
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        public async Task<bool> AddLargePayDetail(LargePayDetail detail)
        {
            string url = "https://localhost:44399/AddLargePayDetail";
            var content = (HttpContent)new StringContent(JsonConvert.SerializeObject(detail), Encoding.UTF8, "application/json");
            var str = await _httpClientCommonService.RemoteHelper(url, content, HttpVerb.Post);
            var result = Convert.ToBoolean(str);
            return result;
        }
    }
}
