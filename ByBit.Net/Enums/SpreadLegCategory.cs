using CryptoExchange.Net.Attributes;
using System.Text.Json.Serialization;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Leg category
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SpreadLegCategory>))]
    public enum SpreadLegCategory
    {
        /// <summary>
        /// ["<c>combination</c>"] Combination
        /// </summary>
        [Map("combination")]
        Combination,
        /// <summary>
        /// ["<c>spot_leg</c>"] Spot leg
        /// </summary>
        [Map("spot_leg")]
        SpotLeg,
        /// <summary>
        /// ["<c>future_leg</c>"] Futures leg
        /// </summary>
        [Map("future_leg")]
        FutureLeg
    }
}
