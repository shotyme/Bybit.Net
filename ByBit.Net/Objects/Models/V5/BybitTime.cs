using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Server time info
    /// </summary>
    [SerializationModel]
    public record BybitTime
    {
        /// <summary>
        /// ["<c>timeSecond</c>"] Seconds timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("timeSecond")]
        public DateTime TimeSecond { get; set; }
        /// <summary>
        /// ["<c>timeNano</c>"] Nano seconds timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("timeNano")]
        public DateTime TimeNano { get; set; }
    }
}
