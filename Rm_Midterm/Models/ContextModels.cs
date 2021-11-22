using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rm_Midterm.Models
{
    public class ContextModels : DbContext
    {
        public ContextModels() : base("name=ContextModels")
        {

        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<CourseRating> CourseRating { get; set; }

        public DbSet<CourseStatus> CourseStatus { get; set; }

    }
}