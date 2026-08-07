using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Leverage token purchase status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<LeverageTokenOrderStatus>))]
    public enum LeverageTokenOrderStatus
    {
        /// <summary>
        /// ["<c>1</c>"] Completed
        /// </summary>
        [Map("1")]
        Completed,
        /// <summary>
        /// ["<c>2</c>"] In progress
        /// </summary>
        [Map("2")]
        InProgress,
        /// <summary>
        /// ["<c>3</c>"] Failed
        /// </summary>
        [Map("3")]
        Failed,
    }
}
