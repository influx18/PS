
using System;
using Microsoft.Win32;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentValidation
    {
        public static Student GetStudentDataByUser(User user)
        {
            if (user.Role != UserRoles.STUDENT.ToString())
            {
                return null;
            }

            return StudentData.GetStudentByFacultyNumber(user.FacNumber);
        }
    }
}