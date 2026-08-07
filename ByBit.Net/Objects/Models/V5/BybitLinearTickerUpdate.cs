using Bybit.Net.Enums;
using System.Text.Json.Serialization;
using System;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Ticker update
    /// </summary>
    [SerializationModel]
    public record BybitLinearTickerUpdate
    {
        /// <summary>
        /// ["<c>symbol</c>"] Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>tickDirection</c>"] Tick direction
        /// </summary>

        [JsonPropertyName("tickDirection")]
        public TickDirection? TickDirection { get; set; }
        /// <summary>
        /// ["<c>price24hPcnt</c>"] Price change percentage since 24h ago
        /// </summary>
        [JsonPropertyName("price24hPcnt")]
        public decimal? PricePercentage24h { get; set; }
        /// <summary>
        /// ["<c>lastPrice</c>"] Last price
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public decimal? LastPrice { get; set; }
        /// <summary>
        /// ["<c>highPrice24h</c>"] High price in last 24h
        /// </summary>
        [JsonPropertyName("highPrice24h")]
        public decimal? HighPrice24h { get; set; }
        /// <summary>
        /// ["<c>lowPrice24h</c>"] Low price in last 24h
        /// </summary>
        [JsonPropertyName("lowPrice24h")]
        public decimal? LowPrice24h { get; set; }
        /// <summary>
        /// ["<c>prevPrice24h</c>"] Previous price in last 24h
        /// </summary>
        [JsonPropertyName("prevPrice24h")]
        public decimal? PreviousPrice24h { get; set; }
        /// <summary>
        /// ["<c>prevPrice1h</c>"] Previous price in last hour
        /// </summary>
        [JsonPropertyName("prevPrice1h")]
        public decimal? PreviousPrice1h { get; set; }
        /// <summary>
        /// ["<c>markPrice</c>"] Mark price
        /// </summary>
        [JsonPropertyName("markPrice")]
        public decimal? MarkPrice { get; set; }
        /// <summary>
        /// ["<c>indexPrice</c>"] Index price
        /// </summary>
        [JsonPropertyName("indexPrice")]
        public decimal? IndexPrice { get; set; }
        /// <summary>
        /// ["<c>openInterest</c>"] Open interest
        /// </summary>
        [JsonPropertyName("openInterest")]
        public decimal? OpenInterest { get; set; }
        /// <summary>
        /// ["<c>openInterestValue</c>"] Open interest value
        /// </summary>
        [JsonPropertyName("openInterestValue")]
        public decimal? OpenInterestValue { get; set; }
        /// <summary>
        /// ["<c>turnover24h</c>"] 24 hour turnover
        /// </summary>
        [JsonPropertyName("turnover24h")]
        public decimal? Turnover24h { get; set; }
        /// <summary>
        /// ["<c>volume24h</c>"] 24 hour volume
        /// </summary>
        [JsonPropertyName("volume24h")]
        public decimal? Volume24h { get; set; }
        /// <summary>
        /// ["<c>nextFundingTime</c>"] Next funding time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        [JsonPropertyName("nextFundingTime")]
        public DateTime? NextFundingTime { get; set; }
        /// <summary>
        /// ["<c>fundingRate</c>"] Funding rate
        /// </summary>
        [JsonPropertyName("fundingRate")]
        public decimal? FundingRate { get; set; }
        /// <summary>
        /// ["<c>bid1Price</c>"] Best bid price
        /// </summary>
        [JsonPropertyName("bid1Price")]
        public decimal? BestBidPrice { get; set; }
        /// <summary>
        /// ["<c>bid1Size</c>"] Best bid quantity
        /// </summary>
        [JsonPropertyName("bid1Size")]
        public decimal? BestBidQuantity { get; set; }
        /// <summary>
        /// ["<c>ask1Price</c>"] Best ask price
        /// </summary>
        [JsonPropertyName("ask1Price")]
        public decimal? BestAskPrice { get; set; }
        /// <summary>
        /// ["<c>ask1Size</c>"] Best ask quantity
        /// </summary>
        [JsonPropertyName("ask1Size")]
        public decimal? BestAskQuantity { get; set; }
        /// <summary>
        /// ["<c>deliveryTime</c>"] [InverseFutures] Delivery time in UTC
        /// </summary>
        [JsonPropertyName("deliveryTime")]
        public DateTime? DeliveryTime { get; set; }
        /// <summary>
        /// ["<c>basisRate</c>"] [InverseFutures] Basis rate
        /// </summary>
        [JsonPropertyName("basisRate")]
        public decimal? BasisRate { get; set; }
        /// <summary>
        /// ["<c>deliveryFeeRate</c>"] [InverseFutures] Delivery fee rate
        /// </summary>
        [JsonPropertyName("deliveryFeeRate")]
        public decimal? DeliveryFeeRate { get; set; }
        /// <summary>
        /// ["<c>predictedDeliveryPrice</c>"] [InverseFutures] Predicted delivery price
        /// </summary>
        [JsonPropertyName("predictedDeliveryPrice")]
        public decimal? PredictedDeliveryPrice { get; set; }
        /// <summary>
        /// ["<c>preOpenPrice</c>"] Estimated pre-market contract open price
        /// </summary>
        [JsonPropertyName("preOpenPrice")]
        public decimal? PreOpenPrice { get; set; }
        /// <summary>
        /// ["<c>preQty</c>"] Estimated pre-market contract open qty
        /// </summary>
        [JsonPropertyName("preQty")]
        public decimal? PreOpenQuantity { get; set; }
        /// <summary>
        /// ["<c>curPreListingPhase</c>"] The current pre-market contract phase
        /// </summary>
        [JsonPropertyName("curPreListingPhase")]
        public AuctionPhase? PreListingPhase { get; set; }
        /// <summary>
        /// ["<c>fundingIntervalHour</c>"] Funding interval in hours
        /// </summary>
        [JsonPropertyName("fundingIntervalHour")]
        public int? FundingInterval { get; set; }
        /// <summary>
        /// ["<c>fundingCap</c>"] Funding rate upper and lower limits
        /// </summary>
        [JsonPropertyName("fundingCap")]
        public decimal? FundingCap { get; set; }
        /// <summary>
        /// ["<c>basisRateYear</c>"] Annual basis rate
        /// </summary>
        [JsonPropertyName("basisRateYear")]
        public decimal? BasisRateYear { get; set; }
    }
}
