using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Asset balances
    /// </summary>
    [SerializationModel]
    public record BybitAllAssetBalances
    {
        /// <summary>
        /// ["<c>accountType</c>"] Account type
        /// </summary>
        [JsonPropertyName("accountType")]
        public AccountType AccountType { get; set; }
        /// <summary>
        /// ["<c>memberId</c>"] Member id
        /// </summary>
        [JsonPropertyName("memberId")]
        public string? MemberId { get; set; }
        /// <summary>
        /// ["<c>balance</c>"] Balances
        /// </summary>
        [JsonPropertyName("balance")]
        public BybitAssetAccountBalance[] Balances { get; set; } = Array.Empty<BybitAssetAccountBalance>();
    }

    /// <summary>
    /// Asset balances
    /// </summary>
    [SerializationModel]
    public record BybitSingleAssetBalance
    {
        /// <summary>
        /// ["<c>accountType</c>"] Account type
        /// </summary>
        [JsonPropertyName("accountType")]
        public AccountType AccountType { get; set; }
        /// <summary>
        /// ["<c>memberId</c>"] Member id
        /// </summary>
        [JsonPropertyName("memberId")]
        public string? MemberId { get; set; }
        /// <summary>
        /// ["<c>balance</c>"] Balances
        /// </summary>
        [JsonPropertyName("balance")]
        public BybitAssetAccountBalance Balances { get; set; } = null!;
    }

    /// <summary>
    /// Account asset balance
    /// </summary>
    [SerializationModel]
    public record BybitAssetAccountBalance
    {
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>walletBalance</c>"] Wallet balance
        /// </summary>
        [JsonPropertyName("walletBalance")]
        public decimal? WalletBalance { get; set; }
        /// <summary>
        /// ["<c>transferBalance</c>"] Transfer balance
        /// </summary>
        [JsonPropertyName("transferBalance")]
        public decimal TransferBalance { get; set; }
        /// <summary>
        /// ["<c>bonus</c>"] Bonus
        /// </summary>
        [JsonPropertyName("bonus")]
        public decimal? Bonus { get; set; }
    }
}
