using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Earn category
    /// </summary>
    [JsonConverter(typeof(EnumConverter<EarnCategory>))]
    public enum EarnCategory
    {
        /// <summary>
        /// ["<c>FlexibleSaving</c>"] Flexible saving
        /// </summary>
        [Map("FlexibleSaving")]
        FlexibleSaving,
        /// <summary>
        /// ["<c>OnChain</c>"] On chain
        /// </summary>
        [Map("OnChain")]
        OnChain
    }
}
