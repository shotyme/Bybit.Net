using Bybit.Net.Enums;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    [SerializationModel]
    internal record BybitSubAccountWrapper
    {
        [JsonPropertyName("subMembers")]
        public BybitSubAccount[] SubMembers { get; set; } = [];
    }

    /// <summary>
    /// Sub account info
    /// </summary>
    [SerializationModel]
    public record BybitSubAccount
    {
        /// <summary>
        /// ["<c>uid</c>"] User id
        /// </summary>
        [JsonPropertyName("uid")]
        public string UserId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>username</c>"] Username
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>memberType</c>"] Account type
        /// </summary>
        [JsonPropertyName("memberType")]
        public SubAccountType AccountType { get; set; }
        /// <summary>
        /// ["<c>status</c>"] Account status
        /// </summary>
        [JsonPropertyName("status")]
        public SubAccountStatus Status { get; set; }
        /// <summary>
        /// ["<c>accountMode</c>"] Account mode
        /// </summary>
        [JsonPropertyName("accountMode")]
        public AccountMode? AccountMode { get; set; }
        /// <summary>
        /// ["<c>remark</c>"] Remark
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
