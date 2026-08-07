using Bybit.Net.Enums;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Set risk limit info
    /// </summary>
    [SerializationModel]
    public record BybitSetRiskLimit
    {
        /// <summary>
        /// ["<c>riskId</c>"] The risk id
        /// </summary>
        [JsonPropertyName("riskId")]
        public int RiskId { get; set; }
        /// <summary>
        /// ["<c>riskLimitValue</c>"] Risk limit value
        /// </summary>
        [JsonPropertyName("riskLimitValue")]
        public decimal RiskLimitValue { get; set; }
        /// <summary>
        /// ["<c>category</c>"] Category
        /// </summary>

        [JsonPropertyName("category")]
        public Category Category { get; set; }
    }
}
