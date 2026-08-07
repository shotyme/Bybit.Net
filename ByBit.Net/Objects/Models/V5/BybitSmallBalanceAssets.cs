using Bybit.Net.Converters;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Small balance assets
    /// </summary>
    public record BybitSmallBalanceAssets
    {
        /// <summary>
        /// ["<c>smallAssetCoins</c>"] Small balances
        /// </summary>
        [JsonPropertyName("smallAssetCoins")]
        public BybitSmallBalanceAsset[] SmallBalanceAssets { get; set; } = [];
        /// <summary>
        /// ["<c>supportToCoins</c>"] Supported to assets
        /// </summary>
        [JsonPropertyName("supportToCoins")]
        public string[] SupportToAssets { get; set; } = [];
    }

    /// <summary>
    /// Asset info
    /// </summary>
    public record BybitSmallBalanceAsset
    {
        /// <summary>
        /// ["<c>fromCoin</c>"] From asset
        /// </summary>
        [JsonPropertyName("fromCoin")]
        public string FromAsset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>availableBalance</c>"] Available balance
        /// </summary>
        [JsonPropertyName("availableBalance")]
        public decimal AvailableBalance { get; set; }
        /// <summary>
        /// ["<c>baseValue</c>"] USDT value
        /// </summary>
        [JsonPropertyName("baseValue")]
        public decimal BaseValue { get; set; }
        /// <summary>
        /// ["<c>supportConvert</c>"] Conversion is supported
        /// </summary>
        [JsonConverter(typeof(Bool12Converter))]
        [JsonPropertyName("supportConvert")]
        public bool Supported { get; set; }
    }
}
