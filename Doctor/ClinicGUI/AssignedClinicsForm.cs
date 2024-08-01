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
    public partial class AssignedClinicsForm : Form
    {
        string username;
        Controller controller = new Controller();

        public AssignedClinicsForm()
        {
            InitializeComponent();
        }
        public void setUserName(string user)
        {
            username = user;
        }
        public void SetDataGrid(string username)
        {
            DataTable Dt=controller.SelectAssignedClinics(username);
            dataGridView1.DataSource = Dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoctorPerInfoForm Df = new DoctorPerInfoForm();
            Df.setUsername(username);
            Df.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

        private void AssignedClinicsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
