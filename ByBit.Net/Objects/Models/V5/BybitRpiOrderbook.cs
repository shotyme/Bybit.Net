using CryptoExchange.Net.Converters;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Order book info
    /// </summary>
    [SerializationModel]
    public record BybitRpiOrderbook
    {
        /// <summary>
        /// ["<c>s</c>"] Symbol
        /// </summary>
        [JsonPropertyName("s")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>b</c>"] Bids
        /// </summary>
        [JsonPropertyName("b")]
        public BybitRpiOrderbookEntry[] Bids { get; set; } = Array.Empty<BybitRpiOrderbookEntry>();
        /// <summary>
        /// ["<c>a</c>"] Asks
        /// </summary>
        [JsonPropertyName("a")]
        public BybitRpiOrderbookEntry[] Asks { get; set; } = Array.Empty<BybitRpiOrderbookEntry>();
        /// <summary>
        /// ["<c>u</c>"] Update id
        /// </summary>
        [JsonPropertyName("u")]
        public long UpdateId { get; set; }
        /// <summary>
        /// ["<c>seq</c>"] Cross sequence
        /// </summary>
        [JsonPropertyName("seq")]
        public long? Sequence { get; set; }
    }

    /// <summary>
    /// Order book entry
    /// </summary>
    [JsonConverter(typeof(ArrayConverter<BybitRpiOrderbookEntry>))]
    [SerializationModel]
    public record BybitRpiOrderbookEntry
    {
        /// <summary>
        /// Price of the entry
        /// </summary>
        [ArrayProperty(0), JsonConverter(typeof(DecimalConverter))]
        public decimal Price { get; set; }
        /// <summary>
        /// None RPI quantity
        /// </summary>
        [ArrayProperty(1)]
        public decimal NoneRpiQuantity { get; set; }
        /// <summary>
        /// RPI quantity
        /// </summary>
        [ArrayProperty(1)]
        public decimal RpiQuantity { get; set; }
    }
}
