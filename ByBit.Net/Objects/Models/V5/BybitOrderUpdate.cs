using Bybit.Net.Enums;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// User order update
    /// </summary>
    [SerializationModel]
    public record BybitOrderUpdate : BybitOrder
    {
        /// <summary>
        /// ["<c>closedPnl</c>"] Closed profit and loss for a close position order.
        /// </summary>
        [JsonPropertyName("closedPnl")]
        public decimal? ClosedPnl { get; set; }

        /// <summary>
        /// ["<c>category</c>"] Category
        /// </summary>

        [JsonPropertyName("category")]
        public Category Category { get; set; }
    }
}
