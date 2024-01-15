using Microsoft.AspNetCore.Mvc;
using PriceMyHideAO.Domain.DTO;
using PriceMyHideAO.Domain.Model;
using PriceMyHideAO.Services.Refit.Interface;
using PriceMyLEATHERAO.Domain.Model;

namespace PriceMyHideAO.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PricesController : ControllerBase
    {

        private readonly IGetPrices _refitService;
        private readonly ILogger<PricesController> _logger;

        public PricesController(ILogger<PricesController> logger, IGetPrices refitService)
        {
            _logger = logger;
            _refitService = refitService;
        }

        //[HttpGet(Name = "CalculateWhereToSell")]
        //public async Task<AlbionDataDTO> CalculateWhereToSell(LeatherTiers leatherTier)
        //{
        //    var recipe = new Recipe(leatherTier);
        //    var response = await _refitService.GetPricesToSell(recipe.ProductName);
        //    var result = new AlbionDataDTO
        //    {
        //        Recipe = recipe,
        //        BuyCity = response.MapToCityResponse()
        //    };

        //    return result;

        //}


        [HttpGet(Name = "CalculateWhereToBuy")]
        public async Task<AlbionDataDTO> CalculateWhereToBuy(LeatherTiers leatherTiers)
        {
            var recipe = new Recipe(leatherTiers);
            List<AlbionDataResponse> matBuyPrice = await _refitService.GetPricesToBuy($"{recipe.RawMatId},{recipe.RefinedMatId}");
            List<AlbionDataResponse> cityToSell = await _refitService.GetPricesToSell(recipe.ProductName);

            // Combina as duas listas usando Concat
            List<AlbionDataResponse> combinedList = new List<AlbionDataResponse>();
            combinedList.AddRange(cityToSell); 
            combinedList.AddRange(matBuyPrice);    

            var result = combinedList.MapToCityResponse(recipe);
            result.Recipe = recipe;
            return result;
        }

    }
}