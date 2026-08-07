using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Address status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<AddressStatus>))]
    public enum AddressStatus
    {
        /// <summary>
        /// ["<c>0</c>"] Normal
        /// </summary>
        [Map("0")]
        Normal,
        /// <summary>
        /// ["<c>1</c>"] New Addresses are prohibited from withdrawing coins for 24 Hours
        /// </summary>
        [Map("1")]
        Pending
    }
}
