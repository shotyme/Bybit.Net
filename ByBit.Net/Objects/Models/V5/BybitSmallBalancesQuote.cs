using Bybit.Net.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Small balances quote
    /// </summary>
    public record BybitSmallBalancesQuote
    {
        /// <summary>
        /// ["<c>quoteId</c>"] Quote id
        /// </summary>
        [JsonPropertyName("quoteId")]
        public string QuoteId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>result</c>"] Quote info
        /// </summary>
        [JsonPropertyName("result")]
        public BybitSmallBalancesQuoteInfo Result { get; set; } = null!;
    }

    /// <summary>
    /// Quote info
    /// </summary>
    public record BybitSmallBalancesQuoteInfo
    {
        /// <summary>
        /// ["<c>quoteCreateTime</c>"] Create time
        /// </summary>
        [JsonPropertyName("quoteCreateTime")]
        public DateTime QuoteCreateTime { get; set; }
        /// <summary>
        /// ["<c>quoteExpireTime</c>"] Expire time
        /// </summary>
        [JsonPropertyName("quoteExpireTime")]
        public DateTime QuoteExpireTime { get; set; }
        /// <summary>
        /// ["<c>exchangeCoins</c>"] Exchange assets
        /// </summary>
        [JsonPropertyName("exchangeCoins")]
        public BybitSmallBalancesQuoteAsset[] ExchangeAssets { get; set; } = [];
        /// <summary>
        /// ["<c>totalFeeInfo</c>"] Fee info
        /// </summary>
        [JsonPropertyName("totalFeeInfo")]
        public BybitSmallBalancesQuoteFee TotalFee { get; set; } = null!;
        /// <summary>
        /// ["<c>totalTaxFeeInfo</c>"] Tax fee info
        /// </summary>
        [JsonPropertyName("totalTaxFeeInfo")]
        public BybitSmallBalancesQuoteTaxFee TotalTaxFee { get; set; } = null!;
    }

    /// <summary>
    /// Fee info
    /// </summary>
    public record BybitSmallBalancesQuoteFee
    {
        /// <summary>
        /// ["<c>feeCoin</c>"] Fee asset
        /// </summary>
        [JsonPropertyName("feeCoin")]
        public string FeeAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>amount</c>"] Quantity
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>feeRate</c>"] Fee rate
        /// </summary>
        [JsonPropertyName("feeRate")]
        public decimal FeeRate { get; set; }
    }

    /// <summary>
    /// Tax fee info
    /// </summary>
    public record BybitSmallBalancesQuoteTaxFee
    {
        /// <summary>
        /// ["<c>totalAmount</c>"] Total quantity
        /// </summary>
        [JsonPropertyName("totalAmount")]
        public decimal TotalQuantity { get; set; }
        /// <summary>
        /// ["<c>feeCoin</c>"] Fee asset
        /// </summary>
        [JsonPropertyName("feeCoin")]
        public string FeeAsset { get; set; } = string.Empty;
    }

    /// <summary>
    /// Asset info
    /// </summary>
    public record BybitSmallBalancesQuoteAsset
    {
        /// <summary>
        /// ["<c>fromCoin</c>"] From asset
        /// </summary>
        [JsonPropertyName("fromCoin")]
        public string FromAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>toCoin</c>"] To asset
        /// </summary>
        [JsonPropertyName("toCoin")]
        public string ToAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>availableBalance</c>"] Available balance
        /// </summary>
        [JsonPropertyName("availableBalance")]
        public decimal AvailableBalance { get; set; }
        /// <summary>
        /// ["<c>baseValue</c>"] USDT value
        /// </summary>
        [JsonPropertyName("baseValue")]
        public decimal BaseValue { get; set; }
        /// <summary>
        /// ["<c>supportConvert</c>"] Conversion is supported
        /// </summary>
        [JsonConverter(typeof(Bool12Converter))]
        [JsonPropertyName("supportConvert")]
        public bool Supported { get; set; }
        /// <summary>
        /// ["<c>toAmount</c>"] Output quantity
        /// </summary>
        [JsonPropertyName("toAmount")]
        public decimal ToQuantity { get; set; }
        /// <summary>
        /// ["<c>exchangeRate</c>"] Exchange rate
        /// </summary>
        [JsonPropertyName("exchangeRate")]
        public decimal ExchangeRate { get; set; }
        /// <summary>
        /// ["<c>feeInfo</c>"] Fee info
        /// </summary>
        [JsonPropertyName("feeInfo")]
        public BybitSmallBalancesQuoteFee Fee { get; set; } = null!;
        /// <summary>
        /// ["<c>taxFeeInfo</c>"] Tax fee info
        /// </summary>
        [JsonPropertyName("taxFeeInfo")]
        public BybitSmallBalancesQuoteTaxFee TaxFee { get; set; } = null!;
    }
}
