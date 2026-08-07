using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Repayment status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<RepayStatus>))]
    public enum RepayStatus
    {
        /// <summary>
        /// ["<c>1</c>"] Success
        /// </summary>
        [Map("1")]
        Success,
        /// <summary>
        /// ["<c>2</c>"] Processing
        /// </summary>
        [Map("2")]
        Processing
    }
}
