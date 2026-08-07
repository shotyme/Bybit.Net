using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Trade history info
    /// </summary>
    [SerializationModel]
    public record BybitTradeHistory
    {
        /// <summary>
        /// ["<c>execId</c>"] Trade id
        /// </summary>
        [JsonPropertyName("execId")]
        public string TradeId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>price</c>"] Price of the trade
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// ["<c>size</c>"] Quantity of the trade
        /// </summary>
        [JsonPropertyName("size")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>side</c>"] Side
        /// </summary>
        [JsonPropertyName("side")]
        public OrderSide Side { get; set; }
        /// <summary>
        /// ["<c>time</c>"] Trade timestamp
        /// </summary>
        [JsonPropertyName("time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>isBlockTrade</c>"] Is block trade
        /// </summary>
        [JsonPropertyName("isBlockTrade")]
        public bool IsBlockTrade { get; set; }
        /// <summary>
        /// ["<c>isRPITrade</c>"] Is Retail Price Improvement trade
        /// </summary>
        [JsonPropertyName("isRPITrade")]
        public bool? IsRpiTrade { get; set; }
        /// <summary>
        /// ["<c>mP</c>"] [Option only] Mark price
        /// </summary>
        [JsonPropertyName("mP")]
        public decimal? MarkPrice { get; set; }
        /// <summary>
        /// ["<c>iP</c>"] [Option only] Index price
        /// </summary>
        [JsonPropertyName("iP")]
        public decimal? IndexPrice { get; set; }
        /// <summary>
        /// ["<c>mIv</c>"] [Option only] Mark iv
        /// </summary>
        [JsonPropertyName("mIv")]
        public decimal? MarkIv { get; set; }
        /// <summary>
        /// ["<c>iv</c>"] [Option only] Index iv
        /// </summary>
        [JsonPropertyName("iv")]
        public decimal? IndexIv { get; set; }
        /// <summary>
        /// ["<c>seq</c>"] Cross sequence
        /// </summary>
        [JsonPropertyName("seq")]
        public long? Sequence { get; set; }
    }
}
