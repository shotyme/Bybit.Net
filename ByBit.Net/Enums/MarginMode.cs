using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Margin mode
    /// </summary>
    [JsonConverter(typeof(EnumConverter<MarginMode>))]
    public enum MarginMode
    {
        /// <summary>
        /// ["<c>REGULAR_MARGIN</c>"] Regular margin
        /// </summary>
        [Map("REGULAR_MARGIN")]
        RegularMargin,
        /// <summary>
        /// ["<c>PORTFOLIO_MARGIN</c>"] Portfolio margin
        /// </summary>
        [Map("PORTFOLIO_MARGIN")]
        PortfolioMargin,
        /// <summary>
        /// ["<c>ISOLATED_MARGIN</c>"] Isolated margin
        /// </summary>
        [Map("ISOLATED_MARGIN")]
        IsolatedMargin
    }
}
