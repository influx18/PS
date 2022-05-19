using System;
using System.Collections.Generic;

namespace UserLogin

{
    public class StudentData
    {
        static public List<Student> TestStudents
        { get; private set; } = new List<Student> { new Student("Denislav", "Biserov", "Petkov", "FKST","KSI", "Bachelor",  "passed", "121219000", 6, 9, 31),
                                                    new Student("Pavel", "Biserov", "Petkov", "FKST","KSI", "Masters", "passed", "121219044", 4, 12, 31),
                                                    new Student("Firstname", "Middlename", "Lastname", "Faculty","Specialization", "Degree", "failed", "Faculty number", 99, 99, 99)};

        static public Student GetStudentByFacultyNumber(String facNumber)
        {
            foreach (Student student in new StudentInfoContext().Students)
            {
                if (student.FacultyNumber.Equals(facNumber))
                {
                    return student;
                }
            }

            return null;
        }

        static public Student GetStudentByNames(String firstName, String middleName, string lastName)
        {
            foreach (Student student in new StudentInfoContext().Students)
            {
                if (student.FirstName.Equals(firstName) &&
                    student.MiddleName.Equals(middleName) &&
                    student.LastName.Equals(lastName) )
                {
                    return student;
                }
            }
            return null;
        }
    }
}