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
    /// Agreement category
    /// </summary>
    [JsonConverter(typeof(EnumConverter<AgreementCategory>))]
    public enum AgreementCategory
    {
        /// <summary>
        /// ["<c>2</c>"] Metals
        /// </summary>
        [Map("2")]
        Metals = 2,
        /// <summary>
        /// ["<c>3</c>"] Crude oil
        /// </summary>
        [Map("3")]
        CrudeOil = 3,
    }

}
