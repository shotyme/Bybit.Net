using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    [SerializationModel]
    internal record BybitLeverageTokenWrapper
    {
        [JsonPropertyName("list")]
        public BybitLeverageToken[] List { get; set; } = Array.Empty<BybitLeverageToken>();
    }

    /// <summary>
    /// Leverage token info
    /// </summary>
    [SerializationModel]
    public record BybitLeverageToken
    {
        /// <summary>
        /// ["<c>ltCoin</c>"] Token abbreviation
        /// </summary>
        [JsonPropertyName("ltCoin")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>ltName</c>"] Full name
        /// </summary>
        [JsonPropertyName("ltName")]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>minPurchase</c>"] Min order quantity
        /// </summary>
        [JsonPropertyName("minPurchase")]
        public decimal MinOrderQuantity { get; set; }
        /// <summary>
        /// ["<c>maxPurchase</c>"] Max order quantity
        /// </summary>
        [JsonPropertyName("maxPurchase")]
        public decimal MaxOrderQuantity { get; set; }
        /// <summary>
        /// ["<c>maxPurchaseDaily</c>"] Maximum purchase amount in a single day
        /// </summary>
        [JsonPropertyName("maxPurchaseDaily")]
        public decimal MaxDailyBuy { get; set; }
        /// <summary>
        /// ["<c>maxRedeem</c>"] Single Maximum redemption quantity
        /// </summary>
        [JsonPropertyName("maxRedeem")]
        public decimal MaxRedeem { get; set; }
        /// <summary>
        /// ["<c>minRedeem</c>"] Single Minimum redemption quantity
        /// </summary>
        [JsonPropertyName("minRedeem")]
        public decimal MinRedeem { get; set; }
        /// <summary>
        /// ["<c>maxRedeemDaily</c>"] Maximum redeem amount in a single day
        /// </summary>
        [JsonPropertyName("maxRedeemDaily")]
        public decimal MaxRedeemDaily { get; set; }
        /// <summary>
        /// ["<c>purchaseFeeRate</c>"] Purchase fee rate
        /// </summary>
        [JsonPropertyName("purchaseFeeRate")]
        public decimal BuyFeeRate { get; set; }
        /// <summary>
        /// ["<c>redeemFeeRate</c>"] Redeem fee rate
        /// </summary>
        [JsonPropertyName("redeemFeeRate")]
        public decimal RedeemFeeRate { get; set; }
        /// <summary>
        /// ["<c>ltStatus</c>"] Token status
        /// </summary>
        [JsonPropertyName("ltStatus")]
        public LeverageTokenStatus Status { get; set; }
        /// <summary>
        /// ["<c>fundFee</c>"] Funding fee charged daily for users holding leveraged token
        /// </summary>
        [JsonPropertyName("fundFee")]
        public decimal? FundingFee { get; set; }
        /// <summary>
        /// The time to charge funding fee
        /// </summary>
        [JsonPropertyName("fundFeeTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime? FundingFeeTime { get; set; }
        /// <summary>
        /// ["<c>manageFeeRate</c>"] Management fee rate
        /// </summary>
        [JsonPropertyName("manageFeeRate")]
        public decimal ManageFundingFee { get; set; }
        /// <summary>
        /// The time to charge management fee
        /// </summary>
        [JsonPropertyName("manageFeeTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime ManageFundingFeeTime { get; set; }
        /// <summary>
        /// ["<c>value</c>"] Nominal asset value
        /// </summary>
        [JsonPropertyName("value")]
        public decimal Value { get; set; }
        /// <summary>
        /// ["<c>netValue</c>"] Net value
        /// </summary>
        [JsonPropertyName("netValue")]
        public decimal? NetValue { get; set; }
        /// <summary>
        /// ["<c>total</c>"] Total purchase upper limit
        /// </summary>
        [JsonPropertyName("total")]
        public decimal Total { get; set; }
    }
}
