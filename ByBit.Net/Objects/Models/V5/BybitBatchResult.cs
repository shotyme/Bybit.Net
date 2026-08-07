using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Batch item result
    /// </summary>
    [SerializationModel]
    public record BybitBatchResult
    {
        /// <summary>
        /// ["<c>code</c>"] Result code
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }
        /// <summary>
        /// ["<c>msg</c>"] Result message
        /// </summary>
        [JsonPropertyName("msg")]
        public string Message { get; set; } = string.Empty;
    }
    
    /// <summary>
    /// Batch item result
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [SerializationModel]
    public record BybitBatchResult<T> : BybitBatchResult
    {
        /// <summary>
        /// ["<c>data</c>"] Response data
        /// </summary>
        [JsonPropertyName("data")]
        public T? Data { get; set; }
    }
}
