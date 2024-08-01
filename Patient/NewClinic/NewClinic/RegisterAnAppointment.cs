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
    public partial class RegisterAnAppointment : Form
    {
        Controller controllerObj;
        public static string P_Username="";
        public static string D_Username="";
        public static int Clinic_id=0;
        public static int Appoint_id = 0;
        public static string selectedvalue = "";
        public static int count = 0;
        public static string Symptoms = "";


        public RegisterAnAppointment(string patient)
        {
            InitializeComponent();
            P_Username = patient;
            controllerObj = new Controller();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int result1 ;
            int result2 ;
            
            
            DataTable AvailableSlots = controllerObj.GetAvailableSlots();
            if (AvailableSlots != null)
            {


                comboBox1.DataSource = AvailableSlots;
                AvailableSlots.Columns.Add(
                "Register Time",
                 typeof(string), "Day +' '+Start_time");
                //AvailableSlots.Columns.Add("Appointment_ID");
                comboBox1.DisplayMember = "Register Time";

                if(selectedvalue == "")
                {
                    MessageBox.Show("Please, Choose an apointment first!");
                }

                if(count == 1)
                {
                    RegisterButton.Enabled = false;
                    MessageBox.Show("You have already registered an appointment!");
                }

                else
                {
                    if(Symptoms == "")
                    {
                        MessageBox.Show("Please, Enter your symptoms separated by commas first!");
                    }

                    else
                    {
                        MessageBox.Show("You have registered an appointment successfully!");
                        count++;

                        SelectedTime.Text = comboBox1.Text;
                        int App_id = (from DataRow dr in AvailableSlots.Rows
                                      where (string)dr["Register Time"] == SelectedTime.Text
                                      select (int)dr["Appointment_ID"]).FirstOrDefault();
                        if (App_id != 0)
                        {
                            Appoint_id = App_id;
                            result1 = controllerObj.UpdateSlots(App_id);
                            DataTable Appointment_Info = controllerObj.GetAppointmentInfo(App_id);
                            if (Appointment_Info != null && P_Username != "")
                            {
                                D_Username = Appointment_Info.Rows[0].Field<string>("DUsername");
                                Clinic_id = Appointment_Info.Rows[0].Field<int>("Clinic_ID");
                                result2 = controllerObj.InsertanInAppointment(App_id, D_Username, P_Username, Clinic_id);


                            }
                        }

                    }
                       
                }

            }

               
          
            else
            {
                MessageBox.Show("Sorry,there are no available slots at this time.");
                MedicalSpecialities Available_Doctors = new MedicalSpecialities(P_Username);
                Available_Doctors.Show();
                this.Hide();
            }

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cancel_result1 = 0;
         

            if (Appoint_id != 0)
            {
                cancel_result1 = controllerObj.Delete_appointment(Appoint_id);
                MessageBox.Show("Appointment is cancelled Successfully!");
            }


        }


        private void RegisterAnAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
             DataTable AvailableSlots = controllerObj.GetAvailableSlots();
            if (AvailableSlots != null)
            {

                comboBox1.DataSource = AvailableSlots;
                AvailableSlots.Columns.Add(
                "Register Time",
                 typeof(string), "Day +' '+Start_time");
                comboBox1.DisplayMember = "Register Time";



            }
            else
            {
                MessageBox.Show("Sorry,there are no available slots at this time.");
                MedicalSpecialities Available_Doctors = new MedicalSpecialities(P_Username);
                Available_Doctors.Show();
                this.Hide();
            }
            
               
            
        }

        private void SelectedTime_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTime.Text = comboBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MedicalSpecialities  Specialities = new MedicalSpecialities(P_Username);
            Specialities.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result;
            int parsedValue;
            if (int.TryParse(richTextBox2.Text, out parsedValue))
            {
                MessageBox.Show("Please, Don't enter a number!,enter your symptoms");
            }
            
            if (Symptoms != "")
            {
                string strValue = richTextBox2.Text;
                bool containsSearchResult = strValue.Contains(',');
                if (containsSearchResult)
                {
                    string[] strArray = strValue.Split(',');

                    foreach (object obj in strArray)
                    {
                        result = controllerObj.Insert_Patient_symptoms(Appoint_id,obj.ToString(), P_Username);
                    }
                    MessageBox.Show("Thank you! You can register now");
                    button2.Enabled = false;

                }
                else
                    MessageBox.Show("Please,enter the symptoms of your diseases separated with commas!");

            }
            else
                MessageBox.Show("Please,enter the symptoms of your diseases!");

        }


       
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedvalue = comboBox1.SelectedValue.ToString();
            SelectedTime.Text = comboBox1.Text;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
           
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void button10_Click_1(object sender, EventArgs e)
        {

           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            Symptoms = richTextBox2.Text;
        }
    }
}
