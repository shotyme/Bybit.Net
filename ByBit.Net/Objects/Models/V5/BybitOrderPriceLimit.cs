using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Order price limit
    /// </summary>
    public record BybitOrderPriceLimit
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol name
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>buyLmt</c>"] Highest bid price
        /// </summary>
        [JsonPropertyName("buyLmt")]
        public decimal BuyLimit { get; set; }
        /// <summary>
        /// ["<c>sellLmt</c>"] Lowest ask price
        /// </summary>
        [JsonPropertyName("sellLmt")]
        public decimal SellLimit { get; set; }
        /// <summary>
        /// ["<c>ts</c>"] Timestamp
        /// </summary>
        [JsonPropertyName("ts")]
        public DateTime Timestamp { get; set; }
    }
}
