using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Interface
{
    public partial class Form3 : Form
    {
        Controller controllerObj = new Controller();
        public Form3()
        {
            InitializeComponent();
        }

        private void Clinic1_btn_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Clinic2_btn_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Clinic3_btn_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void selectClinic_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectAllClinics_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Select_Clinic();
            selectClinic_dataGrid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
