using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Account info
    /// </summary>
    [SerializationModel]
    public record BybitAccountInfo
    {
        /// <summary>
        /// ["<c>unifiedMarginStatus</c>"] Unified margin status
        /// </summary>

        [JsonPropertyName("unifiedMarginStatus")]
        public UnifiedMarginStatus UnifiedMarginStatus { get; set; }
        /// <summary>
        /// ["<c>marginMode</c>"] Margin info
        /// </summary>

        [JsonPropertyName("marginMode")]
        public MarginMode MarginMode { get; set; }
        /// <summary>
        /// ["<c>updatedTime</c>"] Update time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("updatedTime")]
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// ["<c>dcpStatus</c>"] Disconnect-CancelAll-Prevention status
        /// </summary>
        [JsonPropertyName("dcpStatus")]
        public string DcpStatus { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>smpGroup</c>"] Smp group id
        /// </summary>
        [JsonPropertyName("smpGroup")]
        public int SmpGroup { get; set; }
        /// <summary>
        /// ["<c>timeWindow</c>"] Dcp trigger time
        /// </summary>
        [JsonPropertyName("timeWindow")]
        public int DcpTimeWindow { get; set; }
        /// <summary>
        /// ["<c>isMasterTrader</c>"] Whether the account is a master trader (copytrading)
        /// </summary>
        [JsonPropertyName("isMasterTrader")]
        public bool IsMasterTrader { get; set; }
        /// <summary>
        /// ["<c>spotHedgingStatus</c>"] Whether the unified account enables Spot hedging
        /// </summary>
        [JsonPropertyName("spotHedgingStatus")]
        [JsonConverter(typeof(BoolConverter))]
        public bool SpotHedgingStatus { get; set; }
    }
}
