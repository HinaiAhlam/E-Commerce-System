using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.models
{
    public class OrderItem
    {
        [Key] // Primary Key
        public int OrderItemId { get; set; }

        [Required] // Required
        public int Quantity { get; set; } // Attribute

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [ForeignKey("Order")] // Foreign Key
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; } // Navigation Property


        [ForeignKey("Product")] // Foreign Key
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }

    }
}
