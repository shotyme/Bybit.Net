using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Account status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SubAccountStatus>))]
    public enum SubAccountStatus
    {
        /// <summary>
        /// ["<c>1</c>"] Normal
        /// </summary>
        [Map("1")]
        Normal,
        /// <summary>
        /// ["<c>2</c>"] Login banned
        /// </summary>
        [Map("2")]
        LoginBanned,
        /// <summary>
        /// ["<c>4</c>"] Frozen
        /// </summary>
        [Map("4")]
        Frozen
    }
}
