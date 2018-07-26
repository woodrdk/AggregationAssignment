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

        public static Class GetCourseCredits(String course)
        {

            ClassInfoEntities context = new ClassInfoEntities();
            var courseCredits = (from c in context.Classes
                                 where c.ClassNumber.Equals(course)
                                 select c).Single();
            return courseCredits;

        }

        public static Class GetCourseDetails(String course)
        {

            ClassInfoEntities context = new ClassInfoEntities();
            var courseDetails = (from c in context.Classes
                                 where c.ClassNumber.Equals(course)
                                 select c).Single();
            return courseDetails;
        }

        public static Class GetCourseTitle(String course)
        {
          
            ClassInfoEntities context = new ClassInfoEntities();
            var courseTitle = (from c in context.Classes
                                 where c.ClassNumber.Equals(course)
                                 select c).Single();
            return courseTitle;
        }


        // must add and do joins
        public static Class GetTeacherName(String course)
        {
            ClassInfoEntities context = new ClassInfoEntities();
            var Name = (from c in context.Classes
                        join t in context.Instructors on c.InstID equals t.InstID
                        where c.ClassNumber.Equals(course)
                        select c).Single();
            return Name;

            // select s.*
            // from Service s
            // inner join ServiceAssignment sa on sa.ServiceId = s.Id
            // where sa.LocationId = 1

            // from s in db.Services
            // join sa in db.ServiceAssignments on s.Id equals sa.ServiceId
            // where sa.LocationId == 1
            // select s

        }

        //public static Class GetTeacherEmail(String course)
        //{
        //    ClassInfoEntities context = new ClassInfoEntities();
        //}

        //public static Class GetTeacherOffice(String course)
        //{
        //    ClassInfoEntities context = new ClassInfoEntities();
        //}


    }
}
