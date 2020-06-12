using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tramquockhanh_lab456.Models;
using tramquockhanh_lab456.ViewModels;

namespace tramquockhanh_lab456.Controllers
{

    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public List<Category> Categories { get; private set; }

        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
        {
            return View(viewModel);
        }
    }
    }
}