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
    public partial class MedicalSpecialities : Form
    {
        Controller ControllerObj;
        public string Patient="";
        public MedicalSpecialities(string PatientUsername)
        {
            InitializeComponent();
            ControllerObj = new Controller();
            Patient = PatientUsername;


        }

      
        private void button9_Click(object sender, EventArgs e)
        {

        }

     
        private void Form8_Load(object sender, EventArgs e)
        {

        }

      

        private void SelectedSpeciality_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSpeciality.Text = comboBox1.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if( Patient != "")
            {
                ProvidedFunctionalities Available_Doctors = new ProvidedFunctionalities(Patient);
                Available_Doctors.Show();
                this.Hide();

            }
           
        }

        private void MedicalSpecialities_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Selected.Text != "")
            {
                Doctor_sInfo Doctor_Info = new Doctor_sInfo(Selected.Text, Patient);

                Doctor_Info.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Please,Choose a doctor's account to see its information!");



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.Text = comboBox2.Text;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {

           if(SelectedSpeciality.Text != "")
            {
                DataTable AllDoctors = ControllerObj.GetDoctorsinSpecialization(SelectedSpeciality.Text);
                if (AllDoctors != null)
                {
                    comboBox2.DataSource = AllDoctors;
                    comboBox2.DisplayMember = "DUser_Name";
                }
                else
                    MessageBox.Show("There are no available Doctors in this speciality yet!");




           }
            else
               
                MessageBox.Show("Please,Choose a speciality!");

        }

        private void Selected_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (SelectedSpeciality.Text != "")
            {
                DataTable AllDoctors = ControllerObj.GetDoctorsinSpecialization(SelectedSpeciality.Text);
                if (AllDoctors != null)
                    dataGridView1.DataSource = AllDoctors;
                else
                    MessageBox.Show("There are no available Doctors in this speciality yet!");



            }
            else

                MessageBox.Show("Please,Choose a speciality!");
        }
    }
}

