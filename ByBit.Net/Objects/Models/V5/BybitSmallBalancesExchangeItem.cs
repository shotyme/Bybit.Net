using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Small balances exchange item
    /// </summary>
    public record BybitSmallBalancesExchangeItem
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
        /// ["<c>toCoin</c>"] Output asset
        /// </summary>
        [JsonPropertyName("toCoin")]
        public string ToAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>toAmount</c>"] Output quantity
        /// </summary>
        [JsonPropertyName("toAmount")]
        public decimal ToQuantity { get; set; }
        /// <summary>
        /// ["<c>status</c>"] Status
        /// </summary>
        [JsonPropertyName("status")]
        public SmallBalanceConvertStatus Status { get; set; }
        /// <summary>
        /// ["<c>createdAt</c>"] Create time
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// ["<c>exchangeSource</c>"] Source
        /// </summary>
        [JsonPropertyName("exchangeSource")]
        public string ExchangeSource { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>feeCoin</c>"] Fee asset
        /// </summary>
        [JsonPropertyName("feeCoin")]
        public string FeeAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>totalFeeAmount</c>"] Total fee quantity
        /// </summary>
        [JsonPropertyName("totalFeeAmount")]
        public decimal TotalFeeQuantity { get; set; }
        /// <summary>
        /// ["<c>totalTaxFeeInfo</c>"] Total tax fee
        /// </summary>
        [JsonPropertyName("totalTaxFeeInfo")]
        public BybitSmallBalancesQuoteTaxFee TotalTaxFee { get; set; } = null!;
        /// <summary>
        /// ["<c>subRecords</c>"] Sub records
        /// </summary>
        [JsonPropertyName("subRecords")]
        public BybitSmallBalancesExchangeSubRecord[] Records { get; set; } = [];
    }

    /// <summary>
    /// Exchange sub record
    /// </summary>
    public record BybitSmallBalancesExchangeSubRecord
    {
        /// <summary>
        /// ["<c>fromCoin</c>"] From asset
        /// </summary>
        [JsonPropertyName("fromCoin")]
        public string FromAsset { get; set; } = string.Empty;
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
        /// ["<c>toAmount</c>"] To quantity
        /// </summary>
        [JsonPropertyName("toAmount")]
        public decimal ToQuantity { get; set; }
        /// <summary>
        /// ["<c>feeCoin</c>"] Fee asset
        /// </summary>
        [JsonPropertyName("feeCoin")]
        public string FeeAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>feeAmount</c>"] Fee quantity
        /// </summary>
        [JsonPropertyName("feeAmount")]
        public decimal FeeQuantity { get; set; }
        /// <summary>
        /// ["<c>status</c>"] Status
        /// </summary>
        [JsonPropertyName("status")]
        public SmallBalanceConvertStatus Status { get; set; }
        /// <summary>
        /// ["<c>taxFeeInfo</c>"] Tax fee info
        /// </summary>
        [JsonPropertyName("taxFeeInfo")]
        public BybitSmallBalancesQuoteTaxFee TaxFee { get; set; } = null!;
    }
}
