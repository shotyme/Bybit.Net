using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Account mode
    /// </summary>
    [JsonConverter(typeof(EnumConverter<AccountMode>))]
    public enum AccountMode
    {
        /// <summary>
        /// ["<c>1</c>"] Classic
        /// </summary>
        [Map("1")]
        Classic,
        /// <summary>
        /// ["<c>2</c>"] UMA
        /// </summary>
        [Map("2")]
        UniversalMarginAccount,
        /// <summary>
        /// ["<c>3</c>"] UTA
        /// </summary>
        [Map("3")]
        UniversalTransferAccount
    }
}
