using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Trade info
    /// </summary>
    [SerializationModel]
    public record BybitTrade
    {
        /// <summary>
        /// ["<c>T</c>"] Trade timestamp
        /// </summary>
        [JsonPropertyName("T")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>s</c>"] Symbol
        /// </summary>
        [JsonPropertyName("s")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>S</c>"] Side
        /// </summary>
        [JsonPropertyName("S")]

        public OrderSide Side { get; set; }
        /// <summary>
        /// ["<c>v</c>"] Quantity
        /// </summary>
        [JsonPropertyName("v")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>p</c>"] Price
        /// </summary>
        [JsonPropertyName("p")]
        public decimal Price { get; set; }
        /// <summary>
        /// ["<c>L</c>"] Direction
        /// </summary>
        [JsonPropertyName("L")]

        public TickDirection? Direction { get; set; }
        /// <summary>
        /// ["<c>i</c>"] Trade id
        /// </summary>
        [JsonPropertyName("i")]
        public string TradeId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>BT</c>"] Is block trade
        /// </summary>
        [JsonPropertyName("BT")]
        public bool? IsBlockTrade { get; set; }
        /// <summary>
        /// ["<c>RPI</c>"] Is Retail Price Improvement trade
        /// </summary>
        [JsonPropertyName("RPI")]
        public bool? IsRpiTrade { get; set; }
        /// <summary>
        /// ["<c>seq</c>"] Cross sequence
        /// </summary>
        [JsonPropertyName("seq")]
        public long? Sequence { get; set; }
    }
}
