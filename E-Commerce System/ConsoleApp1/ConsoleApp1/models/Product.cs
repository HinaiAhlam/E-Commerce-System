using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId {  get; set; }//system generated

        [Required]
        [MaxLength(150)]
        public string? ProductName { get; set; }//user input 

        [MaxLength(1000)]
        public string? Description { get; set; }//user input 

        [Required]
        [Range(0.01,double.MaxValue)]
        [Precision(18, 2)]
        public decimal Price { get; set; }//user input 

        [Required]
        [Range(0,int.MaxValue)]

        public int StockQuantity { get; set; }//defoult value

        [MaxLength(300)]
        public string? ImageUrl { get; set; }////user input 

        [Required]
        [ForeignKey("category")]
        public int CategoryId { get; set; }//foreign key 


        [Required]
        public DateTime CreatedAt { get; set; }//system generated

        [Required]
        public bool IsAvailable { get; set; }//defoult value

<<<<<<< HEAD
        public virtual Category? Category { get; set; }

        public List<Review>? Reviews { get; set; }

        public virtual List<OrderItem>? OrderItems { get; set; }
        public virtual List<Order> Orders { get; set; }= new List<Order>();
=======
        public Category? Category { get; set; }

        public List<Review>? Reviews { get; set; }

        public List<OrderItem>? OrderItems { get; set; }
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
    }
}
