using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Ticker info
    /// </summary>
    [SerializationModel]
    public record BybitOptionTicker
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>bid1Price</c>"] Best bid price
        /// </summary>
        [JsonPropertyName("bid1Price")]
        public decimal BestBidPrice { get; set; }
        /// <summary>
        /// ["<c>bid1Size</c>"] Best bid quantity
        /// </summary>
        [JsonPropertyName("bid1Size")]
        public decimal BestBidQuantity { get; set; }
        /// <summary>
        /// ["<c>bid1Iv</c>"] Best bid IV
        /// </summary>
        [JsonPropertyName("bid1Iv")]
        public decimal BestBidIv { get; set; }
        /// <summary>
        /// ["<c>ask1Price</c>"] Best ask price
        /// </summary>
        [JsonPropertyName("ask1Price")]
        public decimal BestAskPrice { get; set; }
        /// <summary>
        /// ["<c>ask1Size</c>"] Best ask quantity
        /// </summary>
        [JsonPropertyName("ask1Size")]
        public decimal BestAskQuantity { get; set; }
        /// <summary>
        /// ["<c>ask1Iv</c>"] Best ask IV
        /// </summary>
        [JsonPropertyName("ask1Iv")]
        public decimal BestAskIv { get; set; }
        /// <summary>
        /// ["<c>lastPrice</c>"] Last trade price
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public decimal LastPrice { get; set; }
        /// <summary>
        /// ["<c>highPrice24h</c>"] High price last 24h
        /// </summary>
        [JsonPropertyName("highPrice24h")]
        public decimal HighPrice24h { get; set; }
        /// <summary>
        /// ["<c>lowPrice24h</c>"] Low price last 24h
        /// </summary>
        [JsonPropertyName("lowPrice24h")]
        public decimal LowPrice24h { get; set; }
        /// <summary>
        /// ["<c>markPrice</c>"] Mark price
        /// </summary>
        [JsonPropertyName("markPrice")]
        public decimal MarkPrice { get; set; }
        /// <summary>
        /// ["<c>indexPrice</c>"] Index price
        /// </summary>
        [JsonPropertyName("indexPrice")]
        public decimal IndexPrice { get; set; }
        /// <summary>
        /// ["<c>markIv</c>"] Mark iv
        /// </summary>
        [JsonPropertyName("markIv")]
        public decimal MarkIv { get; set; }
        /// <summary>
        /// ["<c>underlyingPrice</c>"] Underlying asset price
        /// </summary>
        [JsonPropertyName("underlyingPrice")]
        public decimal UnderlyingPrice { get; set; }
        /// <summary>
        /// ["<c>openInterest</c>"] Open interest
        /// </summary>
        [JsonPropertyName("openInterest")]
        public decimal OpenInterest { get; set; }
        /// <summary>
        /// ["<c>turnover24h</c>"] Turnover last 24h
        /// </summary>
        [JsonPropertyName("turnover24h")]
        public decimal Turnover24h { get; set; }
        /// <summary>
        /// ["<c>volume24h</c>"] Volume last 24h
        /// </summary>
        [JsonPropertyName("volume24h")]
        public decimal Volume24h { get; set; }
        /// <summary>
        /// ["<c>totalVolume</c>"] Total volume
        /// </summary>
        [JsonPropertyName("totalVolume")]
        public decimal TotalVolume { get; set; }
        /// <summary>
        /// ["<c>totalTurnover</c>"] Total turnover
        /// </summary>
        [JsonPropertyName("totalTurnover")]
        public decimal TotalTurnover { get; set; }
        /// <summary>
        /// ["<c>delta</c>"] Delta
        /// </summary>
        [JsonPropertyName("delta")]
        public decimal Delta { get; set; }
        /// <summary>
        /// ["<c>gamma</c>"] Gamma
        /// </summary>
        [JsonPropertyName("gamma")]
        public decimal Gamma { get; set; }
        /// <summary>
        /// ["<c>vega</c>"] Vega
        /// </summary>
        [JsonPropertyName("vega")]
        public decimal Vega { get; set; }
        /// <summary>
        /// ["<c>theta</c>"] Theta
        /// </summary>
        [JsonPropertyName("theta")]
        public decimal Theta { get; set; }
        /// <summary>
        /// ["<c>predictedDeliveryPrice</c>"] Predicted delivery price
        /// </summary>
        [JsonPropertyName("predictedDeliveryPrice")]
        public decimal PredictedDeliveryPrice { get; set; }
        /// <summary>
        /// ["<c>change24h</c>"] Change since 24h ago
        /// </summary>
        [JsonPropertyName("change24h")]
        public decimal Change24h { get; set; }
    }
}
