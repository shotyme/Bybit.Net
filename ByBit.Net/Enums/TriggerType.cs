using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Type of trigger
    /// </summary>
    [JsonConverter(typeof(EnumConverter<TriggerType>))]
    public enum TriggerType
    {
        /// <summary>
        /// ["<c>LastPrice</c>"] Last trade price
        /// </summary>
        [Map("LastPrice")]
        LastPrice,
        /// <summary>
        /// ["<c>IndexPrice</c>"] Index price
        /// </summary>
        [Map("IndexPrice")]
        IndexPrice,
        /// <summary>
        /// ["<c>MarkPrice</c>"] Mark price
        /// </summary>
        [Map("MarkPrice")]
        MarkPrice,
        /// <summary>
        /// ["<c>UNKNOWN</c>"] Unknown
        /// </summary>
        [Map("UNKNOWN", "0")]
        Unknown
    }
}
