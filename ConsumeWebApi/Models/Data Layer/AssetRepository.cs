using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using ConsumeWebApi.Helper;
using Newtonsoft.Json;
using WebClient = ConsumeWebApi.Helper.WebClient;

namespace ConsumeWebApi.Models.Data_Layer
{
    public class AssetRepository: IAssetRepository
    {
        public AssetRepository()
        {
            
        }

        // return data related to the assetdetail view model.
        //public IEnumerable<AssetDetail> Get()
        //{
        //    var assets = Get("4", "1234567890", "128");
        //    var newAssets = assets.Select(asset => new AssetDetail()
        //    {
        //        AssetId = asset.AssetId,
        //        FileURL = asset.FileURL,
        //        OriginalFileURL = asset.FileURL,
        //        ButtonText = "View",
        //        CreatedDate = asset.CreatedDate,
        //        ExpiryDate = asset.ExpiryDate,
        //        SiteId = asset.SiteId,
        //        AssetType = asset.AssetType
        //    }).ToList();

        //    return newAssets;
        //}

        //private IEnumerable<Asset> Get(string userId, string apiKey, string catId)
        //{
        //    WebClient _client = new WebClient();

        //    var parameters = string.Format("?userId={0}&apiKey={1}&categoryId={2}", userId, apiKey, catId);
        //    HttpResponseMessage response = _client.GetAsync(_url + parameters).Result;
        //    if (response.StatusCode == HttpStatusCode.BadRequest)
        //        throw new Exception(response.RequestMessage.ToString());

        //    var assets = JsonConvert.DeserializeObject<Asset[]>(response.Content.ReadAsStringAsync().Result);
        //    return assets;
        //}

        public IEnumerable<AssetDetail> Get()
        {
            throw new NotImplementedException();
        }
    }
}