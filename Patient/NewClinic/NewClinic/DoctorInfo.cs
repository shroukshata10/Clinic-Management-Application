using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewClinic
{
    

    public partial class Doctor_sInfo : Form
    {
        Controller controllerObj=new Controller();
       public string Doctor="";
        public string Patient = "";
        int Clinic_id;
        public Doctor_sInfo(string selected_doctor,string patient_Uname)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Doctor = selected_doctor;
            Patient = patient_Uname;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
         
            DataTable Doctor_info = controllerObj.DisplayDocInfo(Doctor);
            DataTable Doctor_Degrees = controllerObj.DisplayDocDegrees(Doctor);
            DataTable ClinicID = controllerObj.GetClinicID(Doctor);
            if(ClinicID != null)
            Clinic_id = ClinicID.Rows[0].Field<int>("Clinic_ID");
           
                DataTable Clinic_Info = controllerObj.DisplayClinicInfo(Clinic_id);
            
         
            if (Doctor_info != null && Doctor_Degrees != null && ClinicID != null && Clinic_Info != null)
            {
                DoctorName.Text = Doctor_info.Rows[0].Field<string>("DName");
                listBox1.DataSource = Doctor_Degrees;
                listBox1.DisplayMember = "Dr_Degree";
                DoctorFees.Text = (Doctor_info.Rows[0].Field<float>("Fees")).ToString();
                ClinicName.Text= Clinic_Info.Rows[0].Field<string>("Clinic_name");
                  Clinic_City.Text= Clinic_Info.Rows[0].Field<string>("City");

                   Clinic_Govern.Text= Clinic_Info.Rows[0].Field<string>("Governorate");

                   Clinic_street.Text= Clinic_Info.Rows[0].Field<string>("Street");

                Clinic_Zip_Code.Text=  Clinic_Info.Rows[0].Field<string>("Zip_Code");
          

            }
            else
            {
                MedicalSpecialities Available_Doctors = new MedicalSpecialities(Patient);
                Available_Doctors.Show();
                this.Close ();
                MessageBox.Show("Please,Choose another doctor!,unfortunately there are no information for this doctor yet! ");
               

            }
              


        }

       private void button2_Click(object sender, EventArgs e)
        {
            MedicalSpecialities Available_Doctors = new MedicalSpecialities(Patient);
            Available_Doctors.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           RegisterAnAppointment appointment = new RegisterAnAppointment(Patient);
            appointment.Show();
            this.Hide();
        }

        private void Doctor_sInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_sInfo_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void DoctorDegree_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
