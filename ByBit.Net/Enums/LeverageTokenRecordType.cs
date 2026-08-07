using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Leverage token record type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<LeverageTokenRecordType>))]
    public enum LeverageTokenRecordType
    {
        /// <summary>
        /// ["<c>1</c>"] Purchase record
        /// </summary>
        [Map("1")]
        Purchase,
        /// <summary>
        /// ["<c>2</c>"] Redeem record
        /// </summary>
        [Map("2")]
        Redeem
    }
}
