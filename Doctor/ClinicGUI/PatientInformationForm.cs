using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicGUI
{
    public partial class PatientInformationForm : Form
    {
        string patientUsername;
        string drUSername;
        int Appointment_Id;
        Controller co = new Controller();
        public PatientInformationForm()
        {
            InitializeComponent();
        }
        public void setPUsername(string u)
        {
            patientUsername = u;
        }
        public void setDUsername(string u)
        {
            drUSername = u;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EnterAppointmentInfo Uf = new EnterAppointmentInfo();
            Uf.setDUsername(drUSername);
            Uf.setPUsername(patientUsername);
            Uf.setAppointment_Id(Appointment_Id);
            Uf.Show();
            this.Hide();
        }

        private void PatientInformationForm_Load(object sender, EventArgs e)
        {
          
                DataTable patientinfo = co.GetSpecifiedPatient(drUSername, patientUsername);
                if (patientinfo != null)
                {


                    int numberOfRecords = patientinfo.Rows.Count;


                Appointment_Id = (patientinfo.Rows[0].Field<int>("Appointment_ID"));

                    textBox1.Text = (patientinfo.Rows[0].Field<string>("PName"));

                    textBox4.Text = (patientinfo.Rows[0].Field<string>("Phone_num"));
                     textBoxBD.Text = (patientinfo.Rows[0].Field<DateTime>("Birth_date")).Date.ToString();
                    textBoxG.Text = (patientinfo.Rows[0].Field<string>("Gender"));
                     textBox5.Text = (patientinfo.Rows[0].Field<DateTime>("Date_Time")).ToLongDateString()+" Day:"+ (patientinfo.Rows[0].Field<string>("Day")).ToString();
                     
                     textBoxT.Text = "Start Time:" + (patientinfo.Rows[0].Field<TimeSpan>("Start_time")).ToString() + "End Time:" + (patientinfo.Rows[0].Field<TimeSpan>("End_time")).ToString();
                    int Age = Int32.Parse((patientinfo.Rows[0].Field<int>("Age")).ToString());
                    textBox3.Text = Age.ToString();
                    for (int i = 0; i < numberOfRecords; i++)
                    {
                        richTextBox2.Text += patientinfo.Rows[i].Field<string>("Symptoms") + " , ";
                    }
                    int AppointmentId = Int32.Parse((patientinfo.Rows[0].Field<int>("Appointment_ID")).ToString());
                    DataTable medicine = co.GetAppointmentMedicine(AppointmentId);
                    int n = 0;
                    if (medicine != null)
                       
                    {
                         n = medicine.Rows.Count;

                        for (int i = 0; i < n; i++)
                        {
                            richTextBox4.Text += medicine.Rows[i].Field<string>("Medicine_Name") + " , ";
                        }
                    }
                    DataTable diagnosis = co.GetAppointmentDiagnosis(AppointmentId);
                    int d = 0;
                    if (diagnosis != null)
                    {
                         d = diagnosis.Rows.Count;
                        for (int i = 0; i < d; i++)
                        {
                            richTextBox3.Text += diagnosis.Rows[i].Field<string>("Diangnosis_Name") + " , ";
                        }
                    }
                    if (d != 0 && n != 0)
                    {
                        checkBox1.Checked = true;
                    }
                    DataTable comments = co.GetAppointmentComments(AppointmentId);
                    richTextBox1.Text = comments.Rows[0].Field<string>("Comments");


                }
          /*  }
            catch(Exception exc)
            {

            }*/

        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAssignedPatientsForm vf = new ViewAssignedPatientsForm();
            vf.setUsername(drUSername);
            vf.Show();
            
            this.Hide();
        }
    }
}
