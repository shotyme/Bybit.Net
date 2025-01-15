using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bybit.Net.Objects.Models.V5
{
    public class BybitAvailableBalance
    {
        [JsonProperty("availableWithdrawal")]
        public decimal? Available { get; set; }
    }
}
