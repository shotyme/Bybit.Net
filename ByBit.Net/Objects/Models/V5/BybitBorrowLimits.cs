using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Borrow limit
    /// </summary>
    [SerializationModel]
    public record BybitBorrowLimits
    {
        /// <summary>
        /// ["<c>collateralCurrency</c>"] Collateral asset
        /// </summary>
        [JsonPropertyName("collateralCurrency")]
        public string CollateralAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>loanCurrency</c>"] Loan asset
        /// </summary>
        [JsonPropertyName("loanCurrency")]
        public string LoanAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>maxCollateralAmount</c>"] Max collateral quantity
        /// </summary>
        [JsonPropertyName("maxCollateralAmount")]
        public decimal MaxCollateralQuantity { get; set; }
        /// <summary>
        /// ["<c>maxLoanAmount</c>"] Max loan quantity
        /// </summary>
        [JsonPropertyName("maxLoanAmount")]
        public decimal MaxLoanQuantity { get; set; }
        /// <summary>
        /// ["<c>minCollateralAmount</c>"] Min collateral quantity
        /// </summary>
        [JsonPropertyName("minCollateralAmount")]
        public decimal MinCollateralQuantity { get; set; }
        /// <summary>
        /// ["<c>minLoanAmount</c>"] Min loan quantity
        /// </summary>
        [JsonPropertyName("minLoanAmount")]
        public decimal MinLoanQuantity { get; set; }
    }


}
