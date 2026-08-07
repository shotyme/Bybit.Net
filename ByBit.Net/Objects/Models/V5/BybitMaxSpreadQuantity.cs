using System;
using System.Text.Json.Serialization;
using Bybit.Net.Enums;

namespace Bybit.Net.Objects.Models.V5;

/// <summary>
/// Max spread order quantity
/// </summary>
public record BybitMaxSpreadQuantity
{
    /// <summary>
    /// ["<c>ab</c>"] Max order quantity for spread order
    /// </summary>
    [JsonPropertyName("ab")]
    public decimal MaxOrderQuantity { get; set; }
}

