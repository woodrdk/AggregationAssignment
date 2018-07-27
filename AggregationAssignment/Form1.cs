using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggregationAssignment
{
    public partial class frmMain : Form
    {
        public string GetCourse()
        {
            String course = cbClasses.Text;
            return course;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<Class> Classes = CourseDB.GetAllCourses();
            cbClasses.DataSource = Classes;
            cbClasses.DisplayMember = nameof(Class.ClassNumber);
                
        }

        private void btnCourseDetails_Click(object sender, EventArgs e)
        {
            if(pnlDetails.Visible == true)
            {
                pnlDetails.Visible = false;
                btnCourseDetails.Text = "View Course Details";
            }
            else
            {
                pnlDetails.Visible = true;
                btnCourseDetails.Text = "Close Course Details";
            }
            String course = GetCourse();

            var courseCredits = CourseDB.GetCourseCredits(course);
            txtCredits.Text = courseCredits.Credits.ToString();


            var courseDetails = CourseDB.GetCourseDetails(course);
            rtbDescription.Text = courseDetails.CLDescription.ToString();

            var courseTitle = CourseDB.GetCourseTitle(course);
            txtTitle.Text = courseTitle.Title.ToString();

            
        }

        private void btnViewInstructor_Click(object sender, EventArgs e)
        {
            if (gbInstructor.Visible == true)
            {
                gbInstructor.Visible = false;
                btnViewInstructor.Text = "View Instructor Info";
            }
            else
            {
                gbInstructor.Visible = true;
                btnViewInstructor.Text = "Close Instructor Info";
            }
            String course = GetCourse();
            var name = CourseDB.GetTeacherName(course);
            txtName.Text = name.Name.ToString();

            var email = CourseDB.GetTeacherEmail(course);
            txtEmail.Text = email.Email.ToString();

            var office = CourseDB.GetTeacherOffice(course);
            txtOffice.Text = office.OfficeLocation.ToString();
        }

        private void btnViewRoster_Click(object sender, EventArgs e)
        {
            if (gbRoster.Visible == true)
            {
                gbRoster.Visible = false;
                btnViewRoster.Text = "View Roster Info";
            }
            else
            {
                gbRoster.Visible = true;
                btnViewRoster.Text = "Close Roster Info";
            }
            String course = GetCourse();
            var students = CourseDB.GetAllStudents(course);

            string studentsInClass = "";
            foreach (var student in students)
            {
                studentsInClass += student.FirstName + student.LastName + " ";
            }

            rtbStudents.Text = studentsInClass; //students.ToString();
            
            txtNumStudents.Text = students.Count().ToString(); // code for the student count in the class
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
