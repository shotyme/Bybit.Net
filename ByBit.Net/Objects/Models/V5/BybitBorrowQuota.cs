using Bybit.Net.Enums;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Borrow quota info
    /// </summary>
    [SerializationModel]
    public record BybitBorrowQuota
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>maxTradeQty</c>"] Max trade quantity in base asset
        /// </summary>
        [JsonPropertyName("maxTradeQty")]
        public decimal MaxTradeQuantity { get; set; }
        /// <summary>
        /// ["<c>side</c>"] Order side
        /// </summary>
        [JsonPropertyName("side")]
        public OrderSide Side { get; set; }
        /// <summary>
        /// ["<c>maxTradeAmount</c>"] Max trade amount in quote asset
        /// </summary>
        [JsonPropertyName("maxTradeAmount")]
        public decimal MaxTradeAmount { get; set; }
        /// <summary>
        /// ["<c>borrowCoin</c>"] Borrow asset
        /// </summary>
        [JsonPropertyName("borrowCoin")]
        public string BorrowAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>spotMaxTradeQty</c>"] No matter your Spot margin switch on or not, it always returns actual qty of base coin you can trade or you have, up to 4 decimals
        /// </summary>
        [JsonPropertyName("spotMaxTradeQty")]
        public decimal SpotMaxTradeQty { get; set; }
        /// <summary>
        /// ["<c>spotMaxTradeAmount</c>"] No matter your Spot margin switch on or not, it always returns actual amount of quote coin you can trade or you have, up to 8 decimals
        /// </summary>
        [JsonPropertyName("spotMaxTradeAmount")]
        public decimal SpotMaxTradeAmount { get; set; }
    }
}
