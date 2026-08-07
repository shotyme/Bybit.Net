using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    [SerializationModel]
    internal record BybitConvertTransactionWrapper
    {
        /// <summary>
        /// ["<c>result</c>"] Result
        /// </summary>
        [JsonPropertyName("result")]
        public BybitConvertTransaction Result { get; set; } = null!;
    }

    [SerializationModel]
    internal record BybitConvertTransactionListWrapper
    {
        /// <summary>
        /// ["<c>list</c>"] List
        /// </summary>
        [JsonPropertyName("list")]
        public BybitConvertTransaction[] List { get; set; } = Array.Empty<BybitConvertTransaction>();
    }

    /// <summary>
    /// Convert transaction info
    /// </summary>
    [SerializationModel]
    public record BybitConvertTransaction
    {
        /// <summary>
        /// ["<c>accountType</c>"] Account type
        /// </summary>
        [JsonPropertyName("accountType")]
        public ConvertAccountType AccountType { get; set; }
        /// <summary>
        /// ["<c>exchangeTxId</c>"] Exchange transaction id
        /// </summary>
        [JsonPropertyName("exchangeTxId")]
        public string ExchangeTransactionId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>userId</c>"] User id
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; } = string.Empty;
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
        /// ["<c>fromAmount</c>"] From quantity
        /// </summary>
        [JsonPropertyName("fromAmount")]
        public decimal FromQuantity { get; set; }
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
        /// ["<c>toAmount</c>"] To quantity
        /// </summary>
        [JsonPropertyName("toAmount")]
        public decimal ToQuantity { get; set; }
        /// <summary>
        /// ["<c>exchangeStatus</c>"] Exchange status
        /// </summary>
        [JsonPropertyName("exchangeStatus")]
        public ConvertTransactionStatus? ExchangeStatus { get; set; }
        /// <summary>
        /// ["<c>convertRate</c>"] Convert rate
        /// </summary>
        [JsonPropertyName("convertRate")]
        public decimal ConvertRate { get; set; }
        /// <summary>
        /// Creation time
        /// </summary>
        [JsonPropertyName("createdAt"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreateTime { get; set; }
    }
}
