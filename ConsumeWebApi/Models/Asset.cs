using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumeWebApi.Models
{
    public class Asset
    {
        public string FileURL { get; set; }

        public int AssetId { get; set; }
        //Thumbnail Image url = this.FileUrl;
        public int SiteId { get; set; }
        public string AssetType { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ButtonText { get; set; }
    }
}