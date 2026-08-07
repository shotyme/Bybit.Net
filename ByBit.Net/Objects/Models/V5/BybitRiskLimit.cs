using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Risk limit info
    /// </summary>
    [SerializationModel]
    public record BybitRiskLimit
    {
        /// <summary>
        /// ["<c>id</c>"] Risk limit id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>riskLimitValue</c>"] Risk limit value
        /// </summary>
        [JsonPropertyName("riskLimitValue")]
        public decimal RiskLimitValue { get; set; }
        /// <summary>
        /// ["<c>maintenanceMargin</c>"] Maintenance margin
        /// </summary>
        [JsonPropertyName("maintenanceMargin")]
        public decimal MaintenanceMargin { get; set; }
        /// <summary>
        /// ["<c>initialMargin</c>"] Initial margin
        /// </summary>
        [JsonPropertyName("initialMargin")]
        public decimal InitialMargin { get; set; }
        /// <summary>
        /// ["<c>isLowestRisk</c>"] Is lowest risk
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        [JsonPropertyName("isLowestRisk")]
        public bool IsLowestRisk { get; set; }
        /// <summary>
        /// ["<c>maxLeverage</c>"] Max leverage
        /// </summary>
        [JsonPropertyName("maxLeverage")]
        public decimal MaxLeverage { get; set; }

        /// <summary>
        /// ["<c>mmDeduction</c>"] Maintenance Margin Deduction
        /// </summary>
        [JsonPropertyName("mmDeduction")]
        public decimal? MaintenanceMarginDeduction { get; set; }
    }
}
