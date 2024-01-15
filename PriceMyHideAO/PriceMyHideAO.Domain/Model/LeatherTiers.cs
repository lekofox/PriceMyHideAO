
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PriceMyLEATHERAO.Domain.Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LeatherTiers
    {
        [Description("T6.1")]
        T6_LEATHER_LEVEL1_1,
        [Description("T6.2")]
        T6_LEATHER_LEVEL2_2,
        [Description("T6.3")]
        T6_LEATHER_LEVEL3_3,
        [Description("T6.4")]
        T6_LEATHER_LEVEL4_4,
        [Description("T7.1")]
        T7_LEATHER_LEVEL1_1,
        [Description("T7.2")]
        T7_LEATHER_LEVEL2_2,
        [Description("T7.3")]
        T7_LEATHER_LEVEL3_3,
        [Description("T7.4")]
        T7_LEATHER_LEVEL4_4,
        [Description("T8.1")]
        T8_LEATHER_LEVEL1_1,
        [Description("T8.2")]
        T8_LEATHER_LEVEL2_2,
        [Description("T8.3")]
        T8_LEATHER_LEVEL3_3,
        [Description("T8.4")]
        T8_LEATHER_LEVEL4_4,
    }

}
