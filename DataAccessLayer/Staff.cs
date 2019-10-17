using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Staf
    {
        public int StaffCode { get; set; }
        public string StaffNumber { get; set; }
        public string StaffName { get; set; }
        public string StaffSurname { get; set; }
        public string StaffType { get; set; }
        public string StaffEmail { get; set; }
        public int Department { get; set; }
        public string ContactNumber { get; set; }
        public string Status { get; set; }
       public string Password { get; set; }

        public Staf(string staffNum,string contact, string name, string surname, string staffType, string email,int department,string status)
        {
            Status = status;
            StaffNumber = staffNum;
            StaffName = name;
            StaffEmail = email;
            ContactNumber = contact;
            StaffSurname = surname;
            StaffType = staffType;
            Department = department;
        }
        public Staf(int code, string staffNum, string contact, string name, string surname, string staffType, string email, int department)
        {
            StaffEmail = email;
            ContactNumber = contact;
            StaffCode = code;
            StaffNumber = staffNum;
            StaffName = name;
            StaffSurname = surname;
            StaffType = staffType;
            Department = department;
        }
        public Staf(int code)
        {
           
            StaffCode = code;
           
        }
        public Staf() { }
    }
}
