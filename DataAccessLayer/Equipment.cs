using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Equipment
    {
        public int EquipmentCode { get; set; }
        public string EquipmentDesc { get; set; }
        public int EquipmentType { get; set; }
        public int Venue { get; set; }
        public string Status { get; set; }

        //Constructor
        public Equipment(string equipmentDesc, int equipmentType, int venue,string status)
        {
            Status = status;
            EquipmentDesc = equipmentDesc;
            EquipmentType = equipmentType;
            Venue = venue;
        }


        public Equipment(string equipmentDesc, int equipmentType, int venue, int equipmentCode)
        {
            EquipmentCode = equipmentCode;
            EquipmentDesc = equipmentDesc;
            EquipmentType = equipmentType;
            Venue = venue;
        }

        public Equipment( int equipmentCode)
        {
            EquipmentCode = equipmentCode;
        }
    }
}