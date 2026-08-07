using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Withdrawal status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<WithdrawalStatus>))]
    public enum WithdrawalStatus
    {
        /// <summary>
        /// ["<c>SecurityCheck</c>"] Security check
        /// </summary>
        [Map("SecurityCheck")]
        SecurityCheck,
        /// <summary>
        /// ["<c>Pending</c>"] Pending
        /// </summary>
        [Map("Pending")]
        Pending,
        /// <summary>
        /// ["<c>success</c>"] Success
        /// </summary>
        [Map("success")]
        Success,
        /// <summary>
        /// ["<c>CancelByUser</c>"] Canceled by user
        /// </summary>
        [Map("CancelByUser")]
        CanceledByUser,
        /// <summary>
        /// ["<c>Reject</c>"] Rejected
        /// </summary>
        [Map("Reject")]
        Rejected,
        /// <summary>
        /// ["<c>Fail</c>"] Failed
        /// </summary>
        [Map("Fail")]
        Failed,
        /// <summary>
        /// ["<c>BlockchainConfirmed</c>"] Blockchain confirmed
        /// </summary>
        [Map("BlockchainConfirmed")]
        BlockchainConfirmed,
        /// <summary>
        /// ["<c>MoreInformationRequired</c>"] More information required
        /// </summary>
        [Map("MoreInformationRequired")]
        MoreInformationRequired
    }
}
