using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Product type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<ProductType>))]
    public enum ProductType
    {
        /// <summary>
        /// ["<c>OPTIONS</c>"] Options
        /// </summary>
        [Map("OPTIONS", "3")]
        Options,
        /// <summary>
        /// ["<c>DERIVATIVES</c>"] Derivatives
        /// </summary>
        [Map("DERIVATIVES", "1")]
        Derivatives,
        /// <summary>
        /// ["<c>SPOT</c>"] Spot
        /// </summary>
        [Map("SPOT", "2")]
        Spot,
        /// <summary>
        /// ["<c>SPREAD</c>"] Spread
        /// </summary>
        [Map("SPREAD", "4")]
        Spread
    }
}
