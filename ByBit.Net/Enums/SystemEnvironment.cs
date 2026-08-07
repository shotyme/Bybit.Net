using CryptoExchange.Net.Attributes;
using System.Text.Json.Serialization;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// System environment
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SystemEnvironment>))]
    public enum SystemEnvironment
    {
        /// <summary>
        /// ["<c>1</c>"] Production
        /// </summary>
        [Map("1")]
        Production,
        /// <summary>
        /// ["<c>2</c>"] Production demo services
        /// </summary>
        [Map("2")]
        DemoServices
    }
}
