using System;
using System.Text.Json.Serialization;
using Bybit.Net.Enums;

namespace Bybit.Net.Objects.Models.V5;

internal record BybitOptionAssetInfoWrapper
{
    /// <summary>
    /// ["<c>result</c>"] Result
    /// </summary>
    [JsonPropertyName("result")]
    public BybitOptionAssetInfo[] Result { get; set; } = [];
}

/// <summary>
/// Asset info
/// </summary>
public record BybitOptionAssetInfo
{
    /// <summary>
    /// ["<c>totalDelta</c>"] Total delta. Only includes delta from option positions
    /// </summary>
    [JsonPropertyName("totalDelta")]
    public decimal TotalDelta { get; set; }
    /// <summary>
    /// ["<c>assetIM</c>"] Asset initial margin. Includes IM occupied by option open orders
    /// </summary>
    [JsonPropertyName("assetIM")]
    public decimal AssetIM { get; set; }
    /// <summary>
    /// ["<c>totalUPL</c>"] Total unrealised profit and loss
    /// </summary>
    [JsonPropertyName("totalUPL")]
    public decimal TotalUPL { get; set; }
    /// <summary>
    /// ["<c>totalRPL</c>"] Total realised profit and loss
    /// </summary>
    [JsonPropertyName("totalRPL")]
    public decimal TotalRPL { get; set; }
    /// <summary>
    /// ["<c>assetMM</c>"] Asset maintenance margin. Includes MM occupied by option open orders
    /// </summary>
    [JsonPropertyName("assetMM")]
    public decimal AssetMM { get; set; }
    /// <summary>
    /// ["<c>coin</c>"] Asset
    /// </summary>
    [JsonPropertyName("coin")]
    public string Asset { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>sendTime</c>"] Timestamp
    /// </summary>
    [JsonPropertyName("sendTime")]
    public DateTime Timestamp { get; set; }
}

