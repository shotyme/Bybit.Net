using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Position mode
    /// </summary>
    [JsonConverter(typeof(EnumConverter<PositionMode>))]
    public enum PositionMode
    {
        /// <summary>
        /// ["<c>0</c>"] Merge single
        /// </summary>
        [Map("0")]
        MergedSingle,
        /// <summary>
        /// ["<c>3</c>"] Both sides
        /// </summary>
        [Map("3")]
        BothSides
    }
}
