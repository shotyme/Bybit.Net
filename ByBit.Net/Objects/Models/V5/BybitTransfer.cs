using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Transfer info
    /// </summary>
    [SerializationModel]
    public record BybitTransfer
    {
        /// <summary>
        /// ["<c>transferId</c>"] Transfer id
        /// </summary>
        [JsonPropertyName("transferId")]
        public string TransferId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>amount</c>"] Quantity
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>fromAccountType</c>"] From account
        /// </summary>

        [JsonPropertyName("fromAccountType")]
        public AccountType FromAccountType { get; set; }
        /// <summary>
        /// ["<c>toAccountType</c>"] To account
        /// </summary>

        [JsonPropertyName("toAccountType")]
        public AccountType ToAccountType { get; set; }
        /// <summary>
        /// ["<c>timestamp</c>"] Timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>status</c>"] Status
        /// </summary>

        [JsonPropertyName("status")]
        public TransferStatus Status { get; set; }
        /// <summary>
        /// ["<c>fromMemberId</c>"] [UniversalTransfer] From member id
        /// </summary>
        [JsonPropertyName("fromMemberId")]
        public string? FromMemberId { get; set; }
        /// <summary>
        /// ["<c>toMemberId</c>"] [UniversalTransfer] To member id
        /// </summary>
        [JsonPropertyName("toMemberId")]
        public string? ToMemberId { get; set; }
    }
}
