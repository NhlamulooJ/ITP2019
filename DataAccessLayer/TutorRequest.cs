using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class TutorRequest
   {
        public int TutorRequestCode { get; set; }
        public int RequestCode { get; set; }
        public int ModuleCode { get; set; }
        public int TaskTypeCode { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int VenueCode { get; set; }
        public string Date { get; set; }
        public string Status { get; set;
        }


        // for Inserting Tutor Request
        public TutorRequest(int requestCode, int moduleCode,int venueCode, int taskTypeCode, string startTime, string endTime, string date, string status)
        {
            RequestCode = requestCode;
            ModuleCode = moduleCode;
            VenueCode = venueCode;
            TaskTypeCode = taskTypeCode;
            StartTime = startTime;
            EndTime = endTime;
            Date = date;
            Status = status;
        }

        // For Updating Tutor Requesr
        public TutorRequest(int tutorRequestCode,int venueCode, int requestCode, int moduleCode, int taskTypeCode, string startTime, string endTime, string date)
        {
            TutorRequestCode = tutorRequestCode;
            RequestCode = requestCode;
            ModuleCode = moduleCode;
            VenueCode = venueCode;
            TaskTypeCode = taskTypeCode;
            StartTime = startTime;
            EndTime = endTime;
            Date = date;
        }

        // for Removing Tutor Requesr
        public TutorRequest(int tutorRequestCode)
        {
            TutorRequestCode = tutorRequestCode;
        }


    }
}
