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

        public static Instructor GetTeacherName(String course)
        {
            ClassInfoEntities context = new ClassInfoEntities();
            var Name = (from c in context.Classes
                        join t in context.Instructors on c.InstID equals t.InstID
                        where c.ClassNumber.Equals(course) 
                        select t).Single();
            return Name;

        }

        public static Instructor GetTeacherEmail(String course)
        {
            ClassInfoEntities context = new ClassInfoEntities();
            var Email = (from c in context.Classes
                        join t in context.Instructors on c.InstID equals t.InstID
                        where c.ClassNumber.Equals(course)
                        select t).Single();
            return Email;
        }

        public static Instructor GetTeacherOffice(String course)
        {
            ClassInfoEntities context = new ClassInfoEntities();
            var OfficeLocation = (from c in context.Classes
                        join t in context.Instructors on c.InstID equals t.InstID
                        where c.ClassNumber.Equals(course)
                        select t).Single();
            return OfficeLocation;
        }

        public static List<Student> GetAllStudents(String course)
        {
            ClassInfoEntities context = new ClassInfoEntities();
            ////var AllStudents = 
            //            (from  StudentList in context.Students
            //             where StudentList.Classes.Contains(course)
            //             select StudentList);
            //var StudentsInCourse =
            //    (from student in AllStudents
            //     where student.

            //     )

            var AllStudents =
                (
                 from c in context.Classes
                 where c.ClassNumber == course
                 select c.Students
                 ).Single().ToList();



            return AllStudents;
        }

    }
}
