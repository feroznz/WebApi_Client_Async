using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeWebApi.Models.Data_Layer
{
    public interface IAssetRepository
    {
        IEnumerable<AssetDetail> Get();
    }
}
