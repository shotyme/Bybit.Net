using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Earn order info
    /// </summary>
    [SerializationModel]
    public record BybitEarnOrder
    {
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>orderValue</c>"] Order value
        /// </summary>
        [JsonPropertyName("orderValue")]
        public decimal OrderValue { get; set; }
        /// <summary>
        /// ["<c>orderType</c>"] Earn order type
        /// </summary>
        [JsonPropertyName("orderType")]
        public EarnOrderType OrderType { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>orderLinkId</c>"] Order link id
        /// </summary>
        [JsonPropertyName("orderLinkId")]
        public string OrderLinkId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>status</c>"] Earn status
        /// </summary>
        [JsonPropertyName("status")]
        public EarnOrderStatus Status { get; set; }
        /// <summary>
        /// ["<c>createdAt</c>"] Create time
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// ["<c>productId</c>"] Product id
        /// </summary>
        [JsonPropertyName("productId")]
        public string ProductId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>updatedAt</c>"] Update time
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdateTime { get; set; }
    }


}
