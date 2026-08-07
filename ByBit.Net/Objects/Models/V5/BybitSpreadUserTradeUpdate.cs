using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Spread user trade update
    /// </summary>
    public record BybitSpreadUserTradeUpdate
    {
        /// <summary>
        /// ["<c>category</c>"] Leg Category
        /// </summary>
        [JsonPropertyName("category")]
        public SpreadLegCategory SpreadLegCategory { get; set; }
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>closedSize</c>"] Closed quantity
        /// </summary>
        [JsonPropertyName("closedSize")]
        public decimal? ClosedQuantity { get; set; }
        /// <summary>
        /// ["<c>execFee</c>"] Trade fee
        /// </summary>
        [JsonPropertyName("execFee")]
        public decimal? Fee { get; set; }
        /// <summary>
        /// ["<c>execId</c>"] Trade id
        /// </summary>
        [JsonPropertyName("execId")]
        public string TradeId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>parentExecId</c>"] Parent trade id
        /// </summary>
        [JsonPropertyName("parentExecId")]
        public string? ParentTradeId { get; set; }
        /// <summary>
        /// ["<c>execPrice</c>"] Trade price
        /// </summary>
        [JsonPropertyName("execPrice")]
        public decimal TradePrice { get; set; }
        /// <summary>
        /// ["<c>execQty</c>"] Traded quantity
        /// </summary>
        [JsonPropertyName("execQty")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>execType</c>"] Trade type
        /// </summary>
        [JsonPropertyName("execType")]
        public TradeType TradeType { get; set; }
        /// <summary>
        /// ["<c>execValue</c>"] Traded value
        /// </summary>
        [JsonPropertyName("execValue")]
        public decimal? Value { get; set; }
        /// <summary>
        /// ["<c>feeRate</c>"] Fee rate
        /// </summary>
        [JsonPropertyName("feeRate")]
        public decimal? FeeRate { get; set; }
        /// <summary>
        /// ["<c>markPrice</c>"] Mark price
        /// </summary>
        [JsonPropertyName("markPrice")]
        public decimal? MarkPrice { get; set; }
        /// <summary>
        /// ["<c>leavesQty</c>"] Order quantity remaining
        /// </summary>
        [JsonPropertyName("leavesQty")]
        public decimal QuantityRemaining { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>orderLinkId</c>"] Client order id
        /// </summary>
        [JsonPropertyName("orderLinkId")]
        public string? ClientOrderId { get; set; }
        /// <summary>
        /// ["<c>orderPrice</c>"] Order price
        /// </summary>
        [JsonPropertyName("orderPrice")]
        public decimal OrderPrice { get; set; }
        /// <summary>
        /// ["<c>orderQty</c>"] Order quantity
        /// </summary>
        [JsonPropertyName("orderQty")]
        public decimal OrderQuantity { get; set; }
        /// <summary>
        /// ["<c>orderType</c>"] Order type
        /// </summary>
        [JsonPropertyName("orderType")]
        public OrderType OrderType { get; set; }
        /// <summary>
        /// ["<c>side</c>"] Side
        /// </summary>
        [JsonPropertyName("side")]
        public OrderSide Side { get; set; }
        /// <summary>
        /// ["<c>execTime</c>"] Trade timestamp
        /// </summary>
        [JsonPropertyName("execTime")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// ["<c>isLeverage</c>"] Is leverage
        /// </summary>
        [JsonPropertyName("isLeverage")]
        public bool? IsLeverage { get; set; }
        /// <summary>
        /// ["<c>isMaker</c>"] Is maker
        /// </summary>
        [JsonPropertyName("isMaker")]
        public bool IsMaker { get; set; }
        /// <summary>
        /// ["<c>seq</c>"] Sequence number
        /// </summary>
        [JsonPropertyName("seq")]
        public long Sequence { get; set; }
        /// <summary>
        /// ["<c>createType</c>"] Create type
        /// </summary>
        [JsonPropertyName("createType")]
        public string? CreateType { get; set; }
        /// <summary>
        /// ["<c>execPnl</c>"] Trade profit and loss
        /// </summary>
        [JsonPropertyName("execPnl")]
        public decimal? Pnl { get; set; }
    }


}
