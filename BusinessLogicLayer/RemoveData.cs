using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class RemoveData
    {
        Insert_RetrieveData removeData = new Insert_RetrieveData();

        public int RemoveEquipment(Equipment equipment)
        {
            return removeData.RemoveEquipment(equipment);
        }
        public int RemoveVenue(Venue venue)
        {
            return removeData.RemoveVenue(venue);
        }
        public int RemoveEquipmentType(EquipmentType equipmentType)
        {
            return removeData.RemoveEquipmentType(equipmentType);
        }
        public int RemoveStaff(Staf staff)
        {
            return removeData.RemoveStaff(staff);
        }
        
        public int RemoveDepartment(Department department)
        {
            return removeData.RemoveDepartment(department);
        }
        public int RemoveInspection(Inspection inspection)
        {
            return removeData.RemoveInspection(inspection);
        }
        public int RemoveInspectionDetail(InspectionDetails inspectionDetails)
        {
            return removeData.RemoveInspectionDetail(inspectionDetails);
        }
        public int RemoveTaskType(TaskType taskType)
        {
            return removeData.RemoveTaskType(taskType);
        }
        public int RemoveStudent(Student student)
        {
            return removeData.RemoveStudent(student);
        }
        public int RemoveRequest(Request request)
        {
            return removeData.UpdateRequest(request);
        }
        public int RemoveTutorRequest(TutorRequest tutorRequest)
        {
            return removeData.RemoveTutorRequest(tutorRequest);
        }
        public int RemoveModule(Module module)
        {
            return removeData.RemoveModule(module);
        }
    }
}
