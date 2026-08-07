using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Sub account type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SubAccountType>))]
    public enum SubAccountType
    {
        /// <summary>
        /// ["<c>1</c>"] Normal account
        /// </summary>
        [Map("1")]
        NormalAccount,
        /// <summary>
        /// ["<c>6</c>"] Custodial account
        /// </summary>
        [Map("6")]
        CustodialAccount
    }
}
