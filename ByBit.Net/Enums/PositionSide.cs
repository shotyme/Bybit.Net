using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Side of a position
    /// </summary>
    [JsonConverter(typeof(EnumConverter<PositionSide>))]
    public enum PositionSide
    {
        /// <summary>
        /// ["<c>Buy</c>"] Buy
        /// </summary>
        [Map("Buy")]
        Buy,
        /// <summary>
        /// ["<c>Sell</c>"] Sell
        /// </summary>
        [Map("Sell")]
        Sell,
        /// <summary>
        /// ["<c>None</c>"] None
        /// </summary>
        [Map("None")]
        None
    }
}
