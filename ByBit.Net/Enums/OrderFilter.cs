using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Order filter
    /// </summary>
    [JsonConverter(typeof(EnumConverter<OrderFilter>))]
    public enum OrderFilter
    {
        /// <summary>
        /// ["<c>Order</c>"] Active order
        /// </summary>
        [Map("Order")]
        Order,
        /// <summary>
        /// ["<c>StopOrder</c>"] Conditional order
        /// </summary>
        [Map("StopOrder")]
        StopOrder,
        /// <summary>
        /// ["<c>tpslOrder</c>"] Spot TakeProfit/StopLoss order
        /// </summary>
        [Map("tpslOrder")]
        TpSlOrder,
        /// <summary>
        /// ["<c>OcoOrder</c>"] Oco order
        /// </summary>
        [Map("OcoOrder")]
        OcoOrder,
        /// <summary>
        /// ["<c>BidirectionalTpslOrder</c>"] Bidirectional TakeProfit/StopLoss order
        /// </summary>
        [Map("BidirectionalTpslOrder")]
        BidirectionalTpslOrder
    }
}
