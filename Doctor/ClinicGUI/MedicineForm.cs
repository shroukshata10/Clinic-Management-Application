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
    public partial class MedicineForm : Form
    {
        Controller co = new Controller();
        string username;
        public MedicineForm()
        {
            InitializeComponent();
        }
        public void setUsername(string user)
        {
            username = user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Medicine = textBox1.Text;
            if (Medicine == "")
                MessageBox.Show("Please Enter data");
            try
            {
                int Fail = Int16.Parse(Medicine);
                MessageBox.Show("Invalid Arguments");
            }
            catch (Exception)
            {
               bool x= co.EnterNewMedicine(Medicine);
                if (x == true)
                    MessageBox.Show("Inserted successfully");
                else
                    MessageBox.Show("Insertion Failed");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorMainForm dm = new DoctorMainForm();
            dm.setUsername(username);

            dm.Show();
            this.Hide();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {

        }
    }
}
