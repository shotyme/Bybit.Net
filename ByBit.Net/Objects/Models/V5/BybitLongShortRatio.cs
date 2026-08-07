using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Long/short ratio
    /// </summary>
    [SerializationModel]
    public record BybitLongShortRatio
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol name
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>buyRatio</c>"] The ratio of users with net long position
        /// </summary>
        [JsonPropertyName("buyRatio")]
        public decimal BuyRatio { get; set; }
        /// <summary>
        /// ["<c>sellRatio</c>"] The ratio of users with net short position
        /// </summary>
        [JsonPropertyName("sellRatio")]
        public decimal SellRatio { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonPropertyName("timestamp"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }
    }
}
