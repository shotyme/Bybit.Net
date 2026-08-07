using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Loan info
    /// </summary>
    [SerializationModel]
    public record BybitLoan
    {
        /// <summary>
        /// ["<c>collateralAmount</c>"] Collateral quantity
        /// </summary>
        [JsonPropertyName("collateralAmount")]
        public decimal CollateralQuantity { get; set; }
        /// <summary>
        /// ["<c>collateralCurrency</c>"] Collateral asset
        /// </summary>
        [JsonPropertyName("collateralCurrency")]
        public string CollateralAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>currentLTV</c>"] Current LTV
        /// </summary>
        [JsonPropertyName("currentLTV")]
        public decimal CurrentLtv { get; set; }
        /// <summary>
        /// ["<c>expirationTime</c>"] Expiration time
        /// </summary>
        [JsonPropertyName("expirationTime")]
        public DateTime? ExpirationTime { get; set; }
        /// <summary>
        /// ["<c>hourlyInterestRate</c>"] Hourly interest rate
        /// </summary>
        [JsonPropertyName("hourlyInterestRate")]
        public decimal HourlyInterestRate { get; set; }
        /// <summary>
        /// ["<c>loanCurrency</c>"] Loan asset
        /// </summary>
        [JsonPropertyName("loanCurrency")]
        public string LoanAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>loanTerm</c>"] Loan term
        /// </summary>
        [JsonPropertyName("loanTerm")]
        public decimal? LoanTerm { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>residualInterest</c>"] Residual interest
        /// </summary>
        [JsonPropertyName("residualInterest")]
        public decimal ResidualInterest { get; set; }
        /// <summary>
        /// ["<c>residualPenaltyInterest</c>"] Residual penalty interest
        /// </summary>
        [JsonPropertyName("residualPenaltyInterest")]
        public decimal ResidualPenaltyInterest { get; set; }
        /// <summary>
        /// ["<c>totalDebt</c>"] Total debt
        /// </summary>
        [JsonPropertyName("totalDebt")]
        public decimal TotalDebt { get; set; }
    }


}
