using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Margin trading status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<MarginTrading>))]
    public enum MarginTrading
    {
        /// <summary>
        /// ["<c>none</c>"] No margin trading
        /// </summary>
        [Map("none")]
        None,
        /// <summary>
        /// ["<c>both</c>"] Both normal and UTA account supports margin trading
        /// </summary>
        [Map("both")]
        Both,
        /// <summary>
        /// ["<c>utaOnly</c>"] Only UTA account supports margin trading
        /// </summary>
        [Map("utaOnly")]
        UtaOnly,
        /// <summary>
        /// ["<c>normalSpotOnly</c>"] Only normal account support margin trading
        /// </summary>
        [Map("normalSpotOnly")]
        NormalSpotOnly
    }
}
