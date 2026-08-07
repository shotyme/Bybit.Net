using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Leverage token status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<LeverageTokenStatus>))]
    public enum LeverageTokenStatus
    {
        /// <summary>
        /// ["<c>1</c>"] Purchaseable and redeemable
        /// </summary>
        [Map("1")]
        YesPurchaseYesRedeem,
        /// <summary>
        /// ["<c>2</c>"] Purchasable but not redeemable
        /// </summary>
        [Map("2")]
        YesPurchaseNoRedeem,
        /// <summary>
        /// ["<c>3</c>"] Not purchasable but is redeemable
        /// </summary>
        [Map("3")]
        NoPurchaseYesRedeem,
        /// <summary>
        /// ["<c>4</c>"] Not purchasable or redeemable
        /// </summary>
        [Map("4")]
        NoPurchaseNoRedeem,
        /// <summary>
        /// ["<c>5</c>"] Adjusting position
        /// </summary>
        [Map("5")]
        AdjustingPosition
    }
}
