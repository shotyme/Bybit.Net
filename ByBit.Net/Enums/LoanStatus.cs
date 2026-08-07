using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Loan status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<LoanStatus>))]
    public enum LoanStatus
    {
        /// <summary>
        /// ["<c>1</c>"] Fully repaid manually
        /// </summary>
        [Map("1")]
        FullyRepaidManually,
        /// <summary>
        /// ["<c>2</c>"] Fully repaid by liquidation
        /// </summary>
        [Map("2")]
        FullyRepaidByLiquidation
    }
}
