using CryptoExchange.Net.Attributes;
using System.Text.Json.Serialization;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Tolerance type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SlippageToleranceType>))]
    public enum SlippageToleranceType
    {
        /// <summary>
        /// ["<c>TickSize</c>"] Tick size, the best price at the moment + (slippageTolerance * tickSize)
        /// </summary>
        [Map("TickSize")]
        TickSize,
        /// <summary>
        /// ["<c>Percent</c>"] Percentage
        /// </summary>
        [Map("Percent")]
        Percentage,
        /// <summary>
        /// ["<c>UNKNOWN</c>"] Unknown
        /// </summary>
        [Map("UNKNOWN")]
        Unknown
    }
}
