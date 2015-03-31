using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ConsumeWebApi.Helper;
using ConsumeWebApi.Models;
using Microsoft.Ajax.Utilities;

namespace ConsumeWebApi.Controllers
{
    public class AssetController : Controller
    {

        private readonly WebClient _client = new WebClient();

        //
        // GET: /Asset/
        public async Task<ActionResult> Index()
        {
            var assets = await _client.GetAsync();
            if (assets == null)
            {
                return HttpNotFound();
            }

            List<AssetViewModel> assetsVM = new List<AssetViewModel>();
            foreach (var asset in assets)
            {
                assetsVM.Add(new AssetViewModel
                {
                    FileURL = asset.FileURL,
                    AssetId = asset.AssetId,
                    ButtonText = asset.ButtonText

                });
            }

            return View(assetsVM);
        }


        public async Task<ActionResult> Index2()
        {
            var assets = await _client.GetAsync();
            if (assets == null)
            {
                return HttpNotFound();
            }

            List<AssetViewModel> assetsVM = new List<AssetViewModel>();
            foreach (var asset in assets)
            {
                assetsVM.Add(new AssetViewModel
                {
                    FileURL = asset.FileURL,
                    AssetId = asset.AssetId,
                    ButtonText = asset.ButtonText

                });
            }

            return View(assetsVM);
        }

        // GET: /Asset/View/1

        public async Task<ActionResult> View(int id)
        {
            var asset = await _client.GetAsync(id);

            if (asset == null)
            {
                return HttpNotFound();
            }
            
            // map the asset to the AssetDetail ViewModel.
            var assetViewModel = new AssetDetail
            {
                AssetId = asset.AssetId,
                FileURL = asset.FileURL,
                OriginalFileURL = asset.FileURL,
                ButtonText = "View",
                CreatedDate = asset.CreatedDate,
                ExpiryDate = asset.ExpiryDate,
                SiteId = asset.SiteId,
                AssetType = asset.AssetType
            };

            return View(assetViewModel);
        }

        public string PopUpWindow(string url)
        {
            url = url.Remove(url.Length-1);
            string urlToUse = string.Format("<img src={0} />", url);            
            return urlToUse;
        }

    }
}
