using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Time in force
    /// </summary>
    [JsonConverter(typeof(EnumConverter<TimeInForce>))]
    public enum TimeInForce
    {
        /// <summary>
        /// ["<c>GTC</c>"] Good till canceled by user
        /// </summary>
        [Map("GTC")]
        GoodTillCanceled,
        /// <summary>
        /// ["<c>IOC</c>"] Fill at least partially upon placing or cancel
        /// </summary>
        [Map("IOC")]
        ImmediateOrCancel,
        /// <summary>
        /// ["<c>FOK</c>"] Fill fully upon placing or cancel
        /// </summary>
        [Map("FOK")]
        FillOrKill,
        /// <summary>
        /// ["<c>PostOnly</c>"] Only place order if the order is added to the order book instead of being filled immediately
        /// </summary>
        [Map("PostOnly")]
        PostOnly,
        /// <summary>
        /// ["<c>RPI</c>"] Retail Price Improvement orders act as PostOnly orders but also do cannot match with algorithmic (API) orders. See https://www.bybit.nl/nl-NL/help-center/article/Retail-Price-Improvement-RPI-Order
        /// </summary>
        [Map("RPI")]
        RetailPriceImprovement
    }
}
