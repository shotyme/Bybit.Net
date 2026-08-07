using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Oco trigger type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<OcoTriggerType>))]
    public enum OcoTriggerType
    {
        /// <summary>
        /// ["<c>OcoTriggerByUnknown</c>"] Trigger by unknown
        /// </summary>
        [Map("OcoTriggerByUnknown")]
        OcoTriggerByUnknown,
        /// <summary>
        /// ["<c>OcoTriggerTp</c>"] Trigger by take profit
        /// </summary>
        [Map("OcoTriggerTp")]
        OcoTriggerTp,
        /// <summary>
        /// ["<c>OcoTriggerBySl</c>"] Trigger by stop loss
        /// </summary>
        [Map("OcoTriggerBySl")]
        OcoTriggerBySl
    }
}
