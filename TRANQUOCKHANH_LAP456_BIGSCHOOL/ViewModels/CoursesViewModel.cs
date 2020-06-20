using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRANQUOCKHANH_LAP456_BIGSCHOOL.Models;

namespace TRANQUOCKHANH_LAP456_BIGSCHOOL.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}