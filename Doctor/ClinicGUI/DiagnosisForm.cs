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
    public partial class DiagnosisForm : Form
    {
        Controller c = new Controller();
        string username;
        public DiagnosisForm()
        {
            InitializeComponent();
        }
        public void setUsername(string user)
        {
            username = user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string diagnosis = textBox1.Text;
            if (diagnosis == "")
            {
                MessageBox.Show("Please Enter diagnosis");
                return;
            }
            try
            {
                int Fail = Int16.Parse(diagnosis);
                MessageBox.Show("Invalid Arguments");
            }
            catch(Exception )
            {
                bool check = c.EnterDiagnosis(diagnosis);
                if (check==true)
                    MessageBox.Show("Done");
                else
                    MessageBox.Show("Fail");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorMainForm Dm = new DoctorMainForm();
            Dm.setUsername(username);
            Dm.Show();
            this.Hide();
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
