using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Allowed deposit response
    /// </summary>
    [SerializationModel]
    public record BybitAllowedDepositInfoResponse : BybitBaseResponse
    {
        /// <summary>
        /// ["<c>configList</c>"] Asset list
        /// </summary>
        [JsonPropertyName("configList")]
        public BybitAllowedDepositInfo[] Assets { get; set; } = Array.Empty<BybitAllowedDepositInfo>();
    }

    /// <summary>
    /// Deposit info
    /// </summary>
    [SerializationModel]
    public record BybitAllowedDepositInfo
    {
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>chain</c>"] Network
        /// </summary>
        [JsonPropertyName("chain")]
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>coinShowName</c>"] Display name
        /// </summary>
        [JsonPropertyName("coinShowName")]
        public string AssetShowName { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>chainType</c>"] Network type
        /// </summary>
        [JsonPropertyName("chainType")]
        public string NetworkType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>blockConfirmNumber</c>"] Deposit confirmation number
        /// </summary>
        [JsonPropertyName("blockConfirmNumber")]
        public int BlockConfirmNumber { get; set; }
        /// <summary>
        /// ["<c>minDepositAmount</c>"] Min deposit amount
        /// </summary>
        [JsonPropertyName("minDepositAmount")]
        public decimal MinDepositAmount { get; set; }
    }
}
