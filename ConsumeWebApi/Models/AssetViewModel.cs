using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumeWebApi.Models
{
    public class AssetViewModel
    {
        public string FileURL { get; set; }

        public int AssetId { get; set; }
       
        public string ButtonText { get;set; }
    }
}