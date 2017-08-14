using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalAssignment.Models.ViewModels
{
    public class AttendingViewModel
    {
        public Customer customer { get; set; }
        public Movie movie { get; set; }
        public Theater theatre { get; set; }
        public Attending attending { get; set; }

    }
}