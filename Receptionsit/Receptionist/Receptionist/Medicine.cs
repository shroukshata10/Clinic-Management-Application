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
    public partial class Medicine : Form
    {
        Controller cont = new Controller();
        public static string doctor = "";
        public static int ID = 0;
        public Medicine(string doc, int id)
        {
            InitializeComponent();
            doctor = doc;
            ID = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            if (MNtextBox1.Text == "" || PricetextBox3.Text == "" || CodetextBox2.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data");
            }
            else
            {
                string name = MNtextBox1.Text;
                try
                {
                    int Fail = Int16.Parse(name);
                    MessageBox.Show("First name is invalid");
                }
                catch (Exception)
                {
                }

                int parsedValue;
                if (!Int32.TryParse(CodetextBox2.Text, out parsedValue))
                {
                    MessageBox.Show("This is a number only field");
                    return;
                }

                try
                {
                    double Value;
                if (!double.TryParse(PricetextBox3.Text, out Value))
                {
                    MessageBox.Show("This is a number only field");
                    return;
                }


                int result = cont.ADD_Medicine(MNtextBox1.Text, Int32.Parse(CodetextBox2.Text), Int32.Parse(PricetextBox3.Text));
                if (result == 0)
                {
                    MessageBox.Show("The insertion failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                    dataGridView1.Refresh();
                }
            }
                catch (Exception)
            {
                    MessageBox.Show("The insertion failed");
                }

        }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = cont.ShowMedicine();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Show();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Main_Menu form = new Main_Menu(doctor,ID);
            form.Show();
            this.Hide();
        }
    }
}
