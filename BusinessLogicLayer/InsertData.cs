using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
namespace BusinessLogicLayer
{
   public class InsertData
   {
        Insert_RetrieveData Insert = new Insert_RetrieveData();

        public int InsertStaff(Staf staff)
        {
            return Insert.InsertStaff(staff);
        }
        public int InsertDepartment(Department department)
        {
            return Insert.InsertDepartment(department);
        }
        public int InsertVenue(Venue venue)
        {
            return Insert.InsertVenue(venue);
        }
        public int InsertEquipmentType(EquipmentType equipmentType)
        {
            return Insert.InsertEquipmentType(equipmentType);
        }
        public int InsertEquipment(Equipment equipment)
        {
            return Insert.InsertEquipment(equipment);
        }
        public int InsertInspection(Inspection inspection)
        {
            return Insert.InsertInspection(inspection);
        }
        public int InsertInspectionDetail(InspectionDetails inspectionDetails)
        {
            return Insert.InsertInspectionDetail(inspectionDetails);
        }
        public int InsertTaskType(TaskType taskType)
        {
            return Insert.InsertTaskType(taskType);
        }
        public int InsertStudent(Student student)
        {
            return Insert.InsertStudent(student);
        }
        public int InsertRequest(Request request)
        {
            return Insert.InsertRequest(request);
        }
        public int InsertTutorRequest(TutorRequest tutorRequest)
        {
            return Insert.InsertTutorRequest(tutorRequest);
        }
        public int InsertModule(Module module)
        {
            return Insert.InsertModule(module);
        }
   }
}
