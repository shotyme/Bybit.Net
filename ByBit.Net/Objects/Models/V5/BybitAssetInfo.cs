using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    [SerializationModel]
    internal record BybitAssetInfoWrapper
    {
        [JsonPropertyName("spot")]
        public BybitAccountAssetInfo Spot { get; set; } = null!;
    }

    /// <summary>
    /// Account asset info
    /// </summary>
    [SerializationModel]
    public record BybitAccountAssetInfo
    {
        /// <summary>
        /// ["<c>status</c>"] Account status
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>assets</c>"] Assdet info
        /// </summary>
        [JsonPropertyName("assets")]
        public BybitAssetInfo[] Assets { get; set; } = Array.Empty<BybitAssetInfo>();
    }

    /// <summary>
    /// Asset info
    /// </summary>
    [SerializationModel]
    public record BybitAssetInfo
    {
        /// <summary>
        /// ["<c>coin</c>"] Asset name
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>frozen</c>"] Frozen amount
        /// </summary>
        [JsonPropertyName("frozen")]
        public decimal Frozen { get; set; }
        /// <summary>
        /// ["<c>free</c>"] Free amount
        /// </summary>
        [JsonPropertyName("free")]
        public decimal Free { get; set; }
        /// <summary>
        /// ["<c>withdraw</c>"] Amount in withdrawing
        /// </summary>
        [JsonPropertyName("withdraw")]
        public decimal? Withdrawing { get; set; }
    }
}
