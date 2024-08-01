using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receptionist
{
    public partial class Main_Menu : Form
    {
        public static string doctor = "";
        public static int ID = 0;
        public Main_Menu(string doc, int id)
        {
            InitializeComponent();
            doctor = doc;
            ID = id;
            //VDIbutton4.Enabled = false;

        }

        private void Appbutton1_Click(object sender, EventArgs e)
        {
            Appointments form = new Appointments(doctor,ID);
            form.Show();
            this.Hide();
        }

        private void AppCbutton5_Click(object sender, EventArgs e)
        {
         
        }

        private void FSbutton3_Click(object sender, EventArgs e)
        {
            Slots form = new Slots(doctor,ID);
            form.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medicine form = new Medicine(doctor,ID);
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doc_Available form = new Doc_Available();
            form.Show();
            this.Hide();
        }

        private void VDIbutton4_Click(object sender, EventArgs e)
        {
            
            Doc_Info form = new Doc_Info(doctor,ID);
            form.Show();
            this.Hide();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
