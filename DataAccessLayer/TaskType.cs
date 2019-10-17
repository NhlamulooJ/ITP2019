using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace DataAccessLayer
{
    public class TaskType
    {
        public int TaskTypeCode { get; set; }
        public string TaskTypeName { get; set; }
        public string Status { get; set; }

        public TaskType(string name,string status)
        {
            Status = status;
            TaskTypeName = name;
        }
        public TaskType(int code,string name)
        {
            TaskTypeCode = code;
            TaskTypeName = name;
        }
        public TaskType(int code)
        {
            TaskTypeCode = code;
         
        }
    }
}
