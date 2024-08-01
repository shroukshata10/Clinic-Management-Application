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
    public partial class DoctorMainForm : Form
    {
        string username;
        public void setUsername (string user)
        {
            username = user;
        }
        public DoctorMainForm()
        {
            InitializeComponent();
        }

        private void DoctorMainForm_Load(object sender, EventArgs e)
        {

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            DoctorPerInfoForm DperInfo = new DoctorPerInfoForm();
            DperInfo.setUsername(username);
         
            DperInfo.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DiagnosisForm Df = new DiagnosisForm();
            Df.setUsername(username);
            Df.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicineForm Mform = new MedicineForm();
            Mform.setUsername(username);
            Mform.Show();
            this.Hide();

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAssignedPatientsForm Vform = new ViewAssignedPatientsForm();
            Vform.setUsername(username);
            Vform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SignInForm f1 = new SignInForm();
            f1.Show();
            this.Hide();
        }
    }
}
