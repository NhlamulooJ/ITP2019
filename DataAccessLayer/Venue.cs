using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Venue
   {
        public int VenueCode { get; set; }
        public string VenueName { get; set; }
        public string VenueDescription { get; set; }
        public int VenueCapacity { get; set; }
       public string Status { get; set; }

        public Venue(string name, string desc, int capacity,string status)
        {
            Status = status;
            VenueName = name;
            VenueDescription = desc;
            VenueCapacity = capacity;
        }
        public Venue(string name, string desc, int capacity, int code,string status)
        {
            Status = status;
            VenueCode = code;
            VenueName = name;
            VenueDescription = desc;
            VenueCapacity = capacity;
        }
        public Venue( int code,string status)
        {
            VenueCode = code;
            Status = status;
        }


    }
}
