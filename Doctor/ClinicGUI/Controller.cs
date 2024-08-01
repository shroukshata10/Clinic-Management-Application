using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ClinicGUI
{
    class Controller

    {
        DBManager dBManager;
        public Controller()
        {
            dBManager = new DBManager();
        }
        public char checkUsernameandPass(string username, string pass)
        {
            string query = "SELECT Type FROM Account  WHERE User_name = '" + username + "'" + "AND Password = '" + pass + "';";
            object m = dBManager.ExecuteScalar(query);
            if (m == null)
                return '0';
            int x = (int)dBManager.ExecuteScalar(query);
            if (x == 1)
                return 'D';
            if (x == 2)
                return 'R';
            if (x == 3)
                return 'P';
            if (x == 4)
                return 'A';
            else
                return '0';
        }

        public DataTable getDoctorInfo(string Username)
        {
            string query = "SELECT * FROM Doctor WHERE DUser_Name= '" + Username + "';";
            return dBManager.ExecuteReader(query);
        }
        public DataTable GetDoctorDegree(string Username)
        {
            String StoredProcedureName = StoredProcedures.GetDoctorDegree;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Dr_User_Name", Username);
            return dBManager.ExecuteReader(StoredProcedureName, param);
        }
        public DataTable SelectAssignedClinics(string Username)
        {
            String StoredProcedureName = StoredProcedures.SelectAssignedClinics;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@DUsername", Username);
            return dBManager.ExecuteReader(StoredProcedureName, param);
        }
        public bool UpdateDoctorInfo(string name,string adr,string Dphone_number,int fees,string pass,string account)
        {
            String StoredProcedureName = StoredProcedures.UpdateDoctorInfo;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@DName", name);
            param.Add("@D_Address", adr);
            param.Add("Dphone_number", Dphone_number);
            param.Add("@Fees", fees);
            param.Add("@Password", pass);
            param.Add("@DUser_Name", account);
            param.Add("@User_name", account);
            int x = dBManager.ExecuteNonQuery(StoredProcedureName, param);
            if (x == 0)
                return false;
            else
                return true;

        }
        public bool EnterDiagnosis(string d)
        {
            String StoredProcedureName = StoredProcedures.EnterDiagnosis;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Scientific_Name", d);
            int x = dBManager.ExecuteNonQuery(StoredProcedureName, param);
            if (x == 0)
                return false;
            else
                return true;
        }

        public DataTable getPassword(string user)
        {
            string query = "SELECT Password FROM Account WHERE User_name= '" + user + "';";
            return dBManager.ExecuteReader(query);
        }
   

    public bool EnterNewMedicine(string name)
    {
        String StoredProcedureName = StoredProcedures.EnterMedicine;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Mname", name);
            int x = dBManager.ExecuteNonQuery(StoredProcedureName, param);
            if (x == 0)
                return false;
            else
                return true;
        }

        public int GetPatientNumber(string user)
        {
            String StoredProcedureName = StoredProcedures.CountPatients;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@DR_UserName", user);
            int x = (int)dBManager.ExecuteScalar(StoredProcedureName, param);
            return x;
        }
        public DataTable GetMyPatient(string username)
        {
            String StoredProcedureName = StoredProcedures.GetMyPatient;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@DR_UserName", username);
            
            return dBManager.ExecuteReader(StoredProcedureName,param);
        }
        public DataTable GetSpecifiedPatient(string drUser, string paUser)
        {
            String StoredProcedureName = StoredProcedures.GetSpecifiedPatient;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@DR_UserName", drUser);
            param.Add("@Patient_UserName", paUser);
            return dBManager.ExecuteReader(StoredProcedureName, param);


        }
        public DataTable GetAppointmentMedicine(int id)
        {
            String StoredProcedureName = StoredProcedures.GetAppointmentMedicine;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Appointment_ID", id);
           
            return dBManager.ExecuteReader(StoredProcedureName, param);


        }
        public DataTable GetAppointmentDiagnosis(int id)
        {
            String StoredProcedureName = StoredProcedures.GetAppointmentDiagnosis;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Appointment_ID", id);

            return dBManager.ExecuteReader(StoredProcedureName, param);


        }
        
             public DataTable GetAppointmentComments(int id)
        {
            String StoredProcedureName = StoredProcedures.GetAppointmentComments;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Appointment_ID", id);

            return dBManager.ExecuteReader(StoredProcedureName, param);


        }

        public DataTable GetAllMedicines()
        {
            String StoredProcedureName = StoredProcedures.GetAllMedicines;
            return dBManager.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable GetAllDiagnosis()
        {
            String StoredProcedureName = StoredProcedures.GetAllDiagnosis;
            return dBManager.ExecuteReader(StoredProcedureName, null);

        }
        public bool SetPatientDiagnosis(int App_id,string dia)
        {
            String StoredProcedureName = StoredProcedures.SetPatientDiagnosis;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Appointment_ID", App_id);
            param.Add("@Diangnosis_Name", dia);
            int x = dBManager.ExecuteNonQuery(StoredProcedureName, param);
            if (x == 0)
                return false;
            else
                return true;


        }

        public bool SetPatientMedicine(int App_id, string med)
        {
            String StoredProcedureName = StoredProcedures.SetPatientMedicine;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Appointment_ID", App_id);
            param.Add("@Medicine_Name", med);
            int x = dBManager.ExecuteNonQuery(StoredProcedureName, param);
            if (x == 0)
                return false;
            else
                return true;


        }
        public bool EnterComment(int App_id, string comm)
        {
            String StoredProcedureName = StoredProcedures.EnterComment;
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Appointment_ID", App_id);
            param.Add("@Comments", comm);
            int x = dBManager.ExecuteNonQuery(StoredProcedureName, param);
            if (x == 0)
                return false;
            else
                return true;
        }
    }
}
