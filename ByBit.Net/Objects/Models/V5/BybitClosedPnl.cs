using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Closed profit and loss info
    /// </summary>
    [SerializationModel]
    public record BybitClosedPnl
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>side</c>"] Order side
        /// </summary>

        [JsonPropertyName("side")]
        public OrderSide Side { get; set; }
        /// <summary>
        /// ["<c>qty</c>"] Order quantity
        /// </summary>
        [JsonPropertyName("qty")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>orderPrice</c>"] Order price
        /// </summary>
        [JsonPropertyName("orderPrice")]
        public decimal OrderPrice { get; set; }
        /// <summary>
        /// ["<c>orderType</c>"] Order type
        /// </summary>

        [JsonPropertyName("orderType")]
        public OrderType OrderType { get; set; }
        /// <summary>
        /// ["<c>execType</c>"] Trade type
        /// </summary>
        [JsonPropertyName("execType")]

        public TradeType TradeType { get; set; }
        /// <summary>
        /// ["<c>closedSize</c>"] Closed size
        /// </summary>
        [JsonPropertyName("closedSize")]
        public decimal ClosedSize { get; set; }
        /// <summary>
        /// ["<c>cumEntryValue</c>"] Cumulated entry position value
        /// </summary>
        [JsonPropertyName("cumEntryValue")]
        public decimal EntryValue { get; set; }
        /// <summary>
        /// ["<c>avgEntryPrice</c>"] Average entry price
        /// </summary>
        [JsonPropertyName("avgEntryPrice")]
        public decimal AverageEntryPrice { get; set; }
        /// <summary>
        /// ["<c>cumExitValue</c>"] Cumulated exit position value
        /// </summary>
        [JsonPropertyName("cumExitValue")]
        public decimal ExitValue { get; set; }
        /// <summary>
        /// ["<c>avgExitPrice</c>"] Average exit price
        /// </summary>
        [JsonPropertyName("avgExitPrice")]
        public decimal AverageExitPrice { get; set; }
        /// <summary>
        /// ["<c>closedPnl</c>"] Close PnL
        /// </summary>
        [JsonPropertyName("closedPnl")]
        public decimal ClosedPnl { get; set; }
        /// <summary>
        /// ["<c>fillCount</c>"] Number of fills
        /// </summary>
        [JsonPropertyName("fillCount")]
        public int FillCount { get; set; }
        /// <summary>
        /// ["<c>leverage</c>"] Leverage
        /// </summary>
        [JsonPropertyName("leverage")]
        public decimal Leverage { get; set; }
        /// <summary>
        /// ["<c>createdTime</c>"] Created time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("createdTime")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// ["<c>updatedTime</c>"] Updated time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("updatedTime")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// ["<c>openFee</c>"] Open fee
        /// </summary>
        [JsonPropertyName("openFee")]
        public decimal? OpenFee { get; set; }
        /// <summary>
        /// ["<c>closeFee</c>"] Close fee
        /// </summary>
        [JsonPropertyName("closeFee")]
        public decimal? CloseFee { get; set; }
    }
}
