using PriceMyHideAO.Domain.Model;

namespace PriceMyHideAO.Domain.DTO
{
    public class AlbionDataDTO
    {
        public Recipe Recipe{ get; set; }
        public List<CityResponse> BuyCity { get; set; }
        public CityResponse SellCity { get; set; }
    }
}
