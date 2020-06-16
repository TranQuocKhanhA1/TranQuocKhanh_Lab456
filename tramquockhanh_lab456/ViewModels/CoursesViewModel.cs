using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tramquockhanh_lab456.ViewModels
{
    public class CoursesController
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}