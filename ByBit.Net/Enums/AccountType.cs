using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Account type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<AccountType>))]
    public enum AccountType
    {
        /// <summary>
        /// ["<c>CONTRACT</c>"] Contract account (futures)
        /// </summary>
        [Map("CONTRACT")]
        Contract,
        /// <summary>
        /// ["<c>SPOT</c>"] Spot account
        /// </summary>
        [Map("SPOT")]
        Spot,
        /// <summary>
        /// ["<c>INVESTMENT</c>"] Investment (defi) account
        /// </summary>
        [Map("INVESTMENT")]
        Investment,
        /// <summary>
        /// ["<c>COPYTRADING</c>"] Copy trading account
        /// </summary>
        [Map("COPYTRADING")]
        CopyTrading,
        /// <summary>
        /// ["<c>OPTION</c>"] Option account
        /// </summary>
        [Map("OPTION")]
        Option,
        /// <summary>
        /// ["<c>FUND</c>"] Funding account
        /// </summary>
        [Map("FUND")]
        Fund,
        /// <summary>
        /// ["<c>UNIFIED</c>"] Unified account
        /// </summary>
        [Map("UNIFIED")]
        Unified,
    }
}
