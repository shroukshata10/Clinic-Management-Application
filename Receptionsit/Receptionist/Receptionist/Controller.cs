using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Receptionist
{

    public class Controller
    {
        DBManager dbclinic;
        public Controller()
        {
            dbclinic = new DBManager();

        }

        public static int ClinicID=0;
        public static string Doctor= "";
        public void Drsetter(string Dr) { Doctor = Dr; }
        public void CIDsetter(int id)
        {
            ClinicID = id;
        }
        public string Drgetter() { return Doctor; }
        public int CIDgetter()
        {
            return ClinicID;
        }

        public DataTable SelectAppointments(string x)
        {
            string StoredProcedureApp = StoredProcedures.Appointments;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dr_Name", x);
            return dbclinic.ExecuteReader(StoredProcedureApp, Parameters);
        }

        public DataTable searchAppointments(int id, string name, string x)
        {

            string StoredProceduresearch = StoredProcedures.search;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Patient_name", name);
            Parameters.Add("@appointment_id", id); //
            Parameters.Add("@Dr_Name", x);
            return dbclinic.ExecuteReader(StoredProceduresearch, Parameters);
        }

        public int ADDSlot(string name, int id, string day, string Start, string End, int clinic)
        {
            //@Dr_Name  varchar(50), 
            //           @ID int,
            //           @Day varchar(50), 
            //@start time,
            //   @End time,
            //	@clinic int

            //(Appointment_ID,DUsername,Day,Start_time,End_time,Registered,Clinic_ID)

            string StoredProcedurADDSlot = StoredProcedures.ADDFreeSlot;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Dr_Name", name);
            Parameters.Add("@ID", id);
            Parameters.Add("@Day", day);
            Parameters.Add("@start", Start);
            Parameters.Add("@End", End);
            Parameters.Add("@clinic", clinic);

            return dbclinic.ExecuteNonQuer(StoredProcedurADDSlot, Parameters);
        }

        public DataTable ShowDoctors()
        {
            string StoredProcedureDoctors = StoredProcedures.ShowDoctors;
            return dbclinic.ExecuteReader(StoredProcedureDoctors, null);
        }

        public DataTable ShowSlots(string x)
        {
            string StoredProcedurShowSlots = StoredProcedures.FreeSlots;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Dr_Name", x);
            return dbclinic.ExecuteReader(StoredProcedurShowSlots, Parameters);
        }

        public int Delete_Appointments(int id)
        {
            string StoredProcedurDelete = StoredProcedures.delete;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
              Parameters.Add("@appointment_id", id);
            return dbclinic.ExecuteNonQuer(StoredProcedurDelete, Parameters);
        }

        public DataTable ShowMedicine()
        {

            string StoredProcedureMedicine = StoredProcedures.Medicine;
            return dbclinic.ExecuteReader(StoredProcedureMedicine,null);
        }

        public int ADD_Medicine(string name, int code, int price)
        {
            string StoredProcedurADDMed = StoredProcedures.Add_Medicine;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Medicine_name ", name);
            Parameters.Add("@Code", code);
            Parameters.Add("@Price", price);

            return dbclinic.ExecuteNonQuer(StoredProcedurADDMed, Parameters);
        }

        public int Register(string Dname, int id, string day, string Pname, int clinic)
        {
 

            string StoredProcedurRegister = StoredProcedures.Register;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Dr_Name", Dname);
            Parameters.Add("@ID", id);
            Parameters.Add("@Day", day);
            Parameters.Add("@Patient_name", Pname);
            Parameters.Add("@clinic", clinic);

            return dbclinic.ExecuteNonQuer(StoredProcedurRegister, Parameters);
        }


        public DataTable Doctor_Info()
        {

            string query = "select DName,Dphone_number,Fees,Specialization from doctor where duser_name = '" + Doctor+ "';";  //////to make sure about the syntax
            return dbclinic.ExecuteReader1(query);
 
        }

        public DataTable Doctor_Ava()
        {
            string query1 = "SELECT Day, Start_time, End_time FROM Doctor_Availability WHERE DUsername = '" + Doctor + "';";  //////To make sure about the syntax
            return dbclinic.ExecuteReader1(query1);
        }

        /* public void Clinic_doctors(ref string[] ArrSpecialization, Form4 DA)  //First Thought for form4 but didn't used
    {

        string query2 = "SELECT DUser_Name FROM Doctor";
        string query3 = "SELECT Specialization FROM Doctor";

        DataTable Names = dbclinic.ExecuteReader(query2);
        DataTable Specialization = dbclinic.ExecuteReader(query3);
        int indexer = 0;
        int index = 0;
        foreach (DataRow SRow in Names.Rows)
        {
            {
                ArrSpecialization[index] = SRow["Specialization"].ToString();
                indexer += 1;
            }
        }
        foreach (DataRow NRow in Names.Rows)
        {
            {



                Button dynamicButton = new Button();
                dynamicButton.Text = "Doctor: " + NRow.ToString() + "\r\n" + "The Specialization: " + ArrSpecialization[indexer];
                dynamicButton.Visible = true;

                dynamicButton.Location = new System.Drawing.Point(10, 50);
                dynamicButton.Size = new System.Drawing.Size(160, 37);

                dynamicButton.Click += (sender, e) =>
                {
                    int Clinic_ID = Int16.Parse("SELECT DISTINCT Clinic_ID FROM Doctor where DUser_Name ='" + NRow.ToString() + "';");
                    Form5 form = new Form5();
                    Drsetter(NRow.ToString());
                  //  CIDsetter();
                    form.Show();
                    DA.Hide();
                };
                indexer++;
            }
        }
    }


    public int Doc_Num()
    {
        string query = "SELECT COUNT(DUser_Name) FROM Doctor";
        return (int)dbclinic.ExecuteScalar(query);
    }*/

    }
}