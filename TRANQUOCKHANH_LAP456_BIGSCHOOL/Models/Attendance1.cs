using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TRANQUOCKHANH_LAP456_BIGSCHOOL.Models
{
    public class Attendance1
    {
        [Key]
        [Column(Order =1)]

        public int CourseId { get; set; }

        public ApplicationUser Attendee { get; set; }

        [Key]
        [Column(Order =2)]
        public string AttendeeId { get; set; }
        public Course Coures { get; internal set; }
    }
}