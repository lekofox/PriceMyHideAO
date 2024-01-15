using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PriceMyHideAO.Domain.Model;
using PriceMyHideAO.Services.Refit.Interface;
using Refit;

namespace PriceMyHideAO.Services.Refit.RefitClient
{
    public class GetPricesService : IGetPrices
    {
        private readonly IGetPrices _getPricesClient;

        public GetPricesService()
        {
            _getPricesClient = RestService.For<IGetPrices>("https://west.albion-online-data.com");
        }

        private async Task<List<AlbionDataResponse>> HandleRequest(Func<Task<List<AlbionDataResponse>>> request)
        {
            try
            {
                return await request.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public Task<List<AlbionDataResponse>> GetPricesToBuy([AliasAs("matId")] string matId)
        {
            return HandleRequest(() => _getPricesClient.GetPricesToBuy(matId));
        }

        public Task<List<AlbionDataResponse>> GetPricesToSell([AliasAs("productName")] string productName)
        {
            return HandleRequest(() => _getPricesClient.GetPricesToSell(productName));
        }
    }
}
