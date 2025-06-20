
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    public class BybitAvailableBalance
    {
        [JsonPropertyName("availableWithdrawal")]
        public decimal? Available { get; set; }
    }
}
