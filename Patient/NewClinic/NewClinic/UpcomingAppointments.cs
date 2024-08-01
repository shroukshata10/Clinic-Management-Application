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
    public partial class UpcomingAppointments : Form
    {
        Controller controllerObj;
        public static string Patient = "";
        public static int Appoint_id = 0;
        public UpcomingAppointments(string PUsername)
        {
            InitializeComponent();
            Patient = PUsername;
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable upcoming_Appoint = controllerObj.Upcoming_appointment(Patient);
            if (upcoming_Appoint != null)
            {
                dataGridView1.DataSource = upcoming_Appoint;
           
            }
            else
                MessageBox.Show("No, Upcoming Appointments yet!");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ProvidedFunctionalities Provide = new ProvidedFunctionalities(Patient);
            Provide.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           

            if (textBox1.Text !=  "")
            {
                int parsedValue;
                if (int.TryParse(textBox1.Text, out parsedValue))
                {
                    Appoint_id = Int16.Parse(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Please, Enter the valid number not a string!");
                }
                if(Appoint_id != 0)
                {
                   int cancel_result1 = controllerObj.Delete_appointment(Appoint_id);
                    if (cancel_result1 > 0)
                    {
                        MessageBox.Show("Appointment is cancelled Successfully!");

                        dataGridView1.Refresh();
                        dataGridView1.Show();

                    }
                    else
                        MessageBox.Show("No,Appointment ID !");
                }
              
                else
                    MessageBox.Show("Please, Enter an existing Appointment ID !");
               
            }
           else
                MessageBox.Show("Please, enter the Appointment ID in the textbox to cancel");
        }

        private void UpcomingAppointments_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loaddata()
        {

        }
        private void UpcomingAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
