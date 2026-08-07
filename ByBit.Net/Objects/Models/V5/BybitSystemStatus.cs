using Bybit.Net.Enums;
using System;
using System.Text.Json.Serialization;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// System status info
    /// </summary>
    public record BybitSystemStatus
    {
        /// <summary>
        /// ["<c>id</c>"] Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>title</c>"] Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// ["<c>state</c>"] Status
        /// </summary>
        [JsonPropertyName("state")]
        public SystemStatus Status { get; set; }
        /// <summary>
        /// ["<c>begin</c>"] Begin time
        /// </summary>
        [JsonPropertyName("begin")]
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// ["<c>end</c>"] End time
        /// </summary>
        [JsonPropertyName("end")]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// ["<c>href</c>"] Link
        /// </summary>
        [JsonPropertyName("href")]
        public string? Link { get; set; }
        /// <summary>
        /// ["<c>serviceTypes</c>"] Service types
        /// </summary>
        [JsonPropertyName("serviceTypes")]
        public ServiceType[] ServiceTypes { get; set; } = [];
        /// <summary>
        /// ["<c>product</c>"] Product
        /// </summary>
        [JsonPropertyName("product")]
        public ProductType[] Product { get; set; } = [];
        /// <summary>
        /// ["<c>uidSuffix</c>"] Uid suffix
        /// </summary>
        [JsonPropertyName("uidSuffix")]
        public string[] UidSuffix { get; set; } = [];
        /// <summary>
        /// ["<c>maintainType</c>"] Maintenance type
        /// </summary>
        [JsonPropertyName("maintainType")]
        public MaintenanceType MaintenanceType { get; set; }
        /// <summary>
        /// ["<c>env</c>"] Environment
        /// </summary>
        [JsonPropertyName("env")]
        public SystemEnvironment Environment { get; set; }
    }


}
