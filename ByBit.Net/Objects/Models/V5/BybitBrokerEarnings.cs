using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Broker earnings info
    /// </summary>
    [SerializationModel]
    public record BybitBrokerEarnings
    {
        /// <summary>
        /// ["<c>totalEarningCat</c>"] Total earnings info
        /// </summary>
        [JsonPropertyName("totalEarningCat")]
        public BybitTotalEarnings TotalEarnings { get; set; } = null!;
        /// <summary>
        /// ["<c>details</c>"] Earning details
        /// </summary>
        [JsonPropertyName("details")]
        public BybitEarningDetails[] Details { get; set; } = Array.Empty<BybitEarningDetails>();
        /// <summary>
        /// ["<c>nextPageCursor</c>"] Cursor which can be used for paginiation
        /// </summary>
        [JsonPropertyName("nextPageCursor")]
        public string NextPageCursor { get; set; } = string.Empty;
    }

    /// <summary>
    /// Total earnings info
    /// </summary>
    [SerializationModel]
    public record BybitTotalEarnings
    {
        /// <summary>
        /// ["<c>spot</c>"] Spot earnings
        /// </summary>
        [JsonPropertyName("spot")]
        public BybitBrokerEarning[] Spot { get; set; } = Array.Empty<BybitBrokerEarning>();
        /// <summary>
        /// ["<c>convert</c>"] Convert earnings
        /// </summary>
        [JsonPropertyName("convert")]
        public BybitBrokerEarning[] Convert { get; set; } = Array.Empty<BybitBrokerEarning>();
        /// <summary>
        /// ["<c>derivatives</c>"] Derivatives earnings
        /// </summary>
        [JsonPropertyName("derivatives")]
        public BybitBrokerEarning[] Derivatives { get; set; } = Array.Empty<BybitBrokerEarning>();
        /// <summary>
        /// ["<c>options</c>"] Options earnings
        /// </summary>
        [JsonPropertyName("options")]
        public BybitBrokerEarning[] Options { get; set; } = Array.Empty<BybitBrokerEarning>();
        /// <summary>
        /// ["<c>total</c>"] Total earnings
        /// </summary>
        [JsonPropertyName("total")]
        public BybitBrokerEarning[] Total { get; set; } = Array.Empty<BybitBrokerEarning>();
    }

    /// <summary>
    /// Asset earning info
    /// </summary>
    [SerializationModel]
    public record BybitBrokerEarning
    {
        /// <summary>
        /// ["<c>coin</c>"] The earned asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>earning</c>"] Earned quantity
        /// </summary>
        [JsonPropertyName("earning")]
        public decimal Earning { get; set; }
    }

    /// <summary>
    /// Earning details
    /// </summary>
    [SerializationModel]
    public record BybitEarningDetails
    {
        /// <summary>
        /// ["<c>userId</c>"] User id
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>bizType</c>"] BizType
        /// </summary>
        [JsonPropertyName("bizType")]
        public string BizTyp { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>earning</c>"] Earned quantity
        /// </summary>
        [JsonPropertyName("earning")]
        public decimal Earning { get; set; }
        /// <summary>
        /// ["<c>markupEarning</c>"] Markup earnings
        /// </summary>
        [JsonPropertyName("markupEarning")]
        public decimal MarkupEarning { get; set; }
        /// <summary>
        /// ["<c>baseFeeEarning</c>"] Base fee earnings
        /// </summary>
        [JsonPropertyName("baseFeeEarning")]
        public decimal BaseFeeEarning { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>execId</c>"] Trade id
        /// </summary>
        [JsonPropertyName("execId")]
        public string TradeId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>execTime</c>"] Timestamp
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("execTime")]
        public DateTime Timestamp { get; set; }
    }
}
