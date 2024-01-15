using System.Collections.Generic;
using System.Threading.Tasks;
using PriceMyHideAO.Domain.Model;
using Refit;

namespace PriceMyHideAO.Services.Refit.Interface
{
    public interface IGetPrices
    {
        [Get("/api/v2/stats/Prices/{matId}.json")]
        Task<List<AlbionDataResponse>> GetPricesToBuy([AliasAs("matId")] string matId);

        [Get("/api/v2/stats/Prices/{productName}.json")]
        Task<List<AlbionDataResponse>> GetPricesToSell([AliasAs("productName")] string productName);
    }
}
