using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Request
   {
        public int RequestCode { get; set; }
        public int StaffCode { get; set; }
        public string RequestDescription { get; set; }
        public int StudentCode { get; set; }
        public int TaskTypeCode { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
        public int AssignedStaff { get; set; }
       
        

        public Request(string requestDesc,int staffCode, int studentCode, int taskTypeCode, string date, string time,string status,int assignedStaff)
        {
            AssignedStaff = assignedStaff;
            Status = status;
            StaffCode = staffCode;
            RequestDescription = requestDesc;
            StudentCode = studentCode;
            TaskTypeCode = taskTypeCode;
            Date = date;
            Time = time;
        }
        public Request(string requestDesc, int requestCode,int staffCode, int studentCode, int taskTypeCode, string date, string time)
        {
            RequestCode = requestCode;
            RequestDescription = requestDesc;
            StaffCode = staffCode;
            StudentCode = studentCode;
            TaskTypeCode = taskTypeCode;
            Date = date;
            Time = time;
        }
        public Request(int requestCode)
        {
            RequestCode = requestCode;
        }





    }
}
