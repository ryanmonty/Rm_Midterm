using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rm_Midterm.Models;
using Rm_Midterm.ViewModels;

namespace Rm_Midterm.Controllers
{
    public class StudentsController : Controller
    {
        private ContextModels db = new ContextModels();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.Include(s => s.CourseStatus).ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }


        [HttpPost]
        public ActionResult Create(Students students)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewStudentViewModel
                {
                    Students = students,
                    Status = db.CourseStatus.ToList(),
                    CourseList = db.Courses.ToList()
                };

                return View("Edit", viewModel);
            }
            if (students.Id == 0)
            {

                db.Students.Add(students);
            }

            else
            {
                var courseInDb = db.Students.Single(c => c.Id == students.Id);
                courseInDb.FirstName = students.FirstName;
                courseInDb.LastName = students.LastName;
                courseInDb.BirthDate = students.BirthDate;
                courseInDb.CourseId = students.CourseId;
                courseInDb.CourseEnrolledDate = students.CourseEnrolledDate;
                courseInDb.CourseStatusId = students.CourseStatusId;
                courseInDb.Grade = students.Grade;

            }
            db.SaveChanges();

            return RedirectToAction("Index", "Students");
        }


        public ActionResult Edit(int? id)
        {
            var student = db.Students.Find(id);

            if (student == null)
                return HttpNotFound();

            var viewModel = new NewStudentViewModel
            {
                Students = student,
                Status = db.CourseStatus.ToList(),
                CourseList = db.Courses.ToList()
            };

            return View("Edit", viewModel);
        }
        public ActionResult New()
        {

            var viewModel = new NewStudentViewModel
            {
                Status = db.CourseStatus.ToList(),
                CourseList = db.Courses.ToList()
            };

            return View("Edit", viewModel);

        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Students students = db.Students.Find(id);
            db.Students.Remove(students);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
