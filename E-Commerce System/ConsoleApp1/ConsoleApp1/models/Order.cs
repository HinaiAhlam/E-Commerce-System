using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.models
{
    public class Order
    {
        [Key]//primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId {  get; set; }//system generated 

        [Required]
        [ForeignKey("User")]
        public int? UserId { get; set; }//ForeignKey

        [Required]
        public DateTime OrderDate { get; set; }//user input

        [Required]
        [Range(0, 0)]
        [Precision(18, 2)]
        public decimal TotalAmount { get; set; }//calclated

        [Required]
        [MaxLength(30)]
        public string? Status { get; set; } = "pending";//default value

        [Required] 
        [MaxLength(300)]
        public string? ShippingAddress { get; set; }//user input

        [Required]
        [MaxLength(50)]
        public string? PaymentMethod { get; set; }//user input

        public User? User { get; set; }//from list

        public List<OrderItem>? OrderItems { get; set; }

    }
}
