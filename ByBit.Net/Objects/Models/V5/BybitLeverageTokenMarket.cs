using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Leverage token market info
    /// </summary>
    [SerializationModel]
    public record BybitLeverageTokenMarket
    {
        /// <summary>
        /// ["<c>basket</c>"] Basket
        /// </summary>
        [JsonPropertyName("basket")]
        public decimal Basket { get; set; }
        /// <summary>
        /// ["<c>circulation</c>"] Circulating supply in the secondary market
        /// </summary>
        [JsonPropertyName("circulation")]
        public decimal Circulation { get; set; }
        /// <summary>
        /// ["<c>leverage</c>"] Real leverage calculated by last traded price
        /// </summary>
        [JsonPropertyName("leverage")]
        public decimal Leverage { get; set; }
        /// <summary>
        /// ["<c>nav</c>"] Net value
        /// </summary>
        [JsonPropertyName("nav")]
        public decimal Nav { get; set; }
        /// <summary>
        /// Update time for net asset value
        /// </summary>
        [JsonPropertyName("navTime"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime NavTime { get; set; }
        /// <summary>
        /// ["<c>ltCoin</c>"] Token name
        /// </summary>
        [JsonPropertyName("ltCoin")]
        public string Token { get; set; } = string.Empty;
    }
}
