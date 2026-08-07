using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// PreCheck order result
    /// </summary>
    public record BybitPreCheckResult
    {
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>orderLinkId</c>"] Client order id
        /// </summary>
        [JsonPropertyName("orderLinkId")]
        public string? ClientOrderId { get; set; }
        /// <summary>
        /// ["<c>preImrE4</c>"] Initial margin rate before checking, keep four decimal places. For examples, 30 means IMR = 30/1e4 = 0.30%
        /// </summary>
        [JsonPropertyName("preImrE4")]
        public decimal InitialMarginRatePreCheck { get; set; }
        /// <summary>
        /// ["<c>preMmrE4</c>"] Maintenance margin rate before checking, keep four decimal places. For examples, 30 means MMR = 30/1e4 = 0.30%
        /// </summary>
        [JsonPropertyName("preMmrE4")]
        public decimal MaintenanceMarginRatePreCheck { get; set; }
        /// <summary>
        /// ["<c>postImrE4</c>"] Initial margin rate calculated after checking, keep four decimal places. For examples, 30 means IMR = 30/1e4 = 0.30%
        /// </summary>
        [JsonPropertyName("postImrE4")]
        public decimal InitialMarginRatePostCheck { get; set; }
        /// <summary>
        /// ["<c>postMmrE4</c>"] Maintenance margin rate calculated after checking, keep four decimal places. For examples, 30 means MMR = 30/1e4 = 0.30%
        /// </summary>
        [JsonPropertyName("postMmrE4")]
        public decimal MaintenanceMarginRatePostCheck { get; set; }
    }


}
