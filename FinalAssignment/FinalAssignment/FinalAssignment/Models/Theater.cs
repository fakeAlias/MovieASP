
using System;
using System.ComponentModel.DataAnnotations;

namespace FinalAssignment.Models
{
    public class Theater
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Location { get; set; }
    
    }
}