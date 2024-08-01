using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace NewClinic
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

      

        public DataTable GetDoctorsinSpecialization(string Specialization)
        {
            string StoredProcedureName = StoredProcedures.GetDoctorsinSpecialization;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Specialization", Specialization);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        
        

        public DataTable GetAvailableSlots()
        {
            string StoredProcedureName = StoredProcedures.GetAvailableSlots;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetClinicID(string Doc_User_name)
        {
            string StoredProcedureName = StoredProcedures.GetClinicID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Doc_User_name", Doc_User_name);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetAppointmentInfo(int Appointment_ID)
        {
            string StoredProcedureName = StoredProcedures.GetAppointmentInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Appointment_ID", Appointment_ID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetPastAppointments(string Patient_UserName)
        {
            string StoredProcedureName = StoredProcedures.GetPastAppointments;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Patient_UserName", Patient_UserName);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Upcoming_appointment(string Patient_UserName)
        {
            string StoredProcedureName = StoredProcedures.Upcoming_appointment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Patient_UserName", Patient_UserName);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        public int Delete_appointment(int appointment_ID)
        {
            string StoredProcedureName = StoredProcedures.Delete_appointment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Appointment_ID", appointment_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertPatient(string PName ,string Phone_num,string P_Address,string PUser_Name,int Age,DateTime Birth_date,string Gender)
        {
            string StoredProcedureName = StoredProcedures.InsertPatient;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PName", PName);
            Parameters.Add("@Phone_num",Phone_num);
            Parameters.Add("@P_Address",P_Address);
            Parameters.Add("@PUser_Name", PUser_Name);
            Parameters.Add("@Age", Age);
            Parameters.Add("@Birth_date", Birth_date);
            Parameters.Add("@Gender", Gender);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateSlots(int Appointment_ID)
        {
            string StoredProcedureName = StoredProcedures.UpdateSlots;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Appointment_ID", Appointment_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
              public int InsertanInAppointment(int Appointment_ID,string DR_UserName,string Patient_UserName,int Clinic_ID)
              {
            string StoredProcedureName = StoredProcedures.InsertanAppointment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Appointment_ID", Appointment_ID);
            Parameters.Add("@DR_UserName", DR_UserName);
            Parameters.Add("@Patient_UserName", Patient_UserName);
            Parameters.Add("@Clinic_ID", Clinic_ID);
 
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
              }

        public int Insert_Patient_symptoms(int Appointment_ID,string Symptoms,string Patient_UserName)
        {
            string StoredProcedureName = StoredProcedures.Insert_Patient_symptoms;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Appointment_ID", Appointment_ID);
            Parameters.Add("@Symptoms", Symptoms);
            Parameters.Add("@Patient_UserName", Patient_UserName);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int Add_P_Account(string User_name, int type, string Password,int Admin_ID)
        {
            string StoredProcedureName = StoredProcedures.Add_P_Account;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_name", User_name);
            Parameters.Add("@Type", type);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Admin_ID", Admin_ID);
  
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public DataTable DisplayDocInfo(string DUser_name)
        {
            string StoredProcedureName = StoredProcedures.DisplayDocInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DUser_Name", DUser_name);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
         
        }

        public DataTable DisplayDocDegrees(string Dr_User_Name)
        {
            string StoredProcedureName = StoredProcedures.DisplayDocDegrees;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dr_User_Name", Dr_User_Name);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public DataTable DisplayClinicInfo( int ID)
        {
            string StoredProcedureName = StoredProcedures.DisplayClinicInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }




    }
}
