using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Repayment info
    /// </summary>
    [SerializationModel]
    public record BybitRepayment
    {
        /// <summary>
        /// ["<c>collateralCurrency</c>"] Collateral asset
        /// </summary>
        [JsonPropertyName("collateralCurrency")]
        public string CollateralAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>collateralReturn</c>"] Collateral return
        /// </summary>
        [JsonPropertyName("collateralReturn")]
        public decimal CollateralReturn { get; set; }
        /// <summary>
        /// ["<c>loanCurrency</c>"] Loan asset
        /// </summary>
        [JsonPropertyName("loanCurrency")]
        public string LoanAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>loanTerm</c>"] Loan term
        /// </summary>
        [JsonPropertyName("loanTerm")]
        public string? LoanTerm { get; set; }
        /// <summary>
        /// ["<c>orderId</c>"] Order id
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>repayAmount</c>"] Repay quantity
        /// </summary>
        [JsonPropertyName("repayAmount")]
        public decimal RepayQuantity { get; set; }
        /// <summary>
        /// ["<c>repayId</c>"] Repay id
        /// </summary>
        [JsonPropertyName("repayId")]
        public string RepayId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>repayStatus</c>"] Repay status
        /// </summary>
        [JsonPropertyName("repayStatus")]
        public RepayStatus? RepayStatus { get; set; }
        /// <summary>
        /// ["<c>repayTime</c>"] Repay time
        /// </summary>
        [JsonPropertyName("repayTime")]
        public DateTime? RepayTime { get; set; }
        /// <summary>
        /// ["<c>repayType</c>"] Repay type
        /// </summary>
        [JsonPropertyName("repayType")]
        public RepayType? RepayType { get; set; }
    }


}
