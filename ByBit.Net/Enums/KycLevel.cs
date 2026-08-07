using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// KnowYourCustomer level
    /// </summary>
    [JsonConverter(typeof(EnumConverter<KycLevel>))]
    public enum KycLevel
    {
        /// <summary>
        /// ["<c>LEVEL_DEFAULT</c>"] Default level
        /// </summary>
        [Map("LEVEL_DEFAULT")]
        Default,
        /// <summary>
        /// ["<c>LEVEL_1</c>"] Level 1
        /// </summary>
        [Map("LEVEL_1")]
        Level1,
        /// <summary>
        /// ["<c>LEVEL_2</c>"] Level 2
        /// </summary>
        [Map("LEVEL_2")]
        Level2
    }
}
