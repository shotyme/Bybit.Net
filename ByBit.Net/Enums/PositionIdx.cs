using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Position idx
    /// </summary>
    [JsonConverter(typeof(EnumConverter<PositionIdx>))]
    public enum PositionIdx
    {
        /// <summary>
        /// ["<c>0</c>"] One way mode
        /// </summary>
        [Map("0")]
        OneWayMode = 0,
        /// <summary>
        /// ["<c>1</c>"] Buy side of hedge mode
        /// </summary>
        [Map("1")]
        BuyHedgeMode = 1,
        /// <summary>
        /// ["<c>2</c>"] Sell side of hedge mode
        /// </summary>
        [Map("2")]
        SellHedgeMode = 2
    }
}
