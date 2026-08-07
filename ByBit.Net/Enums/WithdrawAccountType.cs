using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Account type to withdraw from
    /// </summary>
    [JsonConverter(typeof(EnumConverter<WithdrawAccountType>))]
    public enum WithdrawAccountType
    {
        /// <summary>
        /// ["<c>SPOT</c>"] Spot account
        /// </summary>
        [Map("SPOT")]
        Spot,
        /// <summary>
        /// ["<c>FUND</c>"] Funding account
        /// </summary>
        [Map("FUND")]
        Fund,
        /// <summary>
        /// ["<c>UTA</c>"] UTA account
        /// </summary>
        [Map("UTA")]
        Uta,
        /// <summary>
        /// ["<c>FUND,UTA</c>"] Use funding account first and UTA account after
        /// </summary>
        [Map("FUND,UTA")]
        FundAndUta,
    }
}
