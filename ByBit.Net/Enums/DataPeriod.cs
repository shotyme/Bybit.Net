using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Period
    /// </summary>
    [JsonConverter(typeof(EnumConverter<DataPeriod>))]
    public enum DataPeriod
    {
        /// <summary>
        /// ["<c>5min</c>"] 5min
        /// </summary>
        [Map("5min")]
        FiveMinutes,
        /// <summary>
        /// ["<c>15min</c>"] 15min
        /// </summary>
        [Map("15min")]
        FifteenMinutes,
        /// <summary>
        /// ["<c>30min</c>"] 30min
        /// </summary>
        [Map("30min")]
        ThirtyMinutes,
        /// <summary>
        /// ["<c>1h</c>"] 1h
        /// </summary>
        [Map("1h")]
        OneHour,
        /// <summary>
        /// ["<c>4h</c>"] 4h
        /// </summary>
        [Map("4h")]
        FourHours,
        /// <summary>
        /// ["<c>1d</c>"] 1d
        /// </summary>
        [Map("1d")]
        OneDay
    }
}
