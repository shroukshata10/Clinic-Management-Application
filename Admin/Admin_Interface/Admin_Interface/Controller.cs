using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Admin_Interface
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
        public int InsertClinic(int id, string phone_num, string clinic_name, string city, string governorate, string street, string zip_code)
        {

            string StoredProcedureName = StoredProcedures.insert_Clinic;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            Parameters.Add("@Phone_number", phone_num);
            Parameters.Add("@Clinic_name", clinic_name);
            Parameters.Add("@City", city);
            Parameters.Add("@Governorate", governorate);
            Parameters.Add("@Street", street);
            Parameters.Add("@Zip_Code", zip_code);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int insert_Doctor(int ClinicID, string FName, string User_Name, string Password, string BirthDate, string Gender, string phone_number, string Specialization,
                                     string Address, float Fees, string Degree)
        {
            string StoredProcedureName = StoredProcedures.insert_Doctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ClinicID", ClinicID);
            Parameters.Add("@DFName", FName);
            Parameters.Add("@DUser_Name", User_Name);
            Parameters.Add("@DPassword", Password);
            Parameters.Add("@DBirthDate", BirthDate);
            Parameters.Add("@DGender", Gender);
            Parameters.Add("@Dphone_number", phone_number);
            Parameters.Add("@Specialization", Specialization);
            Parameters.Add("@DAddress", Address);
            Parameters.Add("@Fees", Fees);
            Parameters.Add("@Degree", Degree);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int insert_receptionist(int ClinicID, string FName, string User_Name, string Password, string BirthDate, string Gender, string phone_number, 
                                   int salary)
        {
            string StoredProcedureName = StoredProcedures.insert_receptionist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Clinic_ID", ClinicID);
            Parameters.Add("@RFName", FName);
            Parameters.Add("@RUser_Name", User_Name);
            Parameters.Add("@RPassword", Password);
            Parameters.Add("@RBirthDate", BirthDate);
            Parameters.Add("@RGender", Gender);
            Parameters.Add("@Rphone_num", phone_number);
            Parameters.Add("@RSalary",salary);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable Select_Clinic()
        {
            string StoredProcedureName = StoredProcedures.select_clinic;
            
            return dbMan.ExecuteReader(StoredProcedureName, null); 

        }
        public DataTable select_Doctors(int Clinic_ID)
        {
            string StoredProcedureName = StoredProcedures.select_Doctors;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Clinic_ID", Clinic_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int UpdateDoctor(string userName, int fees)
        {
            string StoredProcedureName = StoredProcedures.Update_Doctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserName", userName);
            Parameters.Add("@Fees", fees);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
            /*string query = "UPDATE Doctor SET DUser_Name= '" + userName + "' WHERE Fees = " + fees + ";";
            return dbMan.ExecuteNon_Query(query);*/

        }
        public int DeleteDoctor(string UserName)
        {
            string storedProcedureName = StoredProcedures.Delete_Doctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UserName", UserName);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }
        public DataTable selectReceptionist (int ClinicID)
        {
            string storedProcedureName = StoredProcedures.SelectReceptionist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Clinic_ID", ClinicID);
            return dbMan.ExecuteReader(storedProcedureName, Parameters);
        }
        public int updateRecep(string RUser_Name, int Salary)
        {
            string storedProcedureName = StoredProcedures.Update_Receptionsit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RUserName", RUser_Name);
            Parameters.Add("@Salary", Salary);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
        }
        public int deleteReceptionist(string UserName)
        {
            string storedProcedureName = StoredProcedures.Delete_Receptionist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RUser_Name", UserName);
            return dbMan.ExecuteNonQuery(storedProcedureName, Parameters);
            
        }
        public int checkDUserName(string userName,int ClinicID)
        {
            string storedProcedureName = StoredProcedures.CheckDRUserName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DUserName", userName);
            Parameters.Add("@ClinicID", ClinicID);
            Console.WriteLine(storedProcedureName);
            object result = dbMan.ExecuteScalar(storedProcedureName, Parameters);
            if (result == null) return 0;
            return (int)result;

        }
        
        public int Check_Rec_UserName(string userName, int clinicID )
        {
            string storedProcedureName = StoredProcedures.Check_Rec_UserName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RUserName", userName);
            Parameters.Add("@ClinicID", clinicID);
            Console.WriteLine(storedProcedureName);
            object result = dbMan.ExecuteScalar(storedProcedureName, Parameters);
            if (result == null) return 0;
            return (int)result;


        }
        public int CheckClinicRec(int ClinicID)
        {
            string storedProcedureName = StoredProcedures.CheckClinic_Rec;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ClinicID", ClinicID);
            Console.WriteLine(storedProcedureName);
            object result = dbMan.ExecuteScalar(storedProcedureName, Parameters);
            if (result == null) return 0;
            return (int)result;
        }
        public int CheckClinicDR(int Clinic_ID)
        {
            string storedProcedureName = StoredProcedures.CheckClinic_DR;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ClinicID", Clinic_ID);
            Console.WriteLine(storedProcedureName);
            object result = dbMan.ExecuteScalar(storedProcedureName, Parameters);
            if (result == null) return 0;
            return (int)result;
        }
        public int checkClinic(int clinicID)
        {
            string storedProcedureName = StoredProcedures.CheckClinic;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ClinicID", clinicID);
            Console.WriteLine(storedProcedureName);
            object result = dbMan.ExecuteScalar(storedProcedureName, Parameters);
            if (result == null) return 0;
            return (int)result;
        }
        public DataTable selectID_Combobox()
        {
            String StoredProcedureName = StoredProcedures.selectID;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public int AddAdmin(string User_Name, string Password)
        {
            string StoredProcedureName = StoredProcedures.AddAmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
           
            Parameters.Add("@UserName", User_Name);
            Parameters.Add("@Password", Password);
         
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
    }
    }
