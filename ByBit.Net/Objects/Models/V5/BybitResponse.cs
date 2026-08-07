using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Bybit response
    /// </summary>
    [SerializationModel]
    public record BybitBaseResponse
    {
        /// <summary>
        /// ["<c>category</c>"] Category
        /// </summary>

        [JsonPropertyName("category")]
        public Category? Category { get; set; }
        /// <summary>
        /// ["<c>total</c>"] Total items
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
        /// <summary>
        /// ["<c>nextPageCursor</c>"] Cursor for pagination
        /// </summary>
        [JsonPropertyName("nextPageCursor")]
        public string? NextPageCursor { get; set; }
        /// <summary>
        /// ["<c>updatedTime</c>"] Data updated time
        /// </summary>
        [JsonPropertyName("updatedTime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? UpdateTime { get; set; }
    }

    /// <summary>
    /// Bybit response info
    /// </summary>
    /// <typeparam name="T">Type of the response data</typeparam>
    [SerializationModel]
    public record BybitResponse<T> : BybitBaseResponse
    {
        /// <summary>
        /// ["<c>list</c>"] Data list
        /// </summary>
        [JsonPropertyName("list")]
        public T[] List { get; set; } = Array.Empty<T>();

        [JsonInclude]
        [JsonPropertyName("rows")]
        internal T[] Rows
        {
            get => List;
            set => List = value;
        }
    }
}
