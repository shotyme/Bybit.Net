using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Open interest interval, int value represents the time in seconds
    /// </summary>
    [JsonConverter(typeof(EnumConverter<OpenInterestInterval>))]
    public enum OpenInterestInterval
    {
        /// <summary>
        /// ["<c>5min</c>"] 5
        /// </summary>
        [Map("5min")]
        FiveMinutes = 60 * 5,
        /// <summary>
        /// ["<c>15min</c>"] 15
        /// </summary>
        [Map("15min")]
        FifteenMinutes = 60 * 15,
        /// <summary>
        /// ["<c>30min</c>"] 30
        /// </summary>
        [Map("30min")]
        ThirtyMinutes = 60 * 30,
        /// <summary>
        /// ["<c>1h</c>"] 60
        /// </summary>
        [Map("1h")]
        OneHour = 60 * 60,
        /// <summary>
        /// ["<c>4h</c>"] 240
        /// </summary>
        [Map("4h")]
        FourHours = 60 * 60 * 4,
        /// <summary>
        /// ["<c>1d</c>"] D
        /// </summary>
        [Map("1d")]
        OneDay = 60 * 60 * 24
    }
}
