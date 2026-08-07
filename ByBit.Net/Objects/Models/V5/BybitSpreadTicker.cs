using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Spread ticker info
    /// </summary>
    public record BybitSpreadTicker
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>bidPrice</c>"] Bid price
        /// </summary>
        [JsonPropertyName("bidPrice")]
        public decimal? BidPrice { get; set; }
        /// <summary>
        /// ["<c>bidSize</c>"] Bid quantity
        /// </summary>
        [JsonPropertyName("bidSize")]
        public decimal? BidQuantity { get; set; }
        /// <summary>
        /// ["<c>askPrice</c>"] Ask price
        /// </summary>
        [JsonPropertyName("askPrice")]
        public decimal? AskPrice { get; set; }
        /// <summary>
        /// ["<c>askSize</c>"] Ask quantity
        /// </summary>
        [JsonPropertyName("askSize")]
        public decimal? AskQuantity { get; set; }
        /// <summary>
        /// ["<c>lastPrice</c>"] Last price
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public decimal LastPrice { get; set; }
        /// <summary>
        /// ["<c>highPrice24h</c>"] High price24h
        /// </summary>
        [JsonPropertyName("highPrice24h")]
        public decimal HighPrice24h { get; set; }
        /// <summary>
        /// ["<c>lowPrice24h</c>"] Low price24h
        /// </summary>
        [JsonPropertyName("lowPrice24h")]
        public decimal LowPrice24h { get; set; }
        /// <summary>
        /// ["<c>prevPrice24h</c>"] Prev price24h
        /// </summary>
        [JsonPropertyName("prevPrice24h")]
        public decimal PrevPrice24h { get; set; }
        /// <summary>
        /// ["<c>volume24h</c>"] Volume24h
        /// </summary>
        [JsonPropertyName("volume24h")]
        public decimal Volume24h { get; set; }
    }


}
