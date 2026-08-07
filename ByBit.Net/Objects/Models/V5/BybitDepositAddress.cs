using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Deposit address info
    /// </summary>
    [SerializationModel]
    public record BybitDepositAddress
    {
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>chains</c>"] Networks
        /// </summary>
        [JsonPropertyName("chains")]
        public BybitDepositChainAddress[] Networks { get; set; } = Array.Empty<BybitDepositChainAddress>();
    }

    /// <summary>
    /// Deposit address
    /// </summary>
    [SerializationModel]
    public record BybitDepositChainAddress
    {
        /// <summary>
        /// ["<c>chainType</c>"] Network type
        /// </summary>
        [JsonPropertyName("chainType")]
        public string NetworkType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>addressDeposit</c>"] Deposit address
        /// </summary>
        [JsonPropertyName("addressDeposit")]
        public string DepositAddress { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>tagDeposit</c>"] Deposit tag
        /// </summary>
        [JsonPropertyName("tagDeposit")]
        public string DepositTag { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>chain</c>"] Network
        /// </summary>
        [JsonPropertyName("chain")]
        public string Network { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>batchReleaseLimit</c>"] Deposit limit. -1 if there is no limit.
        /// </summary>
        [JsonPropertyName("batchReleaseLimit")]
        public decimal DepositLimit { get; set; }
        /// <summary>
        /// ["<c>contractAddress</c>"] Network contract asset, only last 6 characters
        /// </summary>
        [JsonPropertyName("contractAddress")]
        public string ContractAddress { get; set; } = string.Empty;
    }
}
