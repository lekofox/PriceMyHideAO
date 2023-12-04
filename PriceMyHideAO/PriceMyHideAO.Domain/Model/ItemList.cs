namespace PriceMyHideAO.Domain.Model
{
    public class ItemList
    {
        public string Items { get; set; }
        public List<string> Locations { get; set; } = new List<string> { "Bridgewatch", "Caerleon", "Martlock", "Lymhurst", "Thetford" };
        public string Format { get; set; } = "json";
    }
}