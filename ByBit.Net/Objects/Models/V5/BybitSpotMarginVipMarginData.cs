using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Margin data
    /// </summary>
    [SerializationModel]
    internal record BybitSpotMarginVipMarginData
    {
        [JsonPropertyName("vipCoinList")]
        public BybitSpotMarginVipMarginList[] VipCoinList { get; set; } = null!;
    }

    /// <summary>
    /// Margin data
    /// </summary>
    [SerializationModel]
    public record BybitSpotMarginVipMarginList
    {
        /// <summary>
        /// ["<c>vipLevel</c>"] VIP level
        /// </summary>
        [JsonPropertyName("vipLevel")]
        public string VipLevel { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>list</c>"] Assets
        /// </summary>
        [JsonPropertyName("list")]
        public BybitSpotMarginVipMarginItem[] Assets { get; set; } = Array.Empty<BybitSpotMarginVipMarginItem>();
    }

    /// <summary>
    /// Margin item
    /// </summary>
    [SerializationModel]
    public record BybitSpotMarginVipMarginItem
    {
        /// <summary>
        /// ["<c>borrowable</c>"] Whether the asset is allowed to be borrowed
        /// </summary>
        [JsonPropertyName("borrowable")]
        public bool Borrowable { get; set; }
        /// <summary>
        /// ["<c>collateralRatio</c>"] Collateral ratio
        /// </summary>
        [JsonPropertyName("collateralRatio")]
        public decimal Collateralratio { get; set; }
        /// <summary>
        /// ["<c>currency</c>"] Asset
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>hourlyBorrowRate</c>"] Borrow interest rate per hour
        /// </summary>
        [JsonPropertyName("hourlyBorrowRate")]
        public decimal? HourlyBorrowRate { get; set; }
        /// <summary>
        /// ["<c>liquidationOrder</c>"] Liquidation order
        /// </summary>
        [JsonPropertyName("liquidationOrder")]
        public decimal LiquidationOrder { get; set; }
        /// <summary>
        /// ["<c>marginCollateral</c>"] Whether it can be used as a margin collateral asset
        /// </summary>
        [JsonPropertyName("marginCollateral")]
        public bool MarginCollateral { get; set; }
        /// <summary>
        /// ["<c>maxBorrowingAmount</c>"] Max borrow amount
        /// </summary>
        [JsonPropertyName("maxBorrowingAmount")]
        public decimal? MaxBorrowingQuantity { get; set; }
    }
}
