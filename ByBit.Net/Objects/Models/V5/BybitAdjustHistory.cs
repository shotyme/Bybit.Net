using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Adjustment history
    /// </summary>
    [SerializationModel]
    public record BybitAdjustHistory
    {
        /// <summary>
        /// ["<c>adjustId</c>"] Adjust id
        /// </summary>
        [JsonPropertyName("adjustId")]
        public string AdjustId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>adjustTime</c>"] Adjust time
        /// </summary>
        [JsonPropertyName("adjustTime")]
        public DateTime AdjustTime { get; set; }
        /// <summary>
        /// ["<c>afterLTV</c>"] After LTV
        /// </summary>
        [JsonPropertyName("afterLTV")]
        public decimal AfterLtv { get; set; }
        /// <summary>
        /// ["<c>amount</c>"] Quantity
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>collateralCurrency</c>"] Collateral asset
        /// </summary>
        [JsonPropertyName("collateralCurrency")]
        public string CollateralAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>direction</c>"] Adjustment direction
        /// </summary>
        [JsonPropertyName("direction")]
        public AdjustDirection AdjustDirection { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>preLTV</c>"] Pre LTV
        /// </summary>
        [JsonPropertyName("preLTV")]
        public decimal PreLtv { get; set; }
    }


}
