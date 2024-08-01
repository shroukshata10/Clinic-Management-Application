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
    public partial class ProvidedFunctionalities : Form
    {
        public string Patient;
        Controller controllerObj;
        public ProvidedFunctionalities(string PUsername)
        {
            InitializeComponent();
            Patient = PUsername;
            controllerObj = new Controller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          MedicalSpecialities available_Specialities = new MedicalSpecialities(Patient);
            available_Specialities.Show();
            this.Hide();

        }

      

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProvidedFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PastAppointments view_Past_appointmnents = new PastAppointments(Patient);
            view_Past_appointmnents.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpcomingAppointments upcoming = new UpcomingAppointments(Patient);
            upcoming.Show();
            this.Hide();
        }
    }
}
