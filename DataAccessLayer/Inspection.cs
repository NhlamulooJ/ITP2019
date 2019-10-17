using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Inspection
    {
       public int InspectionCode { get; set; }
       public int VenueCode { get; set; }
        public int StaffCode { get; set; }
           public string Date { get; set; }
        public string Time { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }

        public Inspection(int venue, int staff, string date, string time, string commemt, string status)
        {
            Status = status;
            VenueCode = venue;
            StaffCode = staff;
            Date = date;
            Time = time;
            Comment = commemt;
        }

        public Inspection(int inspectionCode, int venue, int staff, string date, string time, string commemt)
        {
            InspectionCode = inspectionCode;
            VenueCode = venue;
            StaffCode = staff;
            Date = date;
            Time = time;
            Comment = commemt;
        }
        public Inspection(int inspectionCode)
        {
            InspectionCode = inspectionCode;
           
        }
        public Inspection() { }

    }
}
