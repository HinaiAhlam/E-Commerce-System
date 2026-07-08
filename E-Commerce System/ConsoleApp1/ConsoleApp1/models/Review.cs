using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.models
{
    public class Review
    {
        [Key]//primary key auto generated 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ReviewId {  get; set; }//SYSTEM GENERATION

        [Required]
        [ForeignKey("User")]
        public int? UserId { get; set; }//ForeignKey

        [Required]
        [ForeignKey("product")]
        public int? ProductId { get; set; }//ForeignKey


<<<<<<< HEAD


=======
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
        [Required]
        [Range(1,5)]
        public int Rating { get; set; }//user input 

        [MaxLength(1000)]
        public string? Comment { get; set; }//user input 

        [Required]
        public DateTime ReviewDate { get; set; }//SYSTEM GENERATION

<<<<<<< HEAD
        public virtual User? User { get; set; }//from list
         public virtual Product? Product { get; set; }//from list
=======
        public User? User { get; set; }//from list
         public Product? Product { get; set; }//from list
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336


    }
}
