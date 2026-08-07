using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Spread ticker update
    /// </summary>
    public record BybitSpreadTickerUpdate
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol name
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>bidPrice</c>"] Best bid price
        /// </summary>
        [JsonPropertyName("bidPrice")]
        public decimal? BestBidPrice { get; set; }
        /// <summary>
        /// ["<c>bidSize</c>"] Best bid price
        /// </summary>
        [JsonPropertyName("bidSize")]
        public decimal? BestBidQuantity { get; set; }
        /// <summary>
        /// ["<c>askPrice</c>"] Best bid price
        /// </summary>
        [JsonPropertyName("askPrice")]
        public decimal? BestAskPrice { get; set; }
        /// <summary>
        /// ["<c>askSize</c>"] Best bid price
        /// </summary>
        [JsonPropertyName("askSize")]
        public decimal? BestAskQuantity { get; set; }
        /// <summary>
        /// ["<c>lastPrice</c>"] Last trade price
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public decimal? LastPrice { get; set; }
        /// <summary>
        /// ["<c>highPrice24h</c>"] 24h High price
        /// </summary>
        [JsonPropertyName("highPrice24h")]
        public decimal? HighPrice { get; set; }
        /// <summary>
        /// ["<c>lowPrice24h</c>"] 24h Low price
        /// </summary>
        [JsonPropertyName("lowPrice24h")]
        public decimal? LowPrice { get; set; }
        /// <summary>
        /// ["<c>prevPrice24h</c>"] 24h Open price
        /// </summary>
        [JsonPropertyName("prevPrice24h")]
        public decimal? OpenPrice { get; set; }
        /// <summary>
        /// ["<c>volume24h</c>"] 24h Volume
        /// </summary>
        [JsonPropertyName("volume24h")]
        public decimal Volume { get; set; }
    }
}
