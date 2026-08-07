using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Product status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<EarnProductStatus>))]
    public enum EarnProductStatus
    {
        /// <summary>
        /// ["<c>Available</c>"] Available
        /// </summary>
        [Map("Available")]
        Available,
        /// <summary>
        /// ["<c>NotAvailable</c>"] Not available
        /// </summary>
        [Map("NotAvailable")]
        NotAvailable
    }
}
