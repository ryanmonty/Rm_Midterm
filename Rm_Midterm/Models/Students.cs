using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rm_Midterm.Models
{
    public class Students
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Course Id")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Date Enrolled")]
        [DisplayFormat(DataFormatString = "{0:MM/d/yyyy}")]
        public DateTime CourseEnrolledDate { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:m d yyyy}")]
        [Min18YearsIfAStudent]
        public DateTime? BirthDate { get; set; }        
        public CourseStatus CourseStatus { get; set; }

        [Required]
        public int CourseStatusId { get; set; }
        [Required]
        public string Grade { get; set; }

    }
}