using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAssignment
{
    static class CourseDB
    {
        public static List<Class> GetAllCourses()
        {
            ClassInfoEntities context = new ClassInfoEntities();
            List<Class> allCourses =
                (from c in context.Classes
                 select c).ToList();
            return allCourses;
        }

        public static List<Class> GetCourseDetails()
        {
            ClassInfoEntities context = new ClassInfoEntities();
            List<Class> courseDetails =
                (from c in context.Classes
                 select c).ToList();
            return courseDetails;

        }
    }
}
