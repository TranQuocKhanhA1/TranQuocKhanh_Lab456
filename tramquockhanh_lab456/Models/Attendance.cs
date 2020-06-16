using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tramquockhanh_lab456.Models
{
    public Course  Course { get; set; }
    [key]
    [Column (Order = 1)]
        public int CourseId { get; set; } 
        public ApplicationUser Attendee { get; set; }

    [key]
    [Column (Order = 2)]
        public string AttendeeId { get; set; }
    
        
    
}