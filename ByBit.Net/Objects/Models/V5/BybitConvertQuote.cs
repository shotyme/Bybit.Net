using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Convert quote
    /// </summary>
    [SerializationModel]
    public record BybitConvertQuote
    {
        /// <summary>
        /// ["<c>quoteTxId</c>"] Quote transaction id
        /// </summary>
        [JsonPropertyName("quoteTxId")]
        public string QuoteTransactionId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>exchangeRate</c>"] Exchange rate
        /// </summary>
        [JsonPropertyName("exchangeRate")]
        public decimal ExchangeRate { get; set; }
        /// <summary>
        /// ["<c>fromCoin</c>"] From asset
        /// </summary>
        [JsonPropertyName("fromCoin")]
        public string FromAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>fromCoinType</c>"] From asset type
        /// </summary>
        [JsonPropertyName("fromCoinType")]
        public string FromAssetType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>toCoin</c>"] To asset
        /// </summary>
        [JsonPropertyName("toCoin")]
        public string ToAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>toCoinType</c>"] To asset type
        /// </summary>
        [JsonPropertyName("toCoinType")]
        public string ToAssetType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>fromAmount</c>"] From quantity
        /// </summary>
        [JsonPropertyName("fromAmount")]
        public decimal FromQuantity { get; set; }
        /// <summary>
        /// ["<c>toAmount</c>"] To quantity
        /// </summary>
        [JsonPropertyName("toAmount")]
        public decimal ToQuantity { get; set; }
        /// <summary>
        /// Expire time
        /// </summary>
        [JsonPropertyName("expiredTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime ExpireTime { get; set; }
        /// <summary>
        /// ["<c>requestId</c>"] Request id
        /// </summary>
        [JsonPropertyName("requestId")]
        public string? RequestId { get; set; }
    }


}
