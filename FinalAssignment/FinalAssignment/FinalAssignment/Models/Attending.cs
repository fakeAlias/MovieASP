using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalAssignment.Models
{
    public class Attending
    {
        public int CustId { get; set; }
        public int MovieId { get; set; }
        public int TheatreId { get; set; }
    }
}