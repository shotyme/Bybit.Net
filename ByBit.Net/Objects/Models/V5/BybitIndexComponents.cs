using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Index components
    /// </summary>
    public record BybitIndexComponents
    {
        /// <summary>
        /// ["<c>indexName</c>"] Index name
        /// </summary>
        [JsonPropertyName("indexName")]
        public string IndexName { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>lastPrice</c>"] Last price
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public decimal LastPrice { get; set; }
        /// <summary>
        /// ["<c>updateTime</c>"] Update time
        /// </summary>
        [JsonPropertyName("updateTime")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// ["<c>components</c>"] The components
        /// </summary>
        [JsonPropertyName("components")]
        public BybitIndexComponent[] Components { get; set; } = [];
    }

    /// <summary>
    /// Index component
    /// </summary>
    public record BybitIndexComponent
    {
        /// <summary>
        /// ["<c>exchange</c>"] Exchange name
        /// </summary>
        [JsonPropertyName("exchange")]
        public string Exchange { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>spotPair</c>"] Symbol
        /// </summary>
        [JsonPropertyName("spotPair")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>equivalentPrice</c>"] Equivalent price
        /// </summary>
        [JsonPropertyName("equivalentPrice")]
        public decimal EquivalentPrice { get; set; }
        /// <summary>
        /// ["<c>multiplier</c>"] Multiplier used for the component price
        /// </summary>
        [JsonPropertyName("multiplier")]
        public decimal Multiplier { get; set; }
        /// <summary>
        /// ["<c>price</c>"] Actual price
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        /// <summary>
        /// ["<c>weight</c>"] Weight in the index calculation
        /// </summary>
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

    }
}
