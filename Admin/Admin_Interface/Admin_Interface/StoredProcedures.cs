using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admin_Interface
{
    public class StoredProcedures
    {
        public static string insert_Clinic = "InsertClinic";
        public static string insert_Doctor = "InsertDoctor";
        public static string insert_receptionist = "InsertReceptionist";
        public static string select_clinic = "selectClinic";
        public static string select_Doctors = "SelectDoctors";
        public static string Update_Doctor = "UPDATEDoctor";
        public static string Delete_Doctor = "DeleteDoctor";
        public static string SelectReceptionist = "SelectReceptionist";
        public static string Update_Receptionsit = "UpdateReceptionist";
        public static string Delete_Receptionist = "DeleteReceptionist";
        public static string CheckDRUserName = "CheckDoctorUserName";
        public static string Check_Rec_UserName = "CheckRecepUserName";
        public static string CheckClinic_Rec = "CheckClinic_RECEPTIONIST";
        public static string CheckClinic_DR = "CheckClinic_Doctor";
        public static string CheckClinic = "CheckClinic";
        public static string selectID = "SelectIDCombobox";
        public static string AddAmin = "AddNewAdmin";
    }
}
