using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InspectionDetails
    {
        public int InspectionDetailCode { get; set; }
        public int InspectionCode { get; set; }
        public int EquipmentCode { get; set; }
        public int StaffCode { get; set; }
        public string FaultComment { get; set; }
        public string Status { get; set; }
        public string Deteted { get; set; }

        public InspectionDetails(int inspectionCode, int equipCode, int staffCode, string faultComment, string status,string deleted)
        {
            Deteted = deleted;
            InspectionCode = inspectionCode;
            EquipmentCode = equipCode;
            StaffCode = staffCode;
            FaultComment = faultComment;
            Status = status;
        }
        public InspectionDetails(int inspectionDetailCode, int inspectionCode, int equipCode, int staffCode, string faultComment, string status)
        {
            InspectionDetailCode = inspectionDetailCode;
            InspectionCode = inspectionCode;
            EquipmentCode = equipCode;
            StaffCode = staffCode;
            FaultComment = faultComment;
            Status = status;
        }

        public InspectionDetails(int inspectionDetailCode)
        {
            InspectionDetailCode = inspectionDetailCode;
        }


        public InspectionDetails() { }
    }
}
