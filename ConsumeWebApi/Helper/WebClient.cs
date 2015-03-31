using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using ConsumeWebApi.Models;
using Newtonsoft.Json;

namespace ConsumeWebApi.Helper
{
    public class WebClient
    {
        private readonly string _url = ConfigurationManager.AppSettings["WebApiBaseUrl"];

        public async Task<IEnumerable<Asset>> GetAsync()
        {

            var url = GetFormattedUrl();
            using (var httpClient = new HttpClient())
            {
                 return JsonConvert.DeserializeObject<List<Asset>>(
                       await httpClient.GetStringAsync(url));
            }
        }

        public async Task<AssetDetail> GetAsync(int id)
        {
            var url = GetFormattedUrl();
            using (var httpClient  = new HttpClient())
            {
                var result = JsonConvert.DeserializeObject<List<Asset>>(
                       await httpClient.GetStringAsync(url));
                return new AssetDetail();
            }
        }


        private string GetFormattedUrl()
        {
            const string userId = "4";
            const string apiKey = "123456789";
            const string catId = "128";
            var parameters = string.Format("?userId={0}&apiKey={1}&categoryId={2}", userId, apiKey, catId);
            var newUrl = _url + parameters;
            return newUrl;
        }
    }
}