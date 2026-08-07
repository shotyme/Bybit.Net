using Bybit.Net.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Account balance overview
    /// </summary>
    public record BybitAccountOverview
    {
        /// <summary>
        /// ["<c>totalEquity</c>"] Total equity
        /// </summary>
        [JsonPropertyName("totalEquity")]
        public decimal TotalEquity { get; set; }
        /// <summary>
        /// ["<c>list</c>"] List
        /// </summary>
        [JsonPropertyName("list")]
        public BybitAccountOverviewAccount[] List { get; set; } = [];
    }

    /// <summary>
    /// Account overview
    /// </summary>
    public record BybitAccountOverviewAccount
    {
        /// <summary>
        /// ["<c>totalEquity</c>"] Total equity
        /// </summary>
        [JsonPropertyName("totalEquity")]
        public decimal TotalEquity { get; set; }
        /// <summary>
        /// ["<c>valuationCurrency</c>"] Valuation asset
        /// </summary>
        [JsonPropertyName("valuationCurrency")]
        public string ValuationAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>accountType</c>"] Account type
        /// </summary>
        [JsonPropertyName("accountType")]
        public AssetAccountType AccountType { get; set; }
        /// <summary>
        /// ["<c>coinDetail</c>"] Asset detail
        /// </summary>
        [JsonPropertyName("coinDetail")]
        public BybitAccountOverviewAccountDetails[] AssetDetail { get; set; } = [];
        /// <summary>
        /// ["<c>categories</c>"] Account categories
        /// </summary>
        [JsonPropertyName("categories")]
        public BybitAccountOverviewAccountCategory[] Categories { get; set; } = [];
        /// <summary>
        /// ["<c>snapshotTime</c>"] Snapshot time
        /// </summary>
        [JsonPropertyName("snapshotTime")]
        public DateTime SnapshotTime { get; set; }
    }

    /// <summary>
    /// Category overview
    /// </summary>
    public record BybitAccountOverviewAccountCategory
    {
        /// <summary>
        /// ["<c>category</c>"] Category
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>equity</c>"] Equity
        /// </summary>
        [JsonPropertyName("equity")]
        public decimal Equity { get; set; }
        /// <summary>
        /// ["<c>coinDetail</c>"] Asset detail
        /// </summary>
        [JsonPropertyName("coinDetail")]
        public BybitAccountOverviewAccountDetails[] AssetDetail { get; set; } = [];
    }

    /// <summary>
    /// Asset overview
    /// </summary>
    public record BybitAccountOverviewAccountDetails
    {
        /// <summary>
        /// ["<c>equity</c>"] Equity
        /// </summary>
        [JsonPropertyName("equity")]
        public decimal Equity { get; set; }
        /// <summary>
        /// ["<c>coin</c>"] Asset
        /// </summary>
        [JsonPropertyName("coin")]
        public string Asset { get; set; } = string.Empty;
    }


}
