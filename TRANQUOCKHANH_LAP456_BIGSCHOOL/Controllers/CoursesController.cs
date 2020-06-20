﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TRANQUOCKHANH_LAP456_BIGSCHOOL.Models;
using TRANQUOCKHANH_LAP456_BIGSCHOOL.ViewModels;

namespace TRANQUOCKHANH_LAP456_BIGSCHOOL.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewMoldel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewMoldel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }

            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public ActionResult Attending()
        {
            var useId = User.Identity.GetUserId();

            var courses = _dbContext.Attendance1s
                .Where(a => a.AttendeeId == useId)
                .Select(a => a.Course)
                .Include(1 => 1.Lecturer)
                .Include(1 => 1.Category)
                .ToList();

            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = Courses,
                ShowAction = User.Identity.IsAuthenticated
            };

            return View(viewModel);

        }

    }
}