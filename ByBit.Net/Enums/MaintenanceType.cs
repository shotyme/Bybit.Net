using CryptoExchange.Net.Attributes;
using System.Text.Json.Serialization;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Maintenance types
    /// </summary>
    [JsonConverter(typeof(EnumConverter<MaintenanceType>))]
    public enum MaintenanceType
    {
        /// <summary>
        /// ["<c>1</c>"] Planned maintenance
        /// </summary>
        [Map("1")]
        PlannedMaintenance,
        /// <summary>
        /// ["<c>2</c>"] Temporary maintenance
        /// </summary>
        [Map("2")]
        TemporaryMaintenance,
        /// <summary>
        /// ["<c>3</c>"] Incident
        /// </summary>
        [Map("3")]
        Incident
    }
}
