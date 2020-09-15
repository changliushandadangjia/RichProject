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
using RichProjectAdmin.Domain.Interface;
using RichProjectAdmin.Domain.Model;

namespace RichProjectAdmin.Application.Service
{
    public class WealthDetailService : IWealthDetailService, ITransientDependency
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public WealthDetailService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// 获取所有财富详情
        /// </summary>
        /// <returns></returns>
        public async Task<List<WealthDetail>> GetWealthDetail()
        {
            string url = "https://localhost:44399/GetWealthDetail";
            var str = await RemoteHelper(url, null,HttpVerb.Get);
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
            var str = await RemoteHelper(url, null,HttpVerb.Get);
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
            var str = await RemoteHelper(url, null,HttpVerb.Delete);
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
            var str = await RemoteHelper(url, content,HttpVerb.Put);
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
            Dictionary<string, string> dicParam = new Dictionary<string, string>();
            dicParam.Add("Id", detail.Id.ToString());
            dicParam.Add("WealthArea", detail.WealthArea);
            dicParam.Add("Amount", detail.Amount.ToString(CultureInfo.InvariantCulture));
            dicParam.Add("Remark", detail.Remark);
            HttpContent content = new FormUrlEncodedContent(dicParam);
            var str = await RemoteHelper(url, content, HttpVerb.Post);
            var result = Convert.ToBoolean(str);
            return result;
        }

        private async Task<string> RemoteHelper(string url, HttpContent content, HttpVerb verb)
        {
            var result = string.Empty;
            try
            {
                using (var client = _httpClientFactory.CreateClient())
                {
                    HttpResponseMessage response;
                    if (verb == HttpVerb.Get)
                    {
                        response = await client.GetAsync(url);
                    }
                    else if (verb == HttpVerb.Post)
                    {
                        response = await client.PostAsync(url, content);
                    }
                    else if (verb == HttpVerb.Delete)
                    {
                        response = await client.DeleteAsync(url);
                    }
                    else
                    {
                        response = await client.PutAsync(url, content);
                    }
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        result = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
    }
}
