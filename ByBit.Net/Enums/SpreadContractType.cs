using CryptoExchange.Net.Attributes;
using System.Text.Json.Serialization;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Spread symbol contract type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SpreadContractType>))]
    public enum SpreadContractType
    {
        /// <summary>
        /// ["<c>FundingRateArb</c>"] Perpetual and spot combination
        /// </summary>
        [Map("FundingRateArb")]
        FundingRateArb,
        /// <summary>
        /// ["<c>CarryTrade</c>"] Futures and spot combination
        /// </summary>
        [Map("CarryTrade")]
        CarryTrade,
        /// <summary>
        /// ["<c>FutureSpread</c>"] Different expiry futures combination
        /// </summary>
        [Map("FutureSpread")]
        FutureSpread,
        /// <summary>
        /// ["<c>PerpBasis</c>"] Futures and Perpetual combination
        /// </summary>
        [Map("PerpBasis")]
        PerpBasis
    }
}
