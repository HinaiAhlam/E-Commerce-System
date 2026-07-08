using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< HEAD
=======
using System.Text;
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336

namespace ConsoleApp1.models
{
    public class User
    {
<<<<<<< HEAD
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; } 

        [Required]
        [MaxLength(50)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(256)]
        public string? PasswordHash { get; set; }

        [Required]
        [MaxLength(100)]
        public string? FullName { get; set; }

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [MaxLength(300)]
        public string? Address { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual List<Order>? Orders { get; set; }

        public virtual List<Review>? Reviews { get; set; }
    }
}
=======
        [Key] //auto-generated
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int?     UserId {  get; set; }//system generated

        [Required]
        [MaxLength(50)]
        public string? Username { get; set; }//user input

        [Required]
        [MaxLength(150)]
        public string? Email { get; set; }//user input

        [Required]
        [MaxLength(256)]
        public string? PasswordHash { get; set; }//user input

        [Required]
        [MaxLength(100)]
        public string? FullName { get; set; }//user input

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }//user input

        [MaxLength(300)]
        public string? Address { get; set; }//user input

        [Required]
        public DateTime RegistrationDate { get; set; }//system generated

        [Required]
        public bool IsActive { get; set; }// default value

        public List<Order>? Orders { get; set; }

        public List<Review>? Reviews { get; set; }

    }
}
>>>>>>> e3a488a8b64bee08a36bd90f0228c24da580a336
