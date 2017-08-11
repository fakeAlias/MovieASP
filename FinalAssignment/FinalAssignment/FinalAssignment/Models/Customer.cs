
using System;
using System.ComponentModel.DataAnnotations;

namespace FinalAssignment.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
}