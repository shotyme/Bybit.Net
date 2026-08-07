using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Withdrawal type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<WithdrawalType>))]
    public enum WithdrawalType
    {
        /// <summary>
        /// ["<c>0</c>"] On chain
        /// </summary>
        [Map("0")]
        OnChain,
        /// <summary>
        /// ["<c>1</c>"] Off chain
        /// </summary>
        [Map("1")]
        OffChain,
        /// <summary>
        /// ["<c>2</c>"] Both
        /// </summary>
        [Map("2")]
        Both
    }
}
