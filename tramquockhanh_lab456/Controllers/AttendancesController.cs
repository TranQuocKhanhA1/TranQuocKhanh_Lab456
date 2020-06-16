using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tramquockhanh_lab456.Controllers
{
    [Authorize]
    public class AttendancesController : Controller

    {
        // GET: Attendances
        public ActionResult Index()
        {
            return View();
        }
       
    }
}