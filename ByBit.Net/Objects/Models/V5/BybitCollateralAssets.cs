using Bybit.Net.Enums;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Collateral asset info
    /// </summary>
    [SerializationModel]
    internal record BybitCollateralAssets
    {
        [JsonPropertyName("vipCoinList")]
        public BybitCollateralAsset[] Assets { get; set; } = [];
    }

    /// <summary>
    /// Collateral asset info
    /// </summary>
    [SerializationModel]
    public record BybitCollateralAsset
    {
        /// <summary>
        /// ["<c>vipLevel</c>"] Account level
        /// </summary>
        [JsonPropertyName("vipLevel")]
        public AccountLevel AccountLevel { get; set; }
        /// <summary>
        /// ["<c>list</c>"] Assets list
        /// </summary>
        [JsonPropertyName("list")]
        public BybitCollateralAssetInfo[] Assets { get; set; } = [];
    }

    /// <summary>
    /// Collateral asset info
    /// </summary>
    [SerializationModel]
    public record BybitCollateralAssetInfo
    {
        /// <summary>
        /// ["<c>collateralAccuracy</c>"] Precision for collateral
        /// </summary>
        [JsonPropertyName("collateralAccuracy")]
        public int CollateralAccuracy { get; set; }
        /// <summary>
        /// ["<c>currency</c>"] Asset name
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>initialLTV</c>"] Initial LTV
        /// </summary>
        [JsonPropertyName("initialLTV")]
        public decimal InitialLtv { get; set; }
        /// <summary>
        /// ["<c>liquidationLTV</c>"] Liquidation LTV
        /// </summary>
        [JsonPropertyName("liquidationLTV")]
        public decimal LiquidationLtv { get; set; }
        /// <summary>
        /// ["<c>marginCallLTV</c>"] Margin call LTV
        /// </summary>
        [JsonPropertyName("marginCallLTV")]
        public decimal MarginCallLtv { get; set; }
        /// <summary>
        /// ["<c>maxLimit</c>"] Max Limit
        /// </summary>
        [JsonPropertyName("maxLimit")]
        public decimal MaxLimit { get; set; }
    }
}
