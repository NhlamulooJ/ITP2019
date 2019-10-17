using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Student
   {
        public int StudentCode { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string EmailAddress { get; set; }
        public string Status { get; set; }



        public Student(string studentNumber, string studentName, string studentSurname, string email,string status)
        {
            Status = status;
            StudentName = studentName;
            StudentNumber = studentNumber;
            StudentSurname = studentSurname;
            EmailAddress = email;
        }
        public Student(int code,string studentNumber, string studentName, string studentSurname, string email)
        {
            StudentCode = code;
            StudentName = studentName;
            StudentNumber = studentNumber;
            StudentSurname = studentSurname;
            EmailAddress = email;
        }
        public Student(int code)
        {
           
            StudentCode = code;
        }
    }
}
