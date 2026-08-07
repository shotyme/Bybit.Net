using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// V5 contract types
    /// </summary>
    [JsonConverter(typeof(EnumConverter<ContractTypeV5>))]
    public enum ContractTypeV5
    {
        /// <summary>
        /// ["<c>InversePerpetual</c>"] Inverse perpetual
        /// </summary>
        [Map("InversePerpetual")]
        InversePerpetual,
        /// <summary>
        /// ["<c>LinearPerpetual</c>"] Linear perpetual
        /// </summary>
        [Map("LinearPerpetual")]
        LinearPerpetual,
        /// <summary>
        /// ["<c>LinearFutures</c>"] Linear futures
        /// </summary>
        [Map("LinearFutures")]
        LinearFutures,
        /// <summary>
        /// ["<c>InverseFutures</c>"] Inverse futures
        /// </summary>
        [Map("InverseFutures")]
        InverseFutures,
        /// <summary>
        /// ["<c>Spot</c>"] Spot
        /// </summary>
        [Map("Spot")]
        Spot
    }
}
