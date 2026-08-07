using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    [SerializationModel]
    internal record BybitAccountTypeInfoWrapper
    {
        [JsonPropertyName("accounts")]
        public BybitAccountTypeInfo[] Accounts { get; set; } = Array.Empty<BybitAccountTypeInfo>();
    }

    /// <summary>
    /// Account type
    /// </summary>
    [SerializationModel]
    public record BybitAccountTypeInfo
    {
        /// <summary>
        /// ["<c>uid</c>"] User id
        /// </summary>
        [JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>accountType</c>"] Account types
        /// </summary>
        [JsonPropertyName("accountType")]
        public string[] AccountTypes { get; set; } = Array.Empty<string>();
    }
}
