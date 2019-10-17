using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Session
    {
        public int SessionID { get; set; }
        public int ModuleID { get; set; }
        public int VenueID { get; set; }
        public int StaffNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Session(int ModuleID, int VenueID, int StaffNumber, DateTime StartDate, DateTime EndDate)
        {
            this.ModuleID = ModuleID;
            this.VenueID = VenueID;
            this.StaffNumber = StaffNumber;

            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

        public Session(int SessionID, int ModuleID, int VenueID, int StaffNumber, DateTime StartDate, DateTime EndDate)
        {
            this.SessionID = SessionID;
            this.ModuleID = ModuleID;
            this.VenueID = VenueID;
            this.StaffNumber = StaffNumber;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
    }
}