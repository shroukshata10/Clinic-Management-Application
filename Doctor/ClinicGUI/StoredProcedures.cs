using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicGUI
{
    class StoredProcedures
    {
        public static string SelectAssignedClinics = "SelectAssignedClinics";
        public static string UpdateDoctorInfo = "UpdateDoctorInfo";
        public static string EnterDiagnosis = "EnterDiagnosis";
        public static string EnterMedicine = "EnterMedicine";
        public static string CountPatients = "CountPatients";
        public static string GetMyPatient = "GetMyPatient";
        public static string GetSpecifiedPatient = "GetSpecifiedPatient";
        public static string GetAppointmentMedicine = "GetAppointmentMedicine";
        public static string GetAppointmentDiagnosis = "GetAppointmentDiagnosis";
        public static string GetAppointmentComments = "GetAppointmentComments";
        public static string GetAllDiagnosis = "GetAllDiagnosis";
        public static string GetAllMedicines = "GetAllMedicines";
        public static string SetPatientDiagnosis = "SetPatientDiagnosis";
        public static string SetPatientMedicine = "SetPatientMedicine";
        public static string EnterComment = "EnterComment";
        public static string GetDoctorDegree = "GetDoctorDegree";

    }
}
