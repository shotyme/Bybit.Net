using Bybit.Net.Enums;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Product info
    /// </summary>
    [SerializationModel]
    public record BybitEarnProduct
    {
        /// <summary>
        /// ["<c>category</c>"] Earn category
        /// </summary>
        [JsonPropertyName("category")]
        public EarnCategory Category { get; set; }
        /// <summary>
        /// ["<c>estimateApr</c>"] Estimate APR
        /// </summary>
        [JsonPropertyName("estimateApr")]
        public string EstimateApr { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>minStakeAmount</c>"] Min stake quantity
        /// </summary>
        [JsonPropertyName("minStakeAmount")]
        public decimal MinStakeQuantity { get; set; }
        /// <summary>
        /// ["<c>maxStakeAmount</c>"] Max stake quantity
        /// </summary>
        [JsonPropertyName("maxStakeAmount")]
        public decimal MaxStakeQuantity { get; set; }
        /// <summary>
        /// ["<c>precision</c>"] Precision
        /// </summary>
        [JsonPropertyName("precision")]
        public int Precision { get; set; }
        /// <summary>
        /// ["<c>productId</c>"] Product id
        /// </summary>
        [JsonPropertyName("productId")]
        public string ProductId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>status</c>"] Earn product status
        /// </summary>
        [JsonPropertyName("status")]
        public EarnProductStatus Status { get; set; }
    }


}
