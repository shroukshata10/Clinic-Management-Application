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
    public partial class EnterAppointmentInfo : Form
    {
        string patientUsername;
        string drUSername;
        int Appointment_id;
        Controller co = new Controller();
        public EnterAppointmentInfo()
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

        public void setAppointment_Id(int appointment_id)
        {
            Appointment_id = appointment_id;
        }
        private void EnterAppointmentInfo_Load(object sender, EventArgs e)
        {
            
                DataTable patientinfo = co.GetSpecifiedPatient(drUSername, patientUsername);

                if (patientinfo != null)
                {


                    int numberOfRecords = patientinfo.Rows.Count;

                    textBox1.Text = (patientinfo.Rows[0].Field<string>("PName"));

                    textBox4.Text = (patientinfo.Rows[0].Field<string>("Phone_num"));
                     textBoxBD.Text = (patientinfo.Rows[0].Field<DateTime>("Birth_date")).ToString();
                    textBoxG.Text = (patientinfo.Rows[0].Field<string>("Gender"));
                     textBox5.Text = (patientinfo.Rows[0].Field<DateTime>("Date_Time")).ToLongDateString()+" Day:"+ (patientinfo.Rows[0].Field<string>("Day")).ToString();
                    textBoxT.Text = "Start Time:" + (patientinfo.Rows[0].Field<TimeSpan>("Start_time")).ToString() + "End Time:" + (patientinfo.Rows[0].Field<TimeSpan>("End_time")).ToString();
                    int Age = Int32.Parse((patientinfo.Rows[0].Field<int>("Age")).ToString());
                    textBox3.Text = Age.ToString();
                    for (int i = 0; i < numberOfRecords; i++)
                    {
                        richTextBox2.Text += patientinfo.Rows[i].Field<string>("Symptoms") + " , ";
                    }
                    int size = 0;
                    int dsize = 0;
                    DataTable m = co.GetAllMedicines();
                    DataTable d = co.GetAllDiagnosis();
                    if(m!=null)
                     size = m.Rows.Count;
                    if(d!=null)
                     dsize = d.Rows.Count;
                    for (int i = 0; i < dsize; i++)
                    {
                        checkedListBox1.Items.Add(d.Rows[i].Field<string>("Scientific_Name"));
                    }
                    for (int i = 0; i < size; i++)
                    {
                        checkedListBox2.Items.Add(m.Rows[i].Field<string>("Mname"));
                    }



                }
            


           
            }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        string st = checkedListBox1.CheckedItems[i].ToString();
                        bool x = co.SetPatientDiagnosis(Appointment_id, checkedListBox1.CheckedItems[i].ToString());
                        if(x==true)
                            MessageBox.Show("Diagnosis insertd successfully");
                        if (x == false)
                            MessageBox.Show("Sorry, Diagnosis not insertd");

                    }
                }
                if (checkedListBox2.CheckedItems.Count != 0)
                {
                    for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                    {
                        bool x = co.SetPatientMedicine(Appointment_id, checkedListBox2.CheckedItems[i].ToString());
                        if(x==true)
                            MessageBox.Show("Medicine insertd successfully");
                        if (x == false)
                            MessageBox.Show("Sorry, Medicine not insertd");

                    }
                }
                if (richTextBox1.Text != "")
                {
                    bool x = co.EnterComment(Appointment_id, richTextBox1.Text);
                    if (x = false)
                        MessageBox.Show("Comments not iserted");
                }
                MessageBox.Show("Done");
            }
            catch(Exception exc)
            {
                MessageBox.Show("Sorry, Not inserted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAssignedPatientsForm vform = new ViewAssignedPatientsForm();
            vform.setUsername(drUSername);
            vform.Show();
            this.Hide();
        }
    }

        
 }

