using Rm_Midterm.Models;
using Rm_Midterm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Rm_Midterm.Controllers
{
    public class CoursesController : Controller
    {
        private ContextModels db = new ContextModels();
        // GET: Courses
        public ActionResult Index()
        {
            var courses = db.Courses.ToList();

            return View(courses);
        }

        public ActionResult Details(int? id)
        {
            var course = db.Courses.Find(id);

            if (course == null)
                HttpNotFound();

            return View(course);
        }

        public ActionResult CourseForm()
        {

            var viewModel = new NewCourseViewModel
            {
                CourseRatings = db.CourseRating.ToList()
            };

            return View("CourseForm", viewModel);

        }

        public ActionResult Edit(int? id)
        {
            var course = db.Courses.Find(id);

            if (course == null)
                return HttpNotFound();

            var viewModel = new NewCourseViewModel

            {
                Courses = course,
                CourseRatings = db.CourseRating.ToList()
            };
            db.SaveChanges();

            return View("CourseForm", viewModel);
        }

        [HttpPost]
        public ActionResult Update(Courses courses)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCourseViewModel
                {
                    Courses = courses,
                    CourseRatings = db.CourseRating.ToList()
                };
            
                    return View("CourseForm", viewModel);
            }
            if (courses.Id == 0)
            {

                db.Courses.Add(courses);
            }

            else
            {
                var courseInDb = db.Courses.Single(c => c.Id == courses.Id);
                courseInDb.CourseName = courses.CourseName;
                courseInDb.CourseDescription = courses.CourseDescription;
                courseInDb.TutorName = courses.TutorName;
                courseInDb.CourseRating = courses.CourseRating;

            }
            db.SaveChanges();

            return RedirectToAction("Index", "Courses");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courses courses = db.Courses.Find(id);
            if (courses == null)
            {
                return HttpNotFound();
            }
            return View(courses);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Courses courses = db.Courses.Find(id);
            db.Courses.Remove(courses);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }


}