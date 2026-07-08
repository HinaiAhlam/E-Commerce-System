using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.models
{
    public class User
    {
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