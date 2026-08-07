using CryptoExchange.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Asset account type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<AssetAccountType>))]
    public enum AssetAccountType
    {
        /// <summary>
        /// ["<c>FundingAccount</c>"] Funding account
        /// </summary>
        [Map("FundingAccount")]
        FundingAccount,
        /// <summary>
        /// ["<c>UnifiedTradingAccount</c>"] Unified trading account
        /// </summary>
        [Map("UnifiedTradingAccount")]
        UnifiedTradingAccount,
        /// <summary>
        /// ["<c>Earn</c>"] Earn account
        /// </summary>
        [Map("Earn")]
        Earn,
        /// <summary>
        /// ["<c>TradingBot</c>"] Trading bot account
        /// </summary>
        [Map("TradingBot")]
        TradingBot,
        /// <summary>
        /// ["<c>CopyTrading</c>"] Copy trading account
        /// </summary>
        [Map("CopyTrading")]
        CopyTrading,
        /// <summary>
        /// ["<c>CryptoLoans</c>"] Crypto loans account
        /// </summary>
        [Map("CryptoLoans")]
        CryptoLoans,
        /// <summary>
        /// ["<c>CryptoLoans_legacy</c>"] Crypto loans legacy account
        /// </summary>
        [Map("CryptoLoans_legacy")]
        CryptoLoansLegacy,
        /// <summary>
        /// ["<c>BybitPayLater</c>"] Pay later account
        /// </summary>
        [Map("BybitPayLater")]
        BybitPayLater,
        /// <summary>
        /// ["<c>Launchpool</c>"] Launchpool account
        /// </summary>
        [Map("Launchpool")]
        Launchpool,
        /// <summary>
        /// ["<c>TradFi</c>"] TradFi account
        /// </summary>
        [Map("TradFi")]
        TradFi,
        /// <summary>
        /// ["<c>MarginStakedSOL</c>"] Margin staked SOL
        /// </summary>
        [Map("MarginStakedSOL")]
        MarginStakedSol,
        /// <summary>
        /// ["<c>Alpha</c>"] Alpha
        /// </summary>
        [Map("Alpha")]
        Alpha,
    }

}
