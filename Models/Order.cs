using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreChineesDragon.Models
{
    public enum OrderedThrough
    {
        Online,
        POS
    }

    public enum OrderType
    {
        Dynein,
        TakeAway
    }

    public enum OrderItems
    {
        SeaFoodRice,
        ChiliChickenCurry,
        SpicyNoodle
    }

    public enum OrderStatuses
    {
        InQueue,
        Preparing,
        OrderReady,
        PickedUp,
        Canceled
    }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Referance Number is required.")]
        [DisplayName("Referance Number")]
        public string ReferanceNumber { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Order Date Time")]
        public DateTime OrderDateTime { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Ordered Through")]
        public OrderedThrough OrderedThrough { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Order Type")]
        public OrderType OrderType { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Order Items")]
        public OrderItems OrderItems { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Order Statuses")]
        public OrderStatuses OrderStatuses { get; set; }

    }
}
