using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Announcmeent
    /// </summary>
    [SerializationModel]
    public record BybitAnnouncement
    {
        /// <summary>
        /// ["<c>title</c>"] Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>description</c>"] Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>url</c>"] Url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>dateTimestamp</c>"] Announcement time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("dateTimestamp")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>publishTime</c>"] Publish time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("publishTime")]
        public DateTime? PublishTime { get; set; }
        /// <summary>
        /// ["<c>startDateTimestamp</c>"] Start time of the announcement
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("startDateTimestamp")]
        public DateTime? StartTimestamp { get; set; }
        /// <summary>
        /// ["<c>endDateTimestamp</c>"] End time of the announcement
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("endDateTimestamp")]
        public DateTime? EndTimestamp { get; set; }
        /// <summary>
        /// ["<c>tags</c>"] Tags
        /// </summary>
        [JsonPropertyName("tags")]
        public string[] Tags { get; set; } = Array.Empty<string>();
        /// <summary>
        /// ["<c>type</c>"] Type
        /// </summary>
        [JsonPropertyName("type")]
        public Dictionary<string, string> Type { get; set; } = new Dictionary<string, string>();
    }
}
