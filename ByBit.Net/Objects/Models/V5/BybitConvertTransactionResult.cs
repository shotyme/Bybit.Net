using Bybit.Net.Enums;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Transaction info
    /// </summary>
    [SerializationModel]
    public record BybitConvertTransactionResult
    {
        /// <summary>
        /// ["<c>quoteTxId</c>"] Quote transaction id
        /// </summary>
        [JsonPropertyName("quoteTxId")]
        public string QuoteTransactionId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>exchangeStatus</c>"] Convert status
        /// </summary>
        [JsonPropertyName("exchangeStatus")]
        public ConvertTransactionStatus Status { get; set; }
    }
}
