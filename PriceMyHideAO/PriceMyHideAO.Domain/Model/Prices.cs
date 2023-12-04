using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceMyHideAO.Domain.Model
{
    public class Prices
    {
        public int SellPriceMin { get; set; }
        public int SellPriceMax { get; set; }
        public int BuyPriceMin { get; set; }
        public int BuyPriceMax { get; set; }
    }
}
