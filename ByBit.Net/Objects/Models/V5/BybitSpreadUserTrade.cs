using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Spread user trade info
    /// </summary>
    public record BybitSpreadUserTrade
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>orderLinkId</c>"] Client order id
        /// </summary>
        [JsonPropertyName("orderLinkId")]
        public string? ClientOrderId { get; set; }
        /// <summary>
        /// ["<c>side</c>"] Order side
        /// </summary>
        [JsonPropertyName("side")]
        public OrderSide OrderSide { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>execPrice</c>"] Trade price
        /// </summary>
        [JsonPropertyName("execPrice")]
        public decimal Price { get; set; }
        /// <summary>
        /// ["<c>legs</c>"] Legs
        /// </summary>
        [JsonPropertyName("legs")]
        public BybitSpreadUserTradeLeg[] Legs { get; set; } = [];
        /// <summary>
        /// ["<c>execTime</c>"] Trade time
        /// </summary>
        [JsonPropertyName("execTime")]
        public DateTime TradeTime { get; set; }
        /// <summary>
        /// ["<c>execType</c>"] Trade type
        /// </summary>
        [JsonPropertyName("execType")]
        public TradeType TradeType { get; set; }
        /// <summary>
        /// ["<c>execQty</c>"] Traded quantity
        /// </summary>
        [JsonPropertyName("execQty")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>execId</c>"] Trade id
        /// </summary>
        [JsonPropertyName("execId")]
        public string TradeId { get; set; } = string.Empty;
    }

    /// <summary>
    /// User trade leg
    /// </summary>
    public record BybitSpreadUserTradeLeg
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>side</c>"] Order side
        /// </summary>
        [JsonPropertyName("side")]
        public OrderSide OrderSide { get; set; }
        /// <summary>
        /// ["<c>execPrice</c>"] Trade price
        /// </summary>
        [JsonPropertyName("execPrice")]
        public decimal Price { get; set; }
        /// <summary>
        /// ["<c>execTime</c>"] Trade timestamp
        /// </summary>
        [JsonPropertyName("execTime")]
        public DateTime TradeTime { get; set; }
        /// <summary>
        /// ["<c>execValue</c>"] Traded value
        /// </summary>
        [JsonPropertyName("execValue")]
        public decimal Value { get; set; }
        /// <summary>
        /// ["<c>execType</c>"] Trade type
        /// </summary>
        [JsonPropertyName("execType")]
        public TradeType TradeType { get; set; }
        /// <summary>
        /// ["<c>category</c>"] Category
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>execQty</c>"] Traded quantity
        /// </summary>
        [JsonPropertyName("execQty")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>execFee</c>"] Trade fee
        /// </summary>
        [JsonPropertyName("execFee")]
        public decimal Fee { get; set; }
        /// <summary>
        /// ["<c>execFeeV2</c>"] Trade fee
        /// </summary>
        [JsonPropertyName("execFeeV2")]
        public decimal FeeV2 { get; set; }
        /// <summary>
        /// ["<c>feeCurrency</c>"] Fee asset
        /// </summary>
        [JsonPropertyName("feeCurrency")]
        public string FeeAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>execId</c>"] Trade id
        /// </summary>
        [JsonPropertyName("execId")]
        public string TradeId { get; set; } = string.Empty;
    }


}
