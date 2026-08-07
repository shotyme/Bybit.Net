using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Loan order info
    /// </summary>
    [SerializationModel]
    public record BybitLoanOrder
    {
        /// <summary>
        /// ["<c>borrowTime</c>"] Borrow time
        /// </summary>
        [JsonPropertyName("borrowTime")]
        public DateTime BorrowTime { get; set; }
        /// <summary>
        /// ["<c>collateralCurrency</c>"] Collateral asset
        /// </summary>
        [JsonPropertyName("collateralCurrency")]
        public string CollateralAsset { get; set; } = string.Empty;
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
        /// ["<c>initialCollateralAmount</c>"] Initial collateral quantity
        /// </summary>
        [JsonPropertyName("initialCollateralAmount")]
        public decimal InitialCollateralQuantity { get; set; }
        /// <summary>
        /// ["<c>initialLoanAmount</c>"] Initial loan quantity
        /// </summary>
        [JsonPropertyName("initialLoanAmount")]
        public decimal InitialLoanQuantity { get; set; }
        /// <summary>
        /// ["<c>loanCurrency</c>"] Loan asset
        /// </summary>
        [JsonPropertyName("loanCurrency")]
        public string LoanAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>loanTerm</c>"] Loan term
        /// </summary>
        [JsonPropertyName("loanTerm")]
        public LoanTerm? LoanTerm { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>repaidInterest</c>"] Repaid interest
        /// </summary>
        [JsonPropertyName("repaidInterest")]
        public decimal RepaidInterest { get; set; }
        /// <summary>
        /// ["<c>repaidPenaltyInterest</c>"] Repaid penalty interest
        /// </summary>
        [JsonPropertyName("repaidPenaltyInterest")]
        public decimal RepaidPenaltyInterest { get; set; }
        /// <summary>
        /// ["<c>status</c>"] Status
        /// </summary>
        [JsonPropertyName("status")]
        public LoanStatus Status { get; set; }
    }


}
