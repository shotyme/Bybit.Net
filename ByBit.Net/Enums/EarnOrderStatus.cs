using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Earn order status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<EarnOrderStatus>))]
    public enum EarnOrderStatus
    {
        /// <summary>
        /// ["<c>Success</c>"] Success
        /// </summary>
        [Map("Success")]
        Success,
        /// <summary>
        /// ["<c>Fail</c>"] Failed
        /// </summary>
        [Map("Fail")]
        Failed,
        /// <summary>
        /// ["<c>Pending</c>"] Pending
        /// </summary>
        [Map("Pending")]
        Pending
    }
}
