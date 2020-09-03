using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using Newtonsoft.Json;
using RichProjectAdmin.Domain.Interface;
using RichProjectAdmin.Domain.Model;

namespace RichProjectAdmin.Application.Service
{
    public class WealthDetailService: IWealthDetailService,ITransientDependency
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
            var str = await RemoteHelper(url, null);
            var result = JsonConvert.DeserializeObject<List<WealthDetail>>(str);
            return result;
            //Dictionary<string, string> dicParam = new Dictionary<string, string>();
            //dicParam.Add("id", "1");
            //dicParam.Add("name", "张三");
            //HttpContent content = new FormUrlEncodedContent(dicParam);
            //return await RemoteHelper(url, content);
        }
        private async Task<string> RemoteHelper(string url, HttpContent content)
        {
            var result = string.Empty;
            try
            {
                using (var client = _httpClientFactory.CreateClient())
                using (var response = await client.GetAsync(url))
                {
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
