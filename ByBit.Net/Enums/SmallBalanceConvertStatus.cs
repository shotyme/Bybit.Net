using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Small balance exchange status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SmallBalanceConvertStatus>))]
    public enum SmallBalanceConvertStatus
    {
        /// <summary>
        /// ["<c>init</c>"] Initial
        /// </summary>
        [Map("init")]
        Init,
        /// <summary>
        /// ["<c>processing</c>"] Processing
        /// </summary>
        [Map("processing")]
        Processing,
        /// <summary>
        /// ["<c>success</c>"] Success
        /// </summary>
        [Map("success")]
        Success,
        /// <summary>
        /// ["<c>failure</c>"] Failure
        /// </summary>
        [Map("failure")]
        Failure,
        /// <summary>
        /// ["<c>partial_fulfillment</c>"] Partially filled
        /// </summary>
        [Map("partial_fulfillment")]
        PartiallyFilled
    }
}
