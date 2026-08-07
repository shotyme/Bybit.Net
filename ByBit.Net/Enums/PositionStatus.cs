using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Position status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<PositionStatus>))]
    public enum PositionStatus
    {
        /// <summary>
        /// ["<c>Normal</c>"] Normal
        /// </summary>
        [Map("Normal")]
        Normal,
        /// <summary>
        /// ["<c>Liq</c>"] Liquidation
        /// </summary>
        [Map("Liq")]
        Liquidation,
        /// <summary>
        /// ["<c>Adl</c>"] Auto deleverage
        /// </summary>
        [Map("Adl")]
        AutoDeleverage,
        /// <summary>
        /// ["<c>Inactive</c>"] Inactive
        /// </summary>
        [Map("Inactive")]
        Inactive
    }
}
