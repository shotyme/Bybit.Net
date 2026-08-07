using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Product type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SpreadProductType>))]
    public enum SpreadProductType
    {
        /// <summary>
        /// ["<c>FUTURES</c>"] Futures
        /// </summary>
        [Map("FUTURES")]
        Futures,
        /// <summary>
        /// ["<c>SPOT</c>"] Spot
        /// </summary>
        [Map("SPOT")]
        Spot
    }
}
