using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Self match prevention type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SelfMatchPreventionType>))]
    public enum SelfMatchPreventionType
    {
        /// <summary>
        /// ["<c>None</c>"] None
        /// </summary>
        [Map("None")]
        None,
        /// <summary>
        /// ["<c>CancelMaker</c>"] Cancel maker
        /// </summary>
        [Map("CancelMaker")]
        CancelMaker,
        /// <summary>
        /// ["<c>CancelTaker</c>"] Cancel taker
        /// </summary>
        [Map("CancelTaker")]
        CancelTaker,
        /// <summary>
        /// ["<c>CancelBoth</c>"] Cancel both
        /// </summary>
        [Map("CancelBoth")]
        CancelBoth
    }
}
