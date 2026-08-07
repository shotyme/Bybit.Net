using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Convert status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<ConvertTransactionStatus>))]
    public enum ConvertTransactionStatus
    {
        /// <summary>
        /// ["<c>init</c>"] Initial
        /// </summary>
        [Map("init")]
        Initial,
        /// <summary>
        /// ["<c>processing</c>"] Processing
        /// </summary>
        [Map("processing")]
        Processing,
        /// <summary>
        /// ["<c>success</c>"] Successful
        /// </summary>
        [Map("success")]
        Success,
        /// <summary>
        /// ["<c>failure</c>"] Failure
        /// </summary>
        [Map("failure")]
        Failed
    }
}
