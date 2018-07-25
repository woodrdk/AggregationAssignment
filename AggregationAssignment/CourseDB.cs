using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAssignment
{
    static class CourseDB
    {
        public static List<CourseName> GetAllCourses()
        {
            ClassInfoEntities context = new ClassInfoEntities();
            List<CourseName> allCourses =
                (from c in context.Classes
                 select c).ToList();
            return allCourses;
        }

        public static List<CourseName> GetCourseDetails()
        {
            ClassInfoEntities context = new ClassInfoEntities();
            List<CourseName> courseDetails =
                (from c in context.Classes
                 select c).ToList();
            return courseDetails;

        }
    }
}
