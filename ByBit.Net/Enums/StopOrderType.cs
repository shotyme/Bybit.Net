using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Stop order type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<StopOrderType>))]
    public enum StopOrderType
    {
        /// <summary>
        /// ["<c>TakeProfit</c>"] Take profit
        /// </summary>
        [Map("TakeProfit")]
        TakeProfit,
        /// <summary>
        /// ["<c>StopLoss</c>"] Stop loss
        /// </summary>
        [Map("StopLoss")]
        StopLoss,
        /// <summary>
        /// ["<c>TrailingStop</c>"] Trailing stop
        /// </summary>
        [Map("TrailingStop")]
        TrailingStop,
        /// <summary>
        /// ["<c>TrailingProfit</c>"] Trailing profit
        /// </summary>
        [Map("TrailingProfit")]
        TrailingProfit,
        /// <summary>
        /// ["<c>Stop</c>"] Stop
        /// </summary>
        [Map("Stop")]
        Stop,
        /// <summary>
        /// ["<c>PartialStopLoss</c>"] Partial stop loss
        /// </summary>
        [Map("PartialStopLoss")]
        PartialStopLoss,
        /// <summary>
        /// ["<c>PartialTakeProfit</c>"] Partial stop loss
        /// </summary>
        [Map("PartialTakeProfit")]
        PartialTakeProfit,
        /// <summary>
        /// ["<c>tpslOrder</c>"] Spot TP/SL order
        /// </summary>
        [Map("tpslOrder")]
        TpSlOrder,
        /// <summary>
        /// ["<c>OcoOrder</c>"] Oco Order
        /// </summary>
        [Map("OcoOrder")]
        OcoOrder,
        /// <summary>
        /// ["<c>MmRateClose</c>"] MmRateClose (only from web)
        /// </summary>
        [Map("MmRateClose")]
        MmRateClose,
        /// <summary>
        /// ["<c>BidirectionalTpslOrder</c>"] Spot bidirectional tpsl order
        /// </summary>
        [Map("BidirectionalTpslOrder")]
        BidirectionalTpslOrder,
        /// <summary>
        /// ["<c>Unknown</c>"] Unknown type
        /// </summary>
        [Map("Unknown")]
        Unknown
    }
}
