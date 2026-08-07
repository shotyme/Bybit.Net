using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Set Margin Mode result
    /// </summary>
    [SerializationModel]
    public record BybitSetMarginModeResult
    {
        /// <summary>
        /// ["<c>reasons</c>"] Failure reasons. If empty it was successful
        /// </summary>
        [JsonPropertyName("reasons")]
        public BybitReason[] Reasons { get; set; } = Array.Empty<BybitReason>();
    }

    /// <summary>
    /// Reason
    /// </summary>
    [SerializationModel]
    public record BybitReason
    {
        /// <summary>
        /// ["<c>reasonCode</c>"] Reason code
        /// </summary>
        [JsonPropertyName("reasonCode")]
        public string ReasonCode { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>reasonMsg</c>"] Reason message
        /// </summary>
        [JsonPropertyName("reasonMsg")]
        public string ReasonMessage { get; set; } = string.Empty;
    }
}
