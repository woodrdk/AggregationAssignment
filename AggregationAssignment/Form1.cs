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
        public string course;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<CourseName> Classes = CourseDB.GetAllCourses();
            cbClasses.DataSource = Classes;
            cbClasses.DisplayMember = nameof(CourseName.ClassNumber);
                
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
            course = cbClasses.Text;

            /*
            List<Class> Classes = CourseDB.GetCourseDetails();
            cbClasses.DataSource = Classes;
            cbClasses.DisplayMember = nameof(Class.ClassNumber);
            */


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
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
