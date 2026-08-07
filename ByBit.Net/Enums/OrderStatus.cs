using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;

namespace Bybit.Net.Enums
{
    /// <summary>
    /// Order status
    /// </summary>
    [JsonConverter(typeof(EnumConverter<OrderStatus>))]
    public enum OrderStatus
    {
        /// <summary>
        /// ["<c>Created</c>"] Created but not yet in matching engine
        /// </summary>
        [Map("Created")]
        Created,
        /// <summary>
        /// ["<c>New</c>"] Placed successfully
        /// </summary>
        [Map("New")]
        New,
        /// <summary>
        /// ["<c>Rejected</c>"] Rejected
        /// </summary>
        [Map("Rejected")]
        Rejected,
        /// <summary>
        /// ["<c>PartiallyFilled</c>"] Partially filled
        /// </summary>
        [Map("PartiallyFilled")]
        PartiallyFilled,
        /// <summary>
        /// ["<c>PartiallyFilledCanceled</c>"] Partially filled and cancelled
        /// </summary>
        [Map("PartiallyFilledCanceled")]
        PartiallyFilledCanceled,
        /// <summary>
        /// ["<c>Filled</c>"] Filled
        /// </summary>
        [Map("Filled")]
        Filled,
        /// <summary>
        /// ["<c>Cancelled</c>"] Cancelled
        /// </summary>
        [Map("Cancelled")]
        Cancelled,
        /// <summary>
        /// ["<c>Untriggered</c>"] Untriggered
        /// </summary>
        [Map("Untriggered")]
        Untriggered,
        /// <summary>
        /// ["<c>Triggered</c>"] Triggered
        /// </summary>
        [Map("Triggered")]
        Triggered,
        /// <summary>
        /// ["<c>Deactivated</c>"] Deactivated
        /// </summary>
        [Map("Deactivated")]
        Deactivated,
        /// <summary>
        /// ["<c>Active</c>"] Order has been triggered and the new active order has been successfully placed. Is the final state of a successful conditional order
        /// </summary>
        [Map("Active")]
        Active
    }
}
