using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        public MainWindow(UserLogin.Student currentStudent)
        {
            InitializeComponent();
            this.DataContext = currentStudent;

          

            firstName.IsEnabled = false;
            middleName.IsEnabled = false;
            lastName.IsEnabled = false;
        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetStudentInformation();
        }

        private void MiddleName_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetStudentInformation();
        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetStudentInformation();
        }

        private void SetStudentInformation()
        {
            UserLogin.Student currentStudent = GetStudent();
            if (currentStudent != null)
            {
                SetFaculty(currentStudent.Faculty);
                SetSpecialization(currentStudent.Specialization);
                SetDegree(currentStudent.QualificationDegree);
                SetStatus(currentStudent.StudentStatus.ToString());
                SetFacultyNumber(currentStudent.FacultyNumber);
                SetCourse(currentStudent.SemestralCourse.ToString());
                SetStream(currentStudent.SemestralStream.ToString());
                SetGroup(currentStudent.SemestralGroup.ToString());
              
            }
            else
            {
                SetFaculty("");
                SetSpecialization("");
                SetDegree("");
                SetStatus("");
                SetFacultyNumber("");
                SetCourse("");
                SetStream("");
                SetGroup("");
               
            }
        }


        private UserLogin.Student GetStudent()
        {
            return UserLogin.StudentData.GetStudentByNames(firstName.Text, middleName.Text, lastName.Text);
        }

        private void SetFaculty(String facultyString)
        {
            faculty.Text = facultyString;
        }

        private void SetSpecialization(String specializationString)
        {
            specialization.Text = specializationString;
        }

        private void SetDegree(String degreeString)
        {
            degree.Text = degreeString;
        }

        private void SetStatus(String statusString)
        {
            status.Text = statusString;
        }

        private void SetFacultyNumber(String facultyNumberString)
        {
            facultynumber.Text = facultyNumberString;
        }

        private void SetCourse(String courseString)
        {
            course.Text = courseString;
        }

        private void SetStream(String streamString)
        {
            stream.Text = streamString;
        }

        private void SetGroup(String groupString)
        {
            group.Text = groupString;
        }

      
    }
}
