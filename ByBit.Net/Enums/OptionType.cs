using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Trading type of option
    /// </summary>
    [JsonConverter(typeof(EnumConverter<OptionType>))]
    public enum OptionType
    {
        /// <summary>
        /// ["<c>Call</c>"] Call
        /// </summary>
        [Map("Call")]
        Call,
        /// <summary>
        /// ["<c>Put</c>"] Put
        /// </summary>
        [Map("Put")]
        Put
    }
}
