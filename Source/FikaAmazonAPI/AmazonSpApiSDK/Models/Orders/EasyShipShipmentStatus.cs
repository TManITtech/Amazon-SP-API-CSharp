﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// The status of the Amazon Easy Ship order. This property is included only for Amazon Easy Ship orders.
    /// </summary>
    /// <value>The status of the Amazon Easy Ship order. This property is included only for Amazon Easy Ship orders.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum EasyShipShipmentStatus
    {

        /// <summary>
        /// Enum PendingSchedule for value: PendingSchedule
        /// </summary>
        [EnumMember(Value = "PendingSchedule")]
        PendingSchedule = 1,

        /// <summary>
        /// Enum PendingPickUp for value: PendingPickUp
        /// </summary>
        [EnumMember(Value = "PendingPickUp")]
        PendingPickUp = 2,

        /// <summary>
        /// Enum PendingDropOff for value: PendingDropOff
        /// </summary>
        [EnumMember(Value = "PendingDropOff")]
        PendingDropOff = 3,

        /// <summary>
        /// Enum LabelCanceled for value: LabelCanceled
        /// </summary>
        [EnumMember(Value = "LabelCanceled")]
        LabelCanceled = 4,

        /// <summary>
        /// Enum PickedUp for value: PickedUp
        /// </summary>
        [EnumMember(Value = "PickedUp")]
        PickedUp = 5,

        /// <summary>
        /// Enum DroppedOff for value: DroppedOff
        /// </summary>
        [EnumMember(Value = "DroppedOff")]
        DroppedOff = 6,

        /// <summary>
        /// Enum AtOriginFC for value: AtOriginFC
        /// </summary>
        [EnumMember(Value = "AtOriginFC")]
        AtOriginFC = 7,

        /// <summary>
        /// Enum AtDestinationFC for value: AtDestinationFC
        /// </summary>
        [EnumMember(Value = "AtDestinationFC")]
        AtDestinationFC = 8,

        /// <summary>
        /// Enum Delivered for value: Delivered
        /// </summary>
        [EnumMember(Value = "Delivered")]
        Delivered = 9,

        /// <summary>
        /// Enum RejectedByBuyer for value: RejectedByBuyer
        /// </summary>
        [EnumMember(Value = "RejectedByBuyer")]
        RejectedByBuyer = 10,

        /// <summary>
        /// Enum Undeliverable for value: Undeliverable
        /// </summary>
        [EnumMember(Value = "Undeliverable")]
        Undeliverable = 11,

        /// <summary>
        /// Enum ReturningToSeller for value: ReturningToSeller
        /// </summary>
        [EnumMember(Value = "ReturningToSeller")]
        ReturningToSeller = 12,

        /// <summary>
        /// Enum ReturnedToSeller for value: ReturnedToSeller
        /// </summary>
        [EnumMember(Value = "ReturnedToSeller")]
        ReturnedToSeller = 13,

        /// <summary>
        /// Enum Lost for value: Lost
        /// </summary>
        [EnumMember(Value = "Lost")]
        Lost = 14,

        /// <summary>
        /// Enum OutForDelivery for value: OutForDelivery
        /// </summary>
        [EnumMember(Value = "OutForDelivery")]
        OutForDelivery = 15,

        /// <summary>
        /// Enum Damaged for value: Damaged
        /// </summary>
        [EnumMember(Value = "Damaged")]
        Damaged = 16
    }

}

