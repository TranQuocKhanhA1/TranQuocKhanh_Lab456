using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.AspNet.Identity;
using TRANQUOCKHANH_LAP456_BIGSCHOOL.Models;

namespace TRANQUOCKHANH_LAP456_BIGSCHOOL.Controllers
{
    [Authorize]
    public class Attendance1Controller : ApiController
    {

        private ApplicationDbContext _dbContext;

        public Attendance1Controller()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(Attendance1Dto attendance1Dto)
        {

            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendance1s.Any(a => a.AttendeeId == userId && a.CourseId == attendance1Dto.CourseId))
                return BadRequest("The Attendance1 already exists!");


            var attendance1 = new Attendance1
            {
                CourseId =  attendance1Dto.CourseId,
                AttendeeId = userId
                //AttendeeId = User.Identity.GetUserId()
            };

            _dbContext.Attendance1s.Add(attendance1);
            _dbContext.SaveChanges();


            return Ok();
        }
    


 


    /*    private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Attendance1
        public IQueryable<Attendance1> GetAttendance1()
        {
            return db.Attendance1;
        }

        // GET: api/Attendance1/5
        [ResponseType(typeof(Attendance1))]
        public IHttpActionResult GetAttendance1(int id)
        {
            Attendance1 attendance1 = db.Attendance1.Find(id);
            if (attendance1 == null)
            {
                return NotFound();
            }

            return Ok(attendance1);
        }

        // PUT: api/Attendance1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAttendance1(int id, Attendance1 attendance1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != attendance1.CourseId)
            {
                return BadRequest();
            }

            db.Entry(attendance1).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Attendance1Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Attendance1
        [ResponseType(typeof(Attendance1))]
        public IHttpActionResult PostAttendance1(Attendance1 attendance1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Attendance1.Add(attendance1);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Attendance1Exists(attendance1.CourseId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = attendance1.CourseId }, attendance1);
        }

        // DELETE: api/Attendance1/5
        [ResponseType(typeof(Attendance1))]
        public IHttpActionResult DeleteAttendance1(int id)
        {
            Attendance1 attendance1 = db.Attendance1.Find(id);
            if (attendance1 == null)
            {
                return NotFound();
            }

            db.Attendance1.Remove(attendance1);
            db.SaveChanges();

            return Ok(attendance1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Attendance1Exists(int id)
        {
            return db.Attendance1.Count(e => e.CourseId == id) > 0;
        }
    */
    }
}