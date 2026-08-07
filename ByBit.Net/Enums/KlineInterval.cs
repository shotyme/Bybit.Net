using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Kline interval, int value represents the time in seconds
    /// </summary>
    [JsonConverter(typeof(EnumConverter<KlineInterval>))]
    public enum KlineInterval
    {
        /// <summary>
        /// ["<c>1</c>"] 1
        /// </summary>
        [Map("1", "1m")]
        OneMinute = 60,
        /// <summary>
        /// ["<c>3</c>"] 3
        /// </summary>
        [Map("3", "3m")]
        ThreeMinutes = 60 * 3,
        /// <summary>
        /// ["<c>5</c>"] 5
        /// </summary>
        [Map("5", "5m")]
        FiveMinutes = 60 * 5,
        /// <summary>
        /// ["<c>15</c>"] 15
        /// </summary>
        [Map("15", "15m")]
        FifteenMinutes = 60 * 15,
        /// <summary>
        /// ["<c>30</c>"] 30
        /// </summary>
        [Map("30", "30m")]
        ThirtyMinutes = 60 * 30,
        /// <summary>
        /// ["<c>60</c>"] 60
        /// </summary>
        [Map("60", "1h")]
        OneHour = 60 * 60,
        /// <summary>
        /// ["<c>120</c>"] 120
        /// </summary>
        [Map("120", "2h")]
        TwoHours = 60 * 60 * 2,
        /// <summary>
        /// ["<c>240</c>"] 240
        /// </summary>
        [Map("240", "4h")]
        FourHours = 60 * 60 * 4,
        /// <summary>
        /// ["<c>360</c>"] 360
        /// </summary>
        [Map("360", "6h")]
        SixHours = 60 * 60 * 6,
        /// <summary>
        /// ["<c>720</c>"] 720
        /// </summary>
        [Map("720", "12h")]
        TwelveHours = 60 * 60 * 12,
        /// <summary>
        /// ["<c>D</c>"] D
        /// </summary>
        [Map("D", "1d")]
        OneDay = 60 * 60 * 24,
        /// <summary>
        /// ["<c>W</c>"] W
        /// </summary>
        [Map("W", "1w")]
        OneWeek = 60 * 60 * 24 * 7,
        /// <summary>
        /// ["<c>M</c>"] M
        /// </summary>
        [Map("M", "1M")]
        OneMonth = 60 * 60 * 24 * 30
    }
}
