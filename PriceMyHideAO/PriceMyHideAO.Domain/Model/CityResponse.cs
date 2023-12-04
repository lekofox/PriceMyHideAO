using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceMyHideAO.Domain.Model
{
    public class CityResponse
    {
        public string Item { get; set; }
        public string City { get; set; }
        public Prices Prices { get; set; }
    }
}
