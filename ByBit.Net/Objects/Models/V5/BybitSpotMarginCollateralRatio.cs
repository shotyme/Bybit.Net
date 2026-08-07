using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Asset collateral ratio
    /// </summary>
    [SerializationModel]
    public record BybitSpotMarginCollateralRatio
    {
        /// <summary>
        /// ["<c>currency</c>"] Asset
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>collateralRatioList</c>"] Collateral ratios
        /// </summary>
        [JsonPropertyName("collateralRatioList")]
        public BybitSpotMarginCollateralRatioTier[] CollateralRatios { get; set; } = [];
    }

    /// <summary>
    /// Collateral ratio info
    /// </summary>
    [SerializationModel]
    public record BybitSpotMarginCollateralRatioTier
    {
        /// <summary>
        /// ["<c>minQty</c>"] Lower limit of the tiered range
        /// </summary>
        [JsonPropertyName("minQty")]
        public decimal MinQuantity { get; set; }
        /// <summary>
        /// ["<c>maxQty</c>"] Upper limit of the tiered range, null means positive infinity
        /// </summary>
        [JsonPropertyName("maxQty")]
        public decimal? MaxQuantity { get; set; }
        /// <summary>
        /// ["<c>collateralRatio</c>"] Collateral ratio
        /// </summary>
        [JsonPropertyName("collateralRatio")]
        public decimal CollateralRatio { get; set; }
    }
}
