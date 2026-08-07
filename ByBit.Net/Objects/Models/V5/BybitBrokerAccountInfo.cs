using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Broker account info
    /// </summary>
    [SerializationModel]
    public record BybitBrokerAccountInfo
    {
        /// <summary>
        /// ["<c>subAcctQty</c>"] Current sub account quantity
        /// </summary>
        [JsonPropertyName("subAcctQty")]
        public int SubAccountCount { get; set; }
        /// <summary>
        /// ["<c>maxSubAcctQty</c>"] Max sub account quantity
        /// </summary>
        [JsonPropertyName("maxSubAcctQty")]
        public int MaxSubAccountCount { get; set; }
        /// <summary>
        /// ["<c>ts</c>"] Timestamp
        /// </summary>
        [JsonPropertyName("ts")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>baseFeeRebateRate</c>"] Base fee rebate rates
        /// </summary>
        [JsonPropertyName("baseFeeRebateRate")]
        public BybitBrokerRebateRate BaseFeeRebateRates { get; set; } = null!;
        /// <summary>
        /// ["<c>markupFeeRebateRate</c>"] Markup fee rebate rates
        /// </summary>
        [JsonPropertyName("markupFeeRebateRate")]
        public BybitBrokerRebateRate MarkupFeeRebateRates { get; set; } = null!;
    }

    /// <summary>
    /// Rebate rate info
    /// </summary>
    [SerializationModel]
    public record BybitBrokerRebateRate
    {
        /// <summary>
        /// ["<c>spot</c>"] Spot rebate rate
        /// </summary>
        [JsonPropertyName("spot")]
        public string Spot { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>derivatives</c>"] Derivatives rebate rate
        /// </summary>
        [JsonPropertyName("derivatives")]
        public string Derivatives { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>convert</c>"] Convert rebate rate
        /// </summary>
        [JsonPropertyName("convert")]
        public string? Convert { get; set; }
    }
}
