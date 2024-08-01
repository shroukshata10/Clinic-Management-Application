using System;
using System.Data;
using System.Windows.Forms;

namespace NewClinic
{
    public partial class PastAppointments : Form
    {
        Controller controllerObj;
        public string Patient = "";
        public PastAppointments(string PUsername)
        {
            InitializeComponent();
            Patient = PUsername;
            controllerObj = new Controller();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProvidedFunctionalities functionalities = new ProvidedFunctionalities(Patient);
            functionalities.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable Past_Appoint = controllerObj.GetPastAppointments(Patient);
            

            if (Past_Appoint != null)
            {
                dataGridView1.DataSource = Past_Appoint;
                

            }
            else
                MessageBox.Show("No,Past Appointments yet!");


        }
 

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void PastAppointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
