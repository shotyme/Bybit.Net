using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Side of an order
    /// </summary>
    [JsonConverter(typeof(EnumConverter<OrderSide>))]
    public enum OrderSide
    {
        /// <summary>
        /// ["<c>Buy</c>"] Buy
        /// </summary>
        [Map("Buy", "BUY")]
        Buy,
        /// <summary>
        /// ["<c>Sell</c>"] Sell
        /// </summary>
        [Map("Sell", "SELL")]
        Sell
    }
}
