using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Staked Earn position
    /// </summary>
    [SerializationModel]
    public record BybitEarnStakedPosition
    {
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>productId</c>"] Product id
        /// </summary>
        [JsonPropertyName("productId")]
        public string ProductId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>amount</c>"] Quantity
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>totalPnl</c>"] Total pnl
        /// </summary>
        [JsonPropertyName("totalPnl")]
        public decimal TotalPnl { get; set; }
        /// <summary>
        /// ["<c>claimableYield</c>"] Claimable yield
        /// </summary>
        [JsonPropertyName("claimableYield")]
        public decimal ClaimableYield { get; set; }
    }


}
