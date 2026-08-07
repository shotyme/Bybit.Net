using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Spot margin asset data
    /// </summary>
    public record BybitMarginAssetData
    {
        /// <summary>
        /// ["<c>currency</c>"] Asset
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>flexibleManualBorrowable</c>"] Flexible manual borrowable
        /// </summary>
        [JsonPropertyName("flexibleManualBorrowable")]
        public bool FlexibleManualBorrowable { get; set; }
        /// <summary>
        /// ["<c>minFlexibleManualBorrowQty</c>"] Min flexible manual borrow quantity
        /// </summary>
        [JsonPropertyName("minFlexibleManualBorrowQty")]
        public decimal MinFlexibleManualBorrowQuantity { get; set; }
        /// <summary>
        /// ["<c>flexibleManualBorrowAccuracy</c>"] Flexible manual borrow accuracy
        /// </summary>
        [JsonPropertyName("flexibleManualBorrowAccuracy")]
        public int FlexibleManualBorrowAccuracy { get; set; }
        /// <summary>
        /// ["<c>fixedManualBorrowable</c>"] Fixed manual borrowable
        /// </summary>
        [JsonPropertyName("fixedManualBorrowable")]
        public bool FixedManualBorrowable { get; set; }
        /// <summary>
        /// ["<c>minFixedManualBorrowQty</c>"] Min fixed manual borrow quantity
        /// </summary>
        [JsonPropertyName("minFixedManualBorrowQty")]
        public decimal? MinFixedManualBorrowQuantity { get; set; }
        /// <summary>
        /// ["<c>fixedManualBorrowAccuracy</c>"] Fixed manual borrow accuracy
        /// </summary>
        [JsonPropertyName("fixedManualBorrowAccuracy")]
        public int? FixedManualBorrowAccuracy { get; set; }
        /// <summary>
        /// ["<c>fixedInterestRateAccuracy</c>"] Fixed interest rate accuracy
        /// </summary>
        [JsonPropertyName("fixedInterestRateAccuracy")]
        public int? FixedInterestRateAccuracy { get; set; }
        /// <summary>
        /// ["<c>minFixedInterestRate</c>"] Min fixed interest rate
        /// </summary>
        [JsonPropertyName("minFixedInterestRate")]
        public decimal? MinFixedInterestRate { get; set; }
        /// <summary>
        /// ["<c>maxFixedInterestRate</c>"] Max fixed interest rate
        /// </summary>
        [JsonPropertyName("maxFixedInterestRate")]
        public decimal? MaxFixedInterestRate { get; set; }
    }


}
