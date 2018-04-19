using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project1
{


    public partial class WebForm1 : System.Web.UI.Page
    {

        string teacherGrade;
        string courseGrade;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                lblName.Text = " Thank You " + Request["Name"].ToString() + "  for filling out the survey";
                lblStudentID.Text = "Your TUID is : " + Request["TUID"].ToString();

            
                // Teacher Calculations
                double teacher1 = Convert.ToDouble(Request["Teacher1"]);
                double teacher2 = Convert.ToDouble(Request["Teacher2"]);
                double teacher3 = Convert.ToDouble(Request["Teacher3"]);
                double teacher4 = Convert.ToDouble(Request["Teacher4"]);
                double teacher5 = Convert.ToDouble(Request["Teacher1"]);
                double teacher6 = Convert.ToDouble(Request["Teacher6"]);
                double teacher7 = Convert.ToDouble(Request["Teacher7"]);
                double teacher8 = Convert.ToDouble(Request["Teacher8"]);


                //Course Calculations
                double course1 = Convert.ToDouble(Request["Course1"]);
                double course2 = Convert.ToDouble(Request["Course2"]);
                double course3 = Convert.ToDouble(Request["Course3"]);
                double course4 = Convert.ToDouble(Request["Course4"]);
                double course5 = Convert.ToDouble(Request["Course5"]);
                double course6 = Convert.ToDouble(Request["Course6"]);
                double course7 = Convert.ToDouble(Request["Course7"]);
                double course8 = Convert.ToDouble(Request["Course8"]);
                double course9 = Convert.ToDouble(Request["Course9"]);
                double course10 = Convert.ToDouble(Request["Course10"]);
                double course11 = Convert.ToDouble(Request["Course11"]);
                double course12 = Convert.ToDouble(Request["Course12"]);


                double teacherScore = teacher1 + teacher2 + teacher3 + teacher4 +
                teacher5 + teacher6 + teacher7 + teacher7 + teacher8;

                double courseScore = course1 + course2 + course3 + course4 +
                    course5 + course6 + course7 + course8 + course9 + course10 +
                    course11 + course12;


                lblTeacherScore.Text = "The score you gave your teacher is a " + teacherScore;
                lblCourseScore.Text = "The score you gave your course is a " + courseScore;


                if (teacherScore >= 36)
                {
                    teacherGrade = "A";
                }

                if (teacherScore >= 32)
                {
                    teacherGrade = "B";
                }

                if (teacherScore >= 28)
                {
                    teacherGrade = "C";
                }

                if (teacherScore >= 24)
                {
                    teacherGrade = "D";
                }

                if (teacherScore < 24)
                {
                    teacherGrade = "F";
                }

                if (courseScore >= 54)
                {
                    courseGrade = "A";
                }

                if (courseScore >= 48)
                {
                    courseGrade = "B";
                }

                if (courseScore >= 42)
                {
                    courseGrade = "C";
                }

                if (courseScore >= 36)
                {
                    courseGrade = "D";
                }

                if (courseScore < 36)
                {
                    courseGrade = "F";
                }

                lblProfessorGrade.Text = "The grade you gave your teacher is a " + teacherGrade.ToString();
                lblCourseGrade.Text = "The grade you gave your course is a " + courseGrade.ToString();

               
                
            }
        }

            
        
        }
    }
