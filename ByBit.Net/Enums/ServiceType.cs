using CryptoExchange.Net.Attributes;
using System.Text.Json.Serialization;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Service types
    /// </summary>
    [JsonConverter(typeof(EnumConverter<ServiceType>))]
    public enum ServiceType
    {
        /// <summary>
        /// ["<c>1</c>"] Trading service
        /// </summary>
        [Map("1")]
        TradingService,
        /// <summary>
        /// ["<c>2</c>"] Trading service REST
        /// </summary>
        [Map("2")]
        RestTradingService,
        /// <summary>
        /// ["<c>3</c>"] Trading service Websocket
        /// </summary>
        [Map("3")]
        WebsocketTradingService,
        /// <summary>
        /// ["<c>4</c>"] Private websocket stream
        /// </summary>
        [Map("4")]
        PrivateWebsocketStream,
        /// <summary>
        /// ["<c>5</c>"] Market data service
        /// </summary>
        [Map("5")]
        MarketDataService
    }
}
