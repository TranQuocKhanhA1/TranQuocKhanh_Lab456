using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tramquockhanh_lab456.Models;
using System.Data.Entity;
using tramquockhanh_lab456.ViewModels;

namespace tramquockhanh_lab456.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();

        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);

            var viewModel = new CourseViewModel
            {
                UpcommingCourses = upcommingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }

    internal class ApplicationDbContext
    {
        internal object Courses;

        public ApplicationDbContext()
        {
        }
    }
}



/*
public class HomeController : Controller
{
    private ApplicationDbContext _dbContext;

    public HomeController()
    {
        _dbContext = new ApplicationDbContext();

    }
    public ActionResult Index()
    {
        var upcommingCourses = _dbContext.Courses
            .Include(c => c.Lecturer)
            .Include(c => C.Category)
            .Where(c => c.DateTime > DateTime.Now);

        return View(upcommingCourses);
    }

    public ActionResult About()
    {
        ViewBag.Message = "Your application description page.";

        return View();
    }

    public ActionResult Contact()
    {
        ViewBag.Message = "Your contact page.";

        return View();
    }
}
}
*/