using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Greeks
    /// </summary>
    [SerializationModel]
    public record BybitGreeks
    {
        /// <summary>
        /// ["<c>baseCoin</c>"] Asset
        /// </summary>
        [JsonPropertyName("baseCoin")]
        public string BaseAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>totalDelta</c>"] Delta
        /// </summary>
        [JsonPropertyName("totalDelta")]
        public decimal TotalDelta { get; set; }
        /// <summary>
        /// ["<c>totalGamma</c>"] Gamma
        /// </summary>
        [JsonPropertyName("totalGamma")]
        public decimal TotalGamma { get; set; }
        /// <summary>
        /// ["<c>totalVega</c>"] Vega
        /// </summary>
        [JsonPropertyName("totalVega")]
        public decimal TotalVega { get; set; }
        /// <summary>
        /// ["<c>totalTheta</c>"] Theta
        /// </summary>
        [JsonPropertyName("totalTheta")]
        public decimal TotalTheta { get; set; }
    }
}
