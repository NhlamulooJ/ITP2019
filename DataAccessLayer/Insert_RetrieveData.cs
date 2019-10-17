using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Web;
namespace DataAccessLayer
{
    public class Insert_RetrieveData
    {
      static  string con = WebConfigurationManager.ConnectionStrings["Data Source=(localdb)\v11.0;Initial Catalog=ProjectDB;Integrated Security=True"].ConnectionString;
        SqlConnection dbConn = new SqlConnection(con);
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapater;

        // Methods to Insert 
        public int InsertStaff(Staf staff)
        {

            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffNumber",staff.StaffNumber );
            dbCmd.Parameters.AddWithValue("@staffName", staff.StaffName);
            dbCmd.Parameters.AddWithValue("@staffSurname",staff.StaffSurname);
            dbCmd.Parameters.AddWithValue("@emailAddress", staff.StaffEmail);
            dbCmd.Parameters.AddWithValue("@contactNumber", staff.ContactNumber);
            dbCmd.Parameters.AddWithValue("@staffType", staff.StaffType);
            dbCmd.Parameters.AddWithValue("@departmentCode", staff.Department);
            dbCmd.Parameters.AddWithValue("@staus", staff.Status);
            int x = dbCmd.ExecuteNonQuery();
            return x;


        }
        public int UpdateStaff(Staf staff)
        {

            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffCode", staff.StaffCode);
            dbCmd.Parameters.AddWithValue("@staffNumber", staff.StaffNumber);
            dbCmd.Parameters.AddWithValue("@staffName", staff.StaffName);
            dbCmd.Parameters.AddWithValue("@staffSurname", staff.StaffSurname);
            dbCmd.Parameters.AddWithValue("@emailAddress", staff.StaffEmail);
            dbCmd.Parameters.AddWithValue("@staffType", staff.StaffType);
            dbCmd.Parameters.AddWithValue("@contactNumber", staff.ContactNumber);
            dbCmd.Parameters.AddWithValue("@departmentCode", staff.Department);
            int x = dbCmd.ExecuteNonQuery();
            return x;


        }
        public DataTable GetStaffRequest(string staffNumber)
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetRequestForStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffNumber", staffNumber);
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable SearchStudentTextChanged(string studentToFind)
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_SearchStudent", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@studentNumber", studentToFind);
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable CountTotals()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_CountTotals", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetAssignedStaff()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetAssignedStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetStaff()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetStaffReport(string staffNumber)
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_StaffReport", dbConn);
            dbCmd.Parameters.AddWithValue("@staffNumber", staffNumber);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable LogiForNormalStaff(string staffNumber,string pass)
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_StaffReport", dbConn);
            dbCmd.Parameters.AddWithValue("@staffNumber", staffNumber);
            dbCmd.Parameters.AddWithValue("@staffPassword", pass);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetVenue()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetVenue", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetTutorRequest()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetTutortRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetEquipmentType()
        {
            try { dbConn.Open(); } catch { }
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetEquipmentType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);

            return dt;
        }
        public DataTable EquipmentsToBeFixed()
        {
            try { dbConn.Open(); } catch { }
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_EquipmentsToFixed", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);

            return dt;
        }
        public DataTable GetInspectionByDate(string date)
        {
            try { dbConn.Open(); } catch { }
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetInspectionByDate", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@date", date);
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);

            return dt;
        }
        public DataTable SearchStudent(string studentNo)
        {
            try { dbConn.Open(); } catch { }
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_SearchStudent", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@studentNumber", studentNo);
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);

            return dt;
        }
        public DataTable TotalRequests()
        {
            try { dbConn.Open(); } catch { }
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_TotalRequests", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);

            return dt;
        }
        public DataTable TutorRequestByVenue(string venueName)
        {
            try { dbConn.Open(); } catch { }
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_TutorRequestByVenue", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@venueName", venueName);
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);

            return dt;
        }
        public DataTable TutorRequestByModule(string moduleDesc)
        {
            try { dbConn.Open(); } catch { }
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_TutorRequestByModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@moduleDesc", moduleDesc);
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);

            return dt;
        }
        public DataTable Tasks(string date)
        {
            try { dbConn.Open(); } catch { }
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_Tasks", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@date", date);
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);

            return dt;
        }
        public int InsertDepartment(Department department)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertDepartment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@departmentName", department.DepartmentName);
            dbCmd.Parameters.AddWithValue("@building", department.Building);
            dbCmd.Parameters.AddWithValue("@contactPerson", department.ContactPerson);
            dbCmd.Parameters.AddWithValue("@email", department.Email);

           int x= dbCmd.ExecuteNonQuery();
            return x;
        }
        public int InsertTutorRequest(TutorRequest tutorRequest)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertTutorRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("requestCode", tutorRequest.RequestCode);
            dbCmd.Parameters.AddWithValue("@moduleCode",tutorRequest.ModuleCode);
            dbCmd.Parameters.AddWithValue("@taskTypeCode", tutorRequest.TaskTypeCode);
            dbCmd.Parameters.AddWithValue("venueCode", tutorRequest.VenueCode);
            dbCmd.Parameters.AddWithValue("@date",tutorRequest.Date);
            dbCmd.Parameters.AddWithValue("@endTime", tutorRequest.EndTime);
            dbCmd.Parameters.AddWithValue("@startTime", tutorRequest.StartTime);
            dbCmd.Parameters.AddWithValue("@status", tutorRequest.Status);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int UpdateTutorRequest(TutorRequest tutorRequest)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateTutorRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@tutorRequestCode", tutorRequest.TutorRequestCode);
           // dbCmd.Parameters.AddWithValue("@tutorRequestDesc", tutorRequest.TutorRequestDesc);
            dbCmd.Parameters.AddWithValue("requestCode", tutorRequest.RequestCode);
            dbCmd.Parameters.AddWithValue("@moduleCode", tutorRequest.ModuleCode);
            dbCmd.Parameters.AddWithValue("@taskTypeCode", tutorRequest.TaskTypeCode);
            dbCmd.Parameters.AddWithValue("@date", tutorRequest.Date);
            dbCmd.Parameters.AddWithValue("venueCode", tutorRequest.VenueCode);
            dbCmd.Parameters.AddWithValue("@endTime", tutorRequest.EndTime);
            dbCmd.Parameters.AddWithValue("@startTime", tutorRequest.StartTime);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public DataTable GetDepartment()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetDepartment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetEquipment()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetEquipment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetInspectionDetail()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetInspectionDetail", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetBrokeEquipment()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_BrokeEquipments", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetTaskType()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetTaskType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetInspection()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetInspection", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetAdminStaff()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetAdminStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetModule()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetStudent()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetStudent", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetRequest()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }
        public DataTable GetRequestForTutorRequest()
        {
            DataTable dt = new DataTable();
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetRequestForTutorRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(dt);
            return dt;
        }

        public int UpdateDepartment(Department department)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateDepartment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@departmentName", department.DepartmentName);
            dbCmd.Parameters.AddWithValue("@deparmentCode", department.Code);
            dbCmd.Parameters.AddWithValue("@building", department.Building);
            dbCmd.Parameters.AddWithValue("@contactPerson", department.ContactPerson);
            dbCmd.Parameters.AddWithValue("@email", department.Email);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertEquipment(Equipment equipment)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertEquipment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@equipmentDesc", equipment.EquipmentDesc);
            dbCmd.Parameters.AddWithValue("@equipmentTypeCode", equipment.EquipmentType);
            dbCmd.Parameters.AddWithValue("@venueCode", equipment.Venue);
            dbCmd.Parameters.AddWithValue("@status", equipment.Status);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        
        public int UpdateEquipment(Equipment equipment)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateEquipment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@equipmentDesc", equipment.EquipmentDesc);
            dbCmd.Parameters.AddWithValue("@equipmentTypeCode", equipment.EquipmentType);
            dbCmd.Parameters.AddWithValue("@venueCode", equipment.Venue);
            dbCmd.Parameters.AddWithValue("@equipmentCode", equipment.EquipmentCode);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveEquipment(Equipment equipment)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveEquipment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@equipmentCode", equipment.EquipmentCode);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveVenue(Venue venue)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveVenue", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@venueCode", venue.VenueCode);
            dbCmd.Parameters.AddWithValue("@status", venue.Status);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveRequest(Request request)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveEquipment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@requestCode", request.RequestCode);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveTutorRequest(TutorRequest tutorRequest)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveTutorRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@tutorRequestCode", tutorRequest.TutorRequestCode);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public DataTable GetLogin(string number, string password)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_GetLogin", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffNumber",number);
            dbCmd.Parameters.AddWithValue("@staffPassword", password);
            DataTable data = new DataTable();
            dbAdapater = new SqlDataAdapter(dbCmd);
            dbAdapater.Fill(data);

            return data;

        }
        public int RemoveModule(Module module)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@moduleCode", module.ModuleCode);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveInspectionDetail(InspectionDetails inspectionDetails)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveInspectionDetail", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@inspectionDetailCode", inspectionDetails.InspectionDetailCode);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveEquipmentType(EquipmentType equipmentType)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveEquipmentType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@equipmentTypeCode", equipmentType.EquipmentCode);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveTaskType(TaskType taskType)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveTaskType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@taskTypeCode", taskType.TaskTypeCode);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveStaff(Staf staff)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffCode", staff.StaffCode);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveStudent(Student student)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveStudent", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@studentCode", student.StudentCode);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveDepartment(Department department)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveDepartment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@departmentCode", department.Code);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int RemoveInspection(Inspection inspection)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_RemoveInspection", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@code", inspection.InspectionCode);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int InsertEquipmentType(EquipmentType equipmentType)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertEquipmentType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@equipmentTypeDesc", equipmentType.equipmentTypeDesc);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int UpdateEquipmentType(EquipmentType equipmentType)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateEquipmentType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@equipmentTypeCode", equipmentType.EquipmentCode);
            dbCmd.Parameters.AddWithValue("@equipmentTypeDesc", equipmentType.equipmentTypeDesc);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int ReportUpdateStaff(Staf staff)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_ReportUpdateStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffName", staff.StaffName);
            dbCmd.Parameters.AddWithValue("@staffSurname", staff.StaffSurname);
            dbCmd.Parameters.AddWithValue("@staffEmail", staff.StaffEmail);
            dbCmd.Parameters.AddWithValue("@staffContactNumber", staff.ContactNumber);
            dbCmd.Parameters.AddWithValue("@staffPassword", staff.Password);
            dbCmd.Parameters.AddWithValue("@staffCode", staff.StaffCode);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int UpdateInspection(Inspection inspection)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateInspection", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffCode", inspection.StaffCode);
            dbCmd.Parameters.AddWithValue("@venueCode", inspection.VenueCode);
            dbCmd.Parameters.AddWithValue("@comment", inspection.Comment);
            dbCmd.Parameters.AddWithValue("@inspectionCode", inspection.InspectionCode);
            dbCmd.Parameters.AddWithValue("@date", inspection.Date);
            dbCmd.Parameters.AddWithValue("@time", inspection.Time);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int InsertInspection(Inspection inspection)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertInspection", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffCode", inspection.StaffCode);
            dbCmd.Parameters.AddWithValue("@venueCode", inspection.VenueCode);
            dbCmd.Parameters.AddWithValue("@comment", inspection.Comment);
            dbCmd.Parameters.AddWithValue("@date", inspection.Date);
            dbCmd.Parameters.AddWithValue("@time", inspection.Time);
            dbCmd.Parameters.AddWithValue("@status", inspection.Status);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int InsertModule(Module module)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@moduleDesc", module.ModuleDesc);
            dbCmd.Parameters.AddWithValue("@status", module.Status);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int UpdateModule(Module module)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateModule", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@moduleDesc", module.ModuleDesc);
            dbCmd.Parameters.AddWithValue("@moduleCode", module.ModuleCode);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        //public DataTable GetInspection()
        //{
        //    DataTable dt = new DataTable();
        //    try { dbConn.Open(); } catch { }
        //    dbCmd = new SqlCommand("sp_GetInspection", dbConn);
        //    dbCmd.CommandType = CommandType.StoredProcedure;
        //    dbAdapater = new SqlDataAdapter(dbCmd);
        //    dbAdapater.Fill(dt);
        //    return dt;
        //}
        public int InsertInspectionDetail(InspectionDetails inspectionDetails)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertInspectionDetail", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@inspectionCode", inspectionDetails.InspectionCode);
            dbCmd.Parameters.AddWithValue("@faultComment", inspectionDetails.FaultComment);
            dbCmd.Parameters.AddWithValue("@staffCode", inspectionDetails.StaffCode);
            dbCmd.Parameters.AddWithValue("@equipmentCode", inspectionDetails.EquipmentCode);
            dbCmd.Parameters.AddWithValue("@status", inspectionDetails.Status);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertStudent(Student student)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertStudent", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@studentNumber", student.StudentNumber);
            dbCmd.Parameters.AddWithValue("@studentName",student.StudentName);
            dbCmd.Parameters.AddWithValue("@studentSurname",student.StudentSurname);
            dbCmd.Parameters.AddWithValue("@emailAddress", student.EmailAddress);
            dbCmd.Parameters.AddWithValue("@status", student.Status);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int UpdateStudent(Student student)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateStudent", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@studentCode", student.StudentCode);
            dbCmd.Parameters.AddWithValue("@studentNumber", student.StudentNumber);
            dbCmd.Parameters.AddWithValue("@studentName", student.StudentName);
            dbCmd.Parameters.AddWithValue("@studentSurname", student.StudentSurname);
            dbCmd.Parameters.AddWithValue("@emailAddress", student.EmailAddress);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int InsertRequest(Request request)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@staffCode", request.StaffCode);
            dbCmd.Parameters.AddWithValue("@requestDescription", request.RequestDescription);
            dbCmd.Parameters.AddWithValue("@studentCode", request.StudentCode);
            dbCmd.Parameters.AddWithValue("@taskTypeCode", request.TaskTypeCode);
            dbCmd.Parameters.AddWithValue("@date", request.Date);
            dbCmd.Parameters.AddWithValue("@time", request.Time);
            dbCmd.Parameters.AddWithValue("@status", request.Status);
            dbCmd.Parameters.AddWithValue("@assignedStaff", request.AssignedStaff);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int UpdateRequest(Request request)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.AddWithValue("@requestCode", request.RequestCode);
            dbCmd.Parameters.AddWithValue("@requestDescription", request.RequestDescription);
            dbCmd.Parameters.AddWithValue("@staffCode", request.StaffCode);
            dbCmd.Parameters.AddWithValue("@studentCode", request.StudentCode);
            dbCmd.Parameters.AddWithValue("@taskTypeCode", request.TaskTypeCode);
            dbCmd.Parameters.AddWithValue("@date", request.Date);
            dbCmd.Parameters.AddWithValue("@time", request.Time);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }




        public int InsertTaskType(TaskType taskType)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertTaskType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@taskTypeName", taskType.TaskTypeName);
            dbCmd.Parameters.AddWithValue("status", taskType.Status);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int UpdateTaskType(TaskType taskType)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateTaskType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@taskTypeCode", taskType.TaskTypeCode);
            dbCmd.Parameters.AddWithValue("@taskTypeName", taskType.TaskTypeName);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public int UpdateInspectionDetail(InspectionDetails inspectionDetails)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateInspectionDetail", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@inspectionCode", inspectionDetails.InspectionCode);
            dbCmd.Parameters.AddWithValue("@faultComment", inspectionDetails.FaultComment);
            dbCmd.Parameters.AddWithValue("@staffCode", inspectionDetails.StaffCode);
            dbCmd.Parameters.AddWithValue("@equipmentCode", inspectionDetails.EquipmentCode);
            dbCmd.Parameters.AddWithValue("@status", inspectionDetails.Status);
            dbCmd.Parameters.AddWithValue("@inspectionDetailCode", inspectionDetails.InspectionDetailCode);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertVenue(Venue venue)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_InsertVenue", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@venueDescription", venue.VenueDescription);
            dbCmd.Parameters.AddWithValue("@venueName", venue.VenueName);
            dbCmd.Parameters.AddWithValue("status", venue.Status);
            dbCmd.Parameters.AddWithValue("@venueCapacity", venue.VenueCapacity);
            int d = dbCmd.ExecuteNonQuery();
            return d;
        }
        public int UpdateVenue(Venue venue)
        {
            try { dbConn.Open(); } catch { }
            dbCmd = new SqlCommand("sp_UpdateVenue", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@venueCode", venue.VenueCode);
            dbCmd.Parameters.AddWithValue("@venueDescription", venue.VenueDescription);
            dbCmd.Parameters.AddWithValue("@venueName", venue.VenueName);
            dbCmd.Parameters.AddWithValue("@venueCapacity", venue.VenueCapacity);
            int d = dbCmd.ExecuteNonQuery();
            return d;
        }
        //public int InsertSession(Session session)
        //{
        //    try { dbConn.Open(); } catch { }
        //    dbCmd = new SqlCommand("sp_InsertSession", dbConn);
        //    dbCmd.CommandType = CommandType.StoredProcedure;
        //    dbCmd.Parameters.AddWithValue("@", session.StartDate);
        //    dbCmd.Parameters.AddWithValue("@", session.ModuleID);
        //    dbCmd.Parameters.AddWithValue("@", session.StaffNumber);
        //    dbCmd.Parameters.AddWithValue("@", session.EndDate);
        //    dbCmd.Parameters.AddWithValue("@", session.VenueID);

        //    int x = dbCmd.ExecuteNonQuery();
        //    return x;

        //}

        //public int UpdateSession(Session session)
        //{
        //    try { dbConn.Open(); } catch { }
        //    dbCmd = new SqlCommand("sp_InsertSession", dbConn);
        //    dbCmd.CommandType = CommandType.StoredProcedure;
        //    dbCmd.Parameters.AddWithValue("@", session.StartDate);
        //    dbCmd.Parameters.AddWithValue("@", session.SessionID);
        //    dbCmd.Parameters.AddWithValue("@", session.ModuleID);
        //    dbCmd.Parameters.AddWithValue("@", session.StaffNumber);
        //    dbCmd.Parameters.AddWithValue("@", session.EndDate);
        //    dbCmd.Parameters.AddWithValue("@", session.VenueID);

        //    int x = dbCmd.ExecuteNonQuery();
        //    return x;

        //}









    }
}
