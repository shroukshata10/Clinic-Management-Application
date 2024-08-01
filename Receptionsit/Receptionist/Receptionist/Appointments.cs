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
    public partial class Appointments : Form
    {
        Controller cont = new Controller();
        public static string doctor = "";
        public static int ID = 0;
        public Appointments(string doc, int id)
        {
            InitializeComponent();
            doctor = doc;
            ID = id;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
          

        }


        private void AppCbutton5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data");
            }
            else
            {

                int parsedvalue;
                if (!Int32.TryParse(textBox3.Text, out parsedvalue))
                {
                    MessageBox.Show("this is a number only field");
                    return;
                }

                int result = cont.Delete_Appointments(Int16.Parse(textBox3.Text));
                if (result == 0)
                {
                    MessageBox.Show("The Delete is failed");
                }
                else
                {
                    MessageBox.Show("The row is Deleted successfully!");
                    dataGridView1.Refresh();
                }
            }
        }


        private void Backbutton_Click(object sender, EventArgs e)
        {
            Main_Menu form = new Main_Menu(doctor,ID);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(cont.Drgetter()); //checker
            DataTable dt = cont.SelectAppointments(doctor);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Show();

        }

        private void AppSbutton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data");
            }
            else
            {
                string name = textBox1.Text;
                try
                {
                    int fail = Int16.Parse(name);
                    MessageBox.Show("first name is invalid");
                }
                catch (Exception)
                {
                }

                int parsedvalue;
                if (!Int32.TryParse(textBox2.Text, out parsedvalue))
                {
                    MessageBox.Show("this is a number only field");
                    return;
                }

                DataTable dt = cont.searchAppointments(Int32.Parse(textBox2.Text), textBox1.Text, doctor);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.Show();

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Slots form = new Slots(doctor, ID);
            form.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
    

