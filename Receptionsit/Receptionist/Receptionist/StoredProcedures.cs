using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptionist
{
    public class StoredProcedures
        {
            public static string Appointments = "SelectAppointments";
            public static string search = "Search_appointment";
            public static string delete = "Delete_appointment";
            public static string ADDFreeSlot = "ADD_Free_Slot";
            public static string FreeSlots = "Show_Slots";
            public static string Medicine = "Show_Medicine";
            public static string Add_Medicine = "ADD_Medicine";
            public static string ShowDoctors = "Show_Doctors";
            public static string Clinic_ID = "GetClinic_ID";
            public static string Register = "register";
    }
}
