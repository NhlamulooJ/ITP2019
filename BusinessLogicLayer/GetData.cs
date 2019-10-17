using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class GetData
    {
        Insert_RetrieveData getData = new Insert_RetrieveData();
        public DataTable GetLogin(string number, string password)
        {
            return getData.GetLogin(number, password);
        }

        public DataTable GetDepartment()
        {
            return getData.GetDepartment();
        }
        public DataTable GetStaff()
        {
            return getData.GetStaff();
        }
        public DataTable GetVenue()
        {
            return getData.GetVenue();
        }
        public DataTable GetEquipmentType()
        {
            return getData.GetEquipmentType();
        }
        public DataTable GetEquipment()
        {
            return getData.GetEquipment();
        }
        public DataTable GetInspection()
        {
            return getData.GetInspection();
        }
        public DataTable GetInspectionDetail()
        {
            return getData.GetInspectionDetail();
        }
        public DataTable GetTaskType()
        {
            return getData.GetTaskType();
        }
        public DataTable GetStudent()
        {
            return getData.GetStudent();
        }
        public DataTable GetRequest()
        {
            return getData.GetRequest();
        }
        public DataTable GetTutorRequest()
        {
            return getData.GetTutorRequest();
        }
        public DataTable GetModule()
        {
            return getData.GetModule();
        }
        public DataTable GetRequestForTutorRequest()
        {
            return getData.GetRequestForTutorRequest();
        }
        public DataTable GetStaffReport(string staffNumber)
        {
            return getData.GetStaffReport(staffNumber);
        }
        public DataTable LoginForNormalStaff(string num, string pass)
        {
            return getData.LogiForNormalStaff(num, pass);
        }
        public DataTable GetStaffRequest(string staffNumber)
        {
            return getData.GetStaffRequest(staffNumber);
        }
        public DataTable CountTotals()
        {
            return getData.CountTotals();
        }
        public DataTable GetBrokeEquipment()
        {
            return getData.GetBrokeEquipment();
        }
        public DataTable EquipmentsToBeFixed()
        {
            return getData.EquipmentsToBeFixed();
        }
        public DataTable SearchStudent(string no)
        {
            return getData.SearchStudent(no);
        }
        public DataTable TotalRequests()
        {
            return getData.TotalRequests();
        }
        public DataTable TutorRequestByVenue(string venueName)
        {
            return getData.TutorRequestByVenue(venueName);
        }
        public DataTable TutorRequestByModule(string moduleDesc)
        {
            return getData.TutorRequestByModule(moduleDesc);
        }
        public DataTable GetAssignedStaff()
        {
            return getData.GetAssignedStaff();
        }
        public DataTable GetAdminStaff()
        {
            return getData.GetAdminStaff();
        }
        public DataTable SearchStudentTextChanged(string studentToFind)
        {
            return getData.SearchStudentTextChanged(studentToFind);
        }
        public DataTable Tasks(string date)
        {
            return getData.Tasks(date);
        }
        public DataTable GetInspectionByDate(string date)
        {
            return getData.GetInspectionByDate(date);
        }
    }
}
