using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Trigger direction
    /// </summary>
    [JsonConverter(typeof(EnumConverter<TradeMode>))]
    public enum TradeMode
    {
        /// <summary>
        /// ["<c>0</c>"] Cross margin mode
        /// </summary>
        [Map("0")]
        CrossMargin,
        /// <summary>
        /// ["<c>1</c>"] Isolated mode
        /// </summary>
        [Map("1")]
        Isolated
    }
}
