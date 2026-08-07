using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Leverage token order record
    /// </summary>
    [SerializationModel]
    public record BybitLeverageTokenHistory
    {
        /// <summary>
        /// ["<c>ltCoin</c>"] Token abbreviation
        /// </summary>
        [JsonPropertyName("ltCoin")]
        public string Token { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>ltOrderStatus</c>"] Order status
        /// </summary>
        [JsonPropertyName("ltOrderStatus")]
        public LeverageTokenOrderStatus Status { get; set; }
        /// <summary>
        /// ["<c>ltOrderType</c>"] Order record type
        /// </summary>
        [JsonPropertyName("ltOrderType")]
        public LeverageTokenRecordType OrderType { get; set; }
        /// <summary>
        /// ["<c>value</c>"] Filled value
        /// </summary>
        [JsonPropertyName("value")]
        public decimal? Value { get; set; }
        /// <summary>
        /// ["<c>amount</c>"] Filled quantity
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string PurchaseId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>serialNo</c>"] Serial number
        /// </summary>
        [JsonPropertyName("serialNo")]
        public string? ClientOrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>valueCoin</c>"] Quote asset
        /// </summary>
        [JsonPropertyName("valueCoin")]
        public string QuoteAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>fee</c>"] Fee
        /// </summary>
        [JsonPropertyName("fee")]
        public decimal Fee { get; set; }
        /// <summary>
        /// Update time
        /// </summary>
        [JsonPropertyName("updateTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// Order time
        /// </summary>
        [JsonPropertyName("orderTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime Orderime { get; set; }
    }
}
