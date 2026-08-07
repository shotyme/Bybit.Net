using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Delivery record
    /// </summary>
    [SerializationModel]
    public record BybitDeliveryRecord
    {
        /// <summary>
        /// ["<c>deliveryTime</c>"] Delivery time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("deliveryTime")]
        public DateTime DeliveryTime { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>side</c>"] Order side
        /// </summary>

        [JsonPropertyName("side")]
        public OrderSide Side { get; set; }
        /// <summary>
        /// ["<c>position</c>"] Executed quantity
        /// </summary>
        [JsonPropertyName("position")]
        public decimal Position { get; set; }
        /// <summary>
        /// ["<c>deliveryPrice</c>"] Delivery price
        /// </summary>
        [JsonPropertyName("deliveryPrice")]
        public decimal DeliveryPrice { get; set; }
        /// <summary>
        /// ["<c>entryPrice</c>"] Average entry price
        /// </summary>
        [JsonPropertyName("entryPrice")]
        public decimal? AverageEntryPrice { get; set; }
        /// <summary>
        /// ["<c>strike</c>"] Price
        /// </summary>
        [JsonPropertyName("strike")]
        public decimal Strike { get; set; }
        /// <summary>
        /// ["<c>fee</c>"] Fee
        /// </summary>
        [JsonPropertyName("fee")]
        public decimal Fee { get; set; }
        /// <summary>
        /// ["<c>deliveryRpl</c>"] Realized profit and loss
        /// </summary>
        [JsonPropertyName("deliveryRpl")]
        public decimal RealizedPnl { get; set; }
    }
}
