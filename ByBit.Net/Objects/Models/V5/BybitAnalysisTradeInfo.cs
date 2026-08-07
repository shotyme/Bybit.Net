using System;
using System.Text.Json.Serialization;
using Bybit.Net.Enums;

namespace Bybit.Net.Objects.Models.V5;

/// <summary>
/// Trade info
/// </summary>
public record BybitAnalysisTradeInfo
{
    /// <summary>
    /// ["<c>symbolRnl</c>"] Symbol realized profit and loss
    /// </summary>
    [JsonPropertyName("symbolRnl")]
    public decimal RealizedPnl { get; set; }
    /// <summary>
    /// ["<c>sumBuyExecValue</c>"] Total buy execution value
    /// </summary>
    [JsonPropertyName("sumBuyExecValue")]
    public decimal SumBuyExecValue { get; set; }
    /// <summary>
    /// ["<c>sumBuyExecQty</c>"] Total buy execution quantity
    /// </summary>
    [JsonPropertyName("sumBuyExecQty")]
    public decimal SumBuyExecQuantity { get; set; }
    /// <summary>
    /// ["<c>sumSellExecFee</c>"] Total sell execution fee
    /// </summary>
    [JsonPropertyName("sumSellExecFee")]
    public decimal SumSellExecFee { get; set; }
    /// <summary>
    /// ["<c>netExecQty</c>"] Net execution quantity
    /// </summary>
    [JsonPropertyName("netExecQty")]
    public decimal NetExecQuantity { get; set; }
    /// <summary>
    /// ["<c>sumExecQty</c>"] Total execution quantity
    /// </summary>
    [JsonPropertyName("sumExecQty")]
    public decimal SumExecQuantity { get; set; }
    /// <summary>
    /// ["<c>settleCoin</c>"] Settle asset
    /// </summary>
    [JsonPropertyName("settleCoin")]
    public string SettleAsset { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>sumExecValue</c>"] Total execution value
    /// </summary>
    [JsonPropertyName("sumExecValue")]
    public decimal SumExecValue { get; set; }
    /// <summary>
    /// ["<c>sumSellExecValue</c>"] Total sell execution value
    /// </summary>
    [JsonPropertyName("sumSellExecValue")]
    public decimal SumSellExecValue { get; set; }
    /// <summary>
    /// ["<c>sumBuyOrderQty</c>"] Total buy order quantity
    /// </summary>
    [JsonPropertyName("sumBuyOrderQty")]
    public decimal SumBuyOrderQuantity { get; set; }
    /// <summary>
    /// ["<c>sumSellOrderQty</c>"] Total sell order quantity
    /// </summary>
    [JsonPropertyName("sumSellOrderQty")]
    public decimal SumSellOrderQuantity { get; set; }
    /// <summary>
    /// ["<c>maxMarginVersion</c>"] Max margin version number
    /// </summary>
    [JsonPropertyName("maxMarginVersion")]
    public decimal MaxMarginVersion { get; set; }
    /// <summary>
    /// ["<c>avgSellExecPrice</c>"] Average sell execution price
    /// </summary>
    [JsonPropertyName("avgSellExecPrice")]
    public decimal AverageSellExecPrice { get; set; }
    /// <summary>
    /// ["<c>avgBuyExecPrice</c>"] Average buy exec price
    /// </summary>
    [JsonPropertyName("avgBuyExecPrice")]
    public decimal AverageBuyExecPrice { get; set; }
    /// <summary>
    /// ["<c>sumBuyExecFee</c>"] Total buy execution fee
    /// </summary>
    [JsonPropertyName("sumBuyExecFee")]
    public decimal SumBuyExecFee { get; set; }
    /// <summary>
    /// ["<c>sumSellExecQty</c>"] Total sell execution quantity
    /// </summary>
    [JsonPropertyName("sumSellExecQty")]
    public decimal SumSellExecQuantity { get; set; }
    /// <summary>
    /// ["<c>baseCoin</c>"] Base asset
    /// </summary>
    [JsonPropertyName("baseCoin")]
    public string BaseAsset { get; set; } = string.Empty;
    /// <summary>
    /// Stats per day
    /// </summary>
    [JsonPropertyName("sumPriceList")]
    public BybitAnalysisTradeDayInfo[] DayStatistics { get; set; } = [];
}

/// <summary>
/// Day info
/// </summary>
public record BybitAnalysisTradeDayInfo
{
    /// <summary>
    /// ["<c>sumSellExecValue</c>"] Total sell value
    /// </summary>
    [JsonPropertyName("sumSellExecValue")]
    public decimal SumSellExecValue { get; set; }
    /// <summary>
    /// ["<c>sumExecValue</c>"] Total value
    /// </summary>
    [JsonPropertyName("sumExecValue")]
    public decimal SumExecValue { get; set; }
    /// <summary>
    /// ["<c>sumBuyExecValue</c>"] Total buy value
    /// </summary>
    [JsonPropertyName("sumBuyExecValue")]
    public decimal SumBuyExecValue { get; set; }
    /// <summary>
    /// ["<c>day</c>"]
    /// </summary>
    [JsonPropertyName("day")]
    public DateTime Day { get; set; }
}