using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Web;

namespace RichProjectAdmin.Application.Service.Frame
{
    public class HttpClientCommonService:ITransientDependency
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpClientCommonService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> RemoteHelper(string url, HttpContent content, HttpVerb verb)
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
