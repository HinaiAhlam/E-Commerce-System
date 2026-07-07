using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.models
{
    public class User
    {
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
