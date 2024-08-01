using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace NewClinic
{
    class StoredProcedures
    {
        public static string InsertPatient = "insertPatient";
        public static string Add_P_Account = "insert_Account";
        public static string DisplayDocInfo = "getDoctorInfo";
        public static string DisplayDocDegrees = "Get_Doctor_Degree";
        public static string GetClinicID= "GetClinic_ID";
        public static string DisplayClinicInfo = "getClinicInfo";
        public static string GetAvailableSlots = "GetanAppointment";
        public static string UpdateSlots = "UpdaterRegisteredAppointments";
        public static string GetAppointmentInfo = "GetRegisteredAppointmentInfo";
        public static string InsertanAppointment = "PutSlotInAppointmentTable";
        public static string GetPastAppointments = "NewPastAppointments";
        public static string GetDoctorsinSpecialization = "GetDoctorsthroughSpeciality";
        public static string Insert_Patient_symptoms = "Insert_Patient_symptoms";
        public static string Delete_appointment = "Delete_appointment";
        public static string Upcoming_appointment = "UpcomingAppointments";
  
        


    }
}
