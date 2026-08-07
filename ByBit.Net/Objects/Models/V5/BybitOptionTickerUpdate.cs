using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Option ticker update
    /// </summary>
    [SerializationModel]
    public record BybitOptionTickerUpdate
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>bidPrice</c>"] Best bid price
        /// </summary>
        [JsonPropertyName("bidPrice")]
        public decimal BestBidPrice { get; set; }
        /// <summary>
        /// ["<c>bidSize</c>"] Best bid quantity
        /// </summary>
        [JsonPropertyName("bidSize")]
        public decimal BestBidQuantity { get; set; }
        /// <summary>
        /// ["<c>bidIv</c>"] Bid IV
        /// </summary>
        [JsonPropertyName("bidIv")]
        public decimal BidIv { get; set; }
        /// <summary>
        /// ["<c>askPrice</c>"] Best ask price
        /// </summary>
        [JsonPropertyName("askPrice")]
        public decimal BestAskPrice { get; set; }
        /// <summary>
        /// ["<c>askSize</c>"] Best ask quantity
        /// </summary>
        [JsonPropertyName("askSize")]
        public decimal BestAskQuantity { get; set; }
        /// <summary>
        /// ["<c>askIv</c>"] Ask IV
        /// </summary>
        [JsonPropertyName("askIv")]
        public decimal AskIv { get; set; }
        /// <summary>
        /// ["<c>lastPrice</c>"] Last price
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public decimal LastPrice { get; set; }
        /// <summary>
        /// ["<c>highPrice24h</c>"] 24h high price
        /// </summary>
        [JsonPropertyName("highPrice24h")]
        public decimal HighPrice24h { get; set; }
        /// <summary>
        /// ["<c>lowPrice24h</c>"] 24h low price
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
        /// ["<c>markPriceIv</c>"] Mark price iv
        /// </summary>
        [JsonPropertyName("markPriceIv")]
        public decimal MarkPriceIv { get; set; }
        /// <summary>
        /// ["<c>underlyingPrice</c>"] Underlying price
        /// </summary>
        [JsonPropertyName("underlyingPrice")]
        public decimal UnderlyingPrice { get; set; }
        /// <summary>
        /// ["<c>openInterest</c>"] Open interest
        /// </summary>
        [JsonPropertyName("openInterest")]
        public decimal OpenInterest { get; set; }
        /// <summary>
        /// ["<c>turnover24h</c>"] Turnover 24h
        /// </summary>
        [JsonPropertyName("turnover24h")]
        public decimal Turnover24h { get; set; }
        /// <summary>
        /// ["<c>volume24h</c>"] Volume 24h
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
        /// ["<c>change24h</c>"] 24h change
        /// </summary>
        [JsonPropertyName("change24h")]
        public decimal Change24h { get; set; }
    }
}
