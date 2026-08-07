using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Account type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<Category>))]
    public enum Category
    {
        /// <summary>
        /// ["<c>linear</c>"] Linear perpetual, including USDC perp.
        /// </summary>
        [Map("linear")]
        Linear,
        /// <summary>
        /// ["<c>inverse</c>"] Inverse futures, including inverse perpetual, inverse futures.
        /// </summary>
        [Map("inverse")]
        Inverse,
        /// <summary>
        /// ["<c>spot</c>"] Spot
        /// </summary>
        [Map("spot")]
        Spot,
        /// <summary>
        /// ["<c>option</c>"] USDC Option
        /// </summary>
        [Map("option")]
        Option,
        /// <summary>
        /// Category not passed
        /// </summary>
        [Map("")]
        Undefined
    }
}
