using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    [SerializationModel]
    internal record BybitBorrowAssetWrapper
    {
        /// <summary>
        /// ["<c>vipCoinList</c>"] Vip asset list
        /// </summary>
        [JsonPropertyName("vipCoinList")]
        public BybitBorrowAsset[] VipAssetList { get; set; } = Array.Empty<BybitBorrowAsset>();
    }

    /// <summary>
    /// 
    /// </summary>
    [SerializationModel]
    public record BybitBorrowAsset
    {
        /// <summary>
        /// ["<c>list</c>"] Assets
        /// </summary>
        [JsonPropertyName("list")]
        public BybitBorrowAssetInfo[] Assets { get; set; } = Array.Empty<BybitBorrowAssetInfo>();
        /// <summary>
        /// ["<c>vipLevel</c>"] Vip level
        /// </summary>
        [JsonPropertyName("vipLevel")]
        public AccountLevel AccountLevel { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [SerializationModel]
    public record BybitBorrowAssetInfo
    {
        /// <summary>
        /// ["<c>borrowingAccuracy</c>"] Borrowing accuracy
        /// </summary>
        [JsonPropertyName("borrowingAccuracy")]
        public int BorrowingAccuracy { get; set; }
        /// <summary>
        /// ["<c>currency</c>"] Asset
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>flexibleHourlyInterestRate</c>"] Flexible hourly interest rate
        /// </summary>
        [JsonPropertyName("flexibleHourlyInterestRate")]
        public decimal? FlexibleHourlyInterestRate { get; set; }
        /// <summary>
        /// ["<c>hourlyInterestRate14D</c>"] Hourly interest rate14 d
        /// </summary>
        [JsonPropertyName("hourlyInterestRate14D")]
        public decimal? HourlyInterestRate14D { get; set; }
        /// <summary>
        /// ["<c>hourlyInterestRate180D</c>"] Hourly interest rate180 d
        /// </summary>
        [JsonPropertyName("hourlyInterestRate180D")]
        public decimal? HourlyInterestRate180D { get; set; }
        /// <summary>
        /// ["<c>hourlyInterestRate30D</c>"] Hourly interest rate30 d
        /// </summary>
        [JsonPropertyName("hourlyInterestRate30D")]
        public decimal? HourlyInterestRate30D { get; set; }
        /// <summary>
        /// ["<c>hourlyInterestRate7D</c>"] Hourly interest rate7 d
        /// </summary>
        [JsonPropertyName("hourlyInterestRate7D")]
        public decimal? HourlyInterestRate7D { get; set; }
        /// <summary>
        /// ["<c>hourlyInterestRate90D</c>"] Hourly interest rate90 d
        /// </summary>
        [JsonPropertyName("hourlyInterestRate90D")]
        public decimal? HourlyInterestRate90D { get; set; }
        /// <summary>
        /// ["<c>maxBorrowingAmount</c>"] Max borrowing quantity
        /// </summary>
        [JsonPropertyName("maxBorrowingAmount")]
        public decimal MaxBorrowingQuantity { get; set; }
        /// <summary>
        /// ["<c>minBorrowingAmount</c>"] Min borrowing quantity
        /// </summary>
        [JsonPropertyName("minBorrowingAmount")]
        public decimal MinBorrowingQuantity { get; set; }
    }


}
