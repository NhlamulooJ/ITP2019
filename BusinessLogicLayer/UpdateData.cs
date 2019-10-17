using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
   public class UpdateData
   {
        Insert_RetrieveData update = new Insert_RetrieveData();

        public int UpdateDepartment(Department department)
        {
            return update.UpdateDepartment(department);
        }

        public int UpdateStaff(Staf staff)
        {
            return update.UpdateStaff(staff);
        }
        public int UpdateVenue(Venue venue)
        {
            return update.UpdateVenue(venue);
        }
        public int UpdateEquipmentType(EquipmentType equipmentType)
        {
            return update.UpdateEquipmentType(equipmentType);
        }
        public int UpdateEquipment(Equipment equipment)
        {
            return update.UpdateEquipment(equipment);
        }
        public int UpdateInspection(Inspection inspection)
        {
            return update.UpdateInspection(inspection);
        }
        public int UpdateInspectionDetail(InspectionDetails inspectionDetails)
        {
            return update.UpdateInspectionDetail(inspectionDetails);
        }
        public int UpdateTaskType(TaskType taskType)
        {
            return update.UpdateTaskType(taskType);
        }
        public int UpdateStudent(Student student)
        {
            return update.UpdateStudent(student);
        }
        public int UpdateRequest(Request request)
        {
            return update.UpdateRequest(request);
        }
        public int UpdateTutorRequest(TutorRequest tutorRequest)
        {
            return update.UpdateTutorRequest(tutorRequest);
        }
        public int UpdateModule(Module module)
        {
            return update.UpdateModule(module);
        }
        public int ReportUpdateStaff(Staf staf)
        {
            return update.ReportUpdateStaff(staf);
        }
   }
}
