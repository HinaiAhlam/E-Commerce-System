using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.models
{
    public class Category
    {
        [Key]// auto-generated
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId {  get; set; }//system generated

        [Required]
        [MaxLength(100)]
        public string? CategoryName { get; set; }//user input

        [MaxLength(500)]
        public string? Description { get; set; }//user input

        [MaxLength(300)]
        public string? ImageUrl { get; set; }//user input

        public List<Product>? Products { get; set; }


    }
}
