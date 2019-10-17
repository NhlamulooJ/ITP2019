using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Department
   {
        public int Code { get; set; }
        public string DepartmentName { get; set; }
        public string Building { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }

        public Department(string name, string building, string person, string email)
        {
            DepartmentName = name;
            Building = building;
            ContactPerson = person;
            Email = email;
        }
        public Department(int code,string name, string building, string person, string email)
        {
            Code = code;
            DepartmentName = name;
            Building = building;
            ContactPerson = person;
            Email = email;
        }
        public Department(int code)
        {
            Code = code;
           
        }
        public Department() { }


    }
}
