using PriceMyHideAO.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceMyHideAO.Domain.Model
{

    public class AlbionDataResponse
    {
        private ItemList _itemList = new ItemList();

        public string item_id { get; set; }
        public string city { get; set; }
        public int quality { get; set; }
        public int sell_price_min { get; set; }
        public DateTime sell_price_min_date { get; set; }
        public int sell_price_max { get; set; }
        public DateTime sell_price_max_date { get; set; }
        public int buy_price_min { get; set; }
        public DateTime buy_price_min_date { get; set; }
        public int buy_price_max { get; set; }
        public DateTime buy_price_max_date { get; set; }
    }


    public static class AlbionDataResponseExtensions
    {
        private static readonly ItemList _itemList = new ItemList();
        public static AlbionDataDTO MapToCityResponse(this List<AlbionDataResponse> albionDataResponse, Recipe recipe)
        {
            var sellCity = albionDataResponse.FindBestCityToSell(recipe.ProductName);
            var buyCity = albionDataResponse.FindBestCityToBuy(recipe.RawMatId, recipe.RefinedMatId);

            var result = new AlbionDataDTO()
            {
                BuyCity = buyCity,
                SellCity = sellCity,
            };

            return result;

        }

        private static CityResponse FindBestCityToSell(this List<AlbionDataResponse> response, string productName)
        {
            var result = new CityResponse()
            {
                City = "",
                Item = productName,
                Price = 0
            };
            var filteredResponse = response.Where(s => s.item_id == result.Item).ToList();

            foreach (var itemResponse in filteredResponse)
            {
                if ((itemResponse.sell_price_min > result.Price) && _itemList.Locations.Exists(city => city == itemResponse.city))
                {
                    result.City = itemResponse.city;
                    result.Price = itemResponse.sell_price_min;
                }
            }

            return result;
        }

        private static List<CityResponse> FindBestCityToBuy(this List<AlbionDataResponse> albionDataResponses, string rawMatId, string refinedMatId)
        {
            var result = new List<CityResponse>()
            {
                new CityResponse() { City = "", Item = rawMatId, Price = int.MaxValue },
                new CityResponse () { City = "", Item = refinedMatId, Price = int.MaxValue },
            };

            var rawMat = albionDataResponses.Where(s => s.item_id == result[0].Item).ToList();
            var refinedMat = albionDataResponses.Where(s => s.item_id == result[1].Item).ToList();

            foreach (var itemResponse in rawMat)
            {
                if (itemResponse.sell_price_min < result[0].Price && itemResponse.sell_price_min != 0 && _itemList.Locations.Exists(city => city == itemResponse.city))
                {
                    result[0].City = itemResponse.city;
                    result[0].Price = itemResponse.sell_price_min;
                }
            }

            foreach (var itemResponse in refinedMat)
            {
                if (itemResponse.sell_price_min < result[1].Price && itemResponse.sell_price_min != 0 && _itemList.Locations.Exists(city => city == itemResponse.city))
                {
                    result[1].City = itemResponse.city;
                    result[1].Price = itemResponse.sell_price_min;
                }
            }

            return result;
        }
    }

}


