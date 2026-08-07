using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Internal deposit status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<InternalDepositStatus>))]
    public enum InternalDepositStatus
    {
        /// <summary>
        /// ["<c>1</c>"] Processing
        /// </summary>
        [Map("1")]
        Processing,
        /// <summary>
        /// ["<c>2</c>"] Success
        /// </summary>
        [Map("2")]
        Success,
        /// <summary>
        /// ["<c>3</c>"] Failed
        /// </summary>
        [Map("3")]
        Failed
    }
}
