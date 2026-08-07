using CryptoExchange.Net.Attributes;
using System.Text.Json.Serialization;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Loan term
    /// </summary>
    [JsonConverter(typeof(EnumConverter<LoanTerm>))]
    public enum LoanTerm
    {
        /// <summary>
        /// ["<c>7</c>"] 7 days
        /// </summary>
        [Map("7")]
        Days7,
        /// <summary>
        /// ["<c>14</c>"] 14 days
        /// </summary>
        [Map("14")]
        Days14,
        /// <summary>
        /// ["<c>30</c>"] 30 days
        /// </summary>
        [Map("30")]
        Days30,
        /// <summary>
        /// ["<c>90</c>"] 90 days
        /// </summary>
        [Map("90")]
        Days90,
        /// <summary>
        /// ["<c>180</c>"] 180 days
        /// </summary>
        [Map("180")]
        Days180
    }
}
