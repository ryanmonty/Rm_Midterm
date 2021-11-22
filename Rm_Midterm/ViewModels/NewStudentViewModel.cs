using Rm_Midterm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rm_Midterm.ViewModels
{
    public class NewStudentViewModel
    {
        public Students Students { get; set; }

        public IEnumerable<CourseStatus> Status { get; set; }

        public CourseStatus CourseStatus { get; set; }

        public IEnumerable<Courses> CourseList { get; set; }

        [Required]
        public Courses Courses { get; set; }

        public string Title
        {

            get
            {
                if (Students != null && Students.Id != 0)
                    return "Edit Student Profile";

                return "Create a Student Profile";

            }
        }
    }
}