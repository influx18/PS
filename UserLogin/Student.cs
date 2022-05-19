using System;

namespace UserLogin
{
    public class Student : User
    {
        public int StudentId { get; set; }

        public Student() { }

        public Student(string name, string middleName, string lastName, string faculty, string specialization, string qualificationDegree, string studentStatus, string facultyNumber, int semestralCourse, int semestralStream, int semestralGroup) : base(name, lastName, facultyNumber, UserRoles.STUDENT.ToString(), DateTime.Now)

        {
            FirstName = name;
            MiddleName = middleName;
            LastName = lastName;
            Faculty = faculty;
            Specialization = specialization;
            QualificationDegree = qualificationDegree;
            StudentStatus = studentStatus;
            FacultyNumber = facultyNumber;
            SemestralCourse = semestralCourse;
            SemestralStream = semestralStream;
            SemestralGroup = semestralGroup;
        }

        public string FirstName
        { get; set; }

        public string MiddleName
        { get; set; }

        public string LastName
        { get; set; }


        public byte[] Photo { get; set; }

        public string Faculty
        { get; set; }
        public string Specialization
        { get; set; }
        public string QualificationDegree
        { get; set; }
        public string StudentStatus
        { get; set; }
        public string FacultyNumber
        { get; set; }

        public int SemestralCourse
        { get; set; }
        public int SemestralStream
        { get; set; }
        public int SemestralGroup
        { get; set; }

        public string GetNames()
        {
            return this.FirstName + this.MiddleName + this.LastName;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.MiddleName + " " + this.LastName + " " + Faculty + " " + Specialization + " " + StudentStatus;
        }
    }
}