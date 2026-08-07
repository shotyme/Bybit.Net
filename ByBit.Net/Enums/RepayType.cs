using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Repayment type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<RepayType>))]
    public enum RepayType
    {
        /// <summary>
        /// ["<c>1</c>"] By user
        /// </summary>
        [Map("1")]
        ByUser,
        /// <summary>
        /// ["<c>2</c>"] By liquidation
        /// </summary>
        [Map("2")]
        ByLiquidation
    }
}
