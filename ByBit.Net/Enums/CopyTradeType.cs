using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Copy trading type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<CopyTradeType>))]
    public enum CopyTradeType
    {
        /// <summary>
        /// ["<c>none</c>"] Regardless of normal account or UTA account, this trading pair does not support copy trading
        /// </summary>
        [Map("none")]
        None,
        /// <summary>
        /// ["<c>both</c>"] For both normal account and UTA account, this trading pair supports copy trading
        /// </summary>
        [Map("both")]
        Both,
        /// <summary>
        /// ["<c>utaOnly</c>"] Only for UTA account,this trading pair supports copy trading
        /// </summary>
        [Map("utaOnly")]
        UtaOnly,
        /// <summary>
        /// ["<c>normalOnly</c>"] Only for normal account, this trading pair supports copy trading
        /// </summary>
        [Map("normalOnly")]
        NormalOnly
    }
}
