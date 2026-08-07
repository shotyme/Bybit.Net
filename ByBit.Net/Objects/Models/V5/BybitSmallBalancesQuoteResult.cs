using Bybit.Net.Converters;
using Bybit.Net.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Small balances quote result
    /// </summary>
    public record BybitSmallBalancesQuoteResult
    {
        /// <summary>
        /// ["<c>quoteId</c>"] Quote id
        /// </summary>
        [JsonPropertyName("quoteId")]
        public string QuoteId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>exchangeTxId</c>"] Exchange transaction id
        /// </summary>
        [JsonPropertyName("exchangeTxId")]
        public string ExchangeTransactionId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>submitTime</c>"] Quote id
        /// </summary>
        [JsonPropertyName("submitTime")]
        public DateTime SubmitTime { get; set; }
        /// <summary>
        /// ["<c>exchangeTxId</c>"] Status
        /// </summary>
        [JsonPropertyName("exchangeTxId")]
        public SmallBalanceConvertStatus Status { get; set; }
        /// <summary>
        /// ["<c>msg</c>"] Message
        /// </summary>
        [JsonPropertyName("msg")]
        public string Message { get; set; } = string.Empty;
    }
}
