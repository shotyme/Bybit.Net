using CryptoExchange.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Transfer direction
    /// </summary>
    [JsonConverter(typeof(EnumConverter<TransferDirection>))]
    public enum TransferDirection
    {
        /// <summary>
        /// ["<c>I</c>"] In
        /// </summary>
        [Map("I")]
        In,
        /// <summary>
        /// ["<c>O</c>"] Out
        /// </summary>
        [Map("O")]
        Out,
    }

}
