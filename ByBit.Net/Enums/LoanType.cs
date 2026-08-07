using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Loan type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<LoanType>))]
    public enum LoanType
    {
        /// <summary>
        /// ["<c>1</c>"] Fixed term
        /// </summary>
        [Map("1")]
        FixedTerm,
        /// <summary>
        /// ["<c>2</c>"] Flexible term
        /// </summary>
        [Map("2")]
        FlexibleTerm
    }
}
