using Rm_Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rm_Midterm.ViewModels
{
    public class NewCourseViewModel
    {
        public IEnumerable<CourseRating> CourseRatings { get; set; }
        public Courses Courses { get; set; }
        public string Title
        {

            get
            {
                if (Courses != null && Courses.Id != 0)
                    return "Edit Course";

                return "Create a new course";

            }
        }
    }
}