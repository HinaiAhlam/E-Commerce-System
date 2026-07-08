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
<<<<<<< HEAD
        public virtual Order? Order { get; set; } // Navigation Property
=======
        public Order? Order { get; set; } // Navigation Property
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336


        [ForeignKey("Product")] // Foreign Key
        public int ProductId { get; set; }
<<<<<<< HEAD
        public virtual Product? Product { get; set; }
=======
        public Product? Product { get; set; }
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336

    }
}
