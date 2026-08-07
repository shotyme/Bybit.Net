using Bybit.Net.Enums;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Leverage token purchase record
    /// </summary>
    [SerializationModel]
    public record BybitLeverageTokenRecord
    {
        /// <summary>
        /// ["<c>ltCoin</c>"] Token abbreviation
        /// </summary>
        [JsonPropertyName("ltCoin")]
        public string Token { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>ltOrderStatus</c>"] Order status
        /// </summary>
        [JsonPropertyName("ltOrderStatus")]
        public LeverageTokenOrderStatus Status { get; set; }
        /// <summary>
        /// ["<c>execQty</c>"] Filled quantity
        /// </summary>
        [JsonPropertyName("execQty")]
        public decimal? QuantityFilled { get; set; }
        /// <summary>
        /// ["<c>execAmt</c>"] Filled quantity
        /// </summary>
        [JsonPropertyName("execAmt")]
        public decimal? ValueFilled { get; set; }
        /// <summary>
        /// ["<c>amount</c>"] Purchase amount
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal? Quantity { get; set; }
        [JsonInclude, JsonPropertyName("quantity")]
        internal decimal? QuantityInt
        {
            set => Quantity = value;
            get => Quantity;
        }
        /// <summary>
        /// ["<c>serialNo</c>"] Serial number
        /// </summary>
        [JsonPropertyName("serialNo")]
        public string? ClientOrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>valueCoin</c>"] Quote asset
        /// </summary>
        [JsonPropertyName("valueCoin")]
        public string QuoteAsset { get; set; } = string.Empty;
    }

    /// <summary>
    /// Purchase record
    /// </summary>
    [SerializationModel]
    public record BybitLeverageTokenPurchase : BybitLeverageTokenRecord
    {
        /// <summary>
        /// ["<c>purchaseId</c>"] Purchase id
        /// </summary>
        [JsonPropertyName("purchaseId")]
        public string PurchaseId { get; set; } = string.Empty;
    }

    /// <summary>
    /// Purchase record
    /// </summary>
    [SerializationModel]
    public record BybitLeverageTokenRedemption : BybitLeverageTokenRecord
    {
        /// <summary>
        /// ["<c>redeemId</c>"] Redeem id
        /// </summary>
        [JsonPropertyName("redeemId")]
        public string RedeemId { get; set; } = string.Empty;
    }
}
