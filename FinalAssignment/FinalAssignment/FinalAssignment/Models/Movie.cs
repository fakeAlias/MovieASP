
using System;
using System.ComponentModel.DataAnnotations;

namespace FinalAssignment.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
    }
}