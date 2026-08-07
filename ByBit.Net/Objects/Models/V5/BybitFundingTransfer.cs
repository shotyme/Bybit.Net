using Bybit.Net.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Transfer info
    /// </summary>
    public record BybitFundingTransfer
    {
        /// <summary>
        /// ["<c>memberId</c>"] Member id
        /// </summary>
        [JsonPropertyName("memberId")]
        public string MemberId { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>currency</c>"] Asset
        /// </summary>
        [JsonPropertyName("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>ioDirection</c>"] Direction
        /// </summary>
        [JsonPropertyName("ioDirection")]
        public TransferDirection Direction { get; set; }
        /// <summary>
        /// ["<c>txnAmt</c>"] Transaction quantity
        /// </summary>
        [JsonPropertyName("txnAmt")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// ["<c>afterAmt</c>"] Balance after transaction
        /// </summary>
        [JsonPropertyName("afterAmt")]
        public decimal BalanceAfter { get; set; }
        /// <summary>
        /// ["<c>createTime</c>"] Create time
        /// </summary>
        [JsonPropertyName("createTime")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// ["<c>showBusiType</c>"] Business type
        /// </summary>
        [JsonPropertyName("showBusiType")]
        public string ShowBusiType { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>showBusiTypeEn</c>"] Business type in english
        /// </summary>
        [JsonPropertyName("showBusiTypeEn")]
        public string ShowBusiTypeEn { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>description</c>"] Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>descriptionEn</c>"] Description in english
        /// </summary>
        [JsonPropertyName("descriptionEn")]
        public string DescriptionEnglish { get; set; } = string.Empty;
    }


}
