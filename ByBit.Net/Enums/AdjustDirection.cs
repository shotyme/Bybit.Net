using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Adjust direction
    /// </summary>
    [JsonConverter(typeof(EnumConverter<AdjustDirection>))]
    public enum AdjustDirection
    {
        /// <summary>
        /// ["<c>0</c>"] Add
        /// </summary>
        [Map("0")]
        Add,
        /// <summary>
        /// ["<c>1</c>"] Reduce
        /// </summary>
        [Map("1")]
        Reduce
    }
}
