using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Earn order type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<EarnOrderType>))]
    public enum EarnOrderType
    {
        /// <summary>
        /// ["<c>Stake</c>"] Stake
        /// </summary>
        [Map("Stake")]
        Stake,
        /// <summary>
        /// ["<c>Redeem</c>"] Redeem
        /// </summary>
        [Map("Redeem")]
        Redeem
    }
}
