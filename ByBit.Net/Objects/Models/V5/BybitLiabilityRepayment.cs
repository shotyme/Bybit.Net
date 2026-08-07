using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Liability repayment info
    /// </summary>
    [SerializationModel]
    public record BybitLiabilityRepayment
    {
        /// <summary>
        /// ["<c>coin</c>"] Asset name
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>repaymentQty</c>"] Repayment quantity
        /// </summary>
        [JsonPropertyName("repaymentQty")]
        public decimal RepaymentQuantity { get; set; }
    }
}
