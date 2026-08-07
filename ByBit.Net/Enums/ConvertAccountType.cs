using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Convert account type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<ConvertAccountType>))]
    public enum ConvertAccountType
    {
        /// <summary>
        /// ["<c>eb_convert_funding</c>"] Funding account
        /// </summary>
        [Map("eb_convert_funding")]
        ConvertFunding,
        /// <summary>
        /// ["<c>eb_convert_uta</c>"] UTA account
        /// </summary>
        [Map("eb_convert_uta")]
        ConvertUta,
        /// <summary>
        /// ["<c>eb_convert_spot</c>"] Spot account
        /// </summary>
        [Map("eb_convert_spot")]
        ConvertSpot,
        /// <summary>
        /// ["<c>eb_convert_contract</c>"] Contract account
        /// </summary>
        [Map("eb_convert_contract")]
        ConvertContract,
        /// <summary>
        /// ["<c>eb_convert_inverse</c>"] Inverse account
        /// </summary>
        [Map("eb_convert_inverse")]
        ConvertInverse
    }
}
