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
    public partial class Slots : Form
    {
        Controller cont = new Controller();
            
        public static string doctor = "";
        public static int ID = 0;
        public static int Id_App = 0;
        public static string Day = "";
        public Slots(string doc, int id)
        {
            InitializeComponent();
            doctor=doc;
            ID = id;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
          //  string x = ;
           // MessageBox.Show(cont.Drgetter());

           // MessageBox.Show("gfghhgf");
            if (textBox1.Text == "" || dateTimePicker1.Value.ToString() == "" || StarttextBox3.Text == "" || EndtextBox2.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data");
            }
            else
            {
                //string date = DatetextBox1.Text;
                //try
                //{
                //    int Fail = Int16.Parse(date);
                //    MessageBox.Show(" invalid Data");
                //}
                //catch (Exception)
                //{
                //}

                int parsedValue;
                if (!Int32.TryParse(textBox1.Text, out parsedValue))
                {
                    MessageBox.Show("This is a number only field");
                    return;
                }

                string start = StarttextBox3.Text;
                try
                {
                    int Fail = Int16.Parse(start);
                    MessageBox.Show("invalid Data");
                }
                catch (Exception)
                {
                }

                string End = EndtextBox2.Text;
                try
                {
                    int Fail = Int16.Parse(End);
                    MessageBox.Show("invalid Data");
                }
                catch (Exception)
                {
                }
            }
            // string name = "mariam.tawfik@clinic.com";
            // int fg = 112;

            DateTime DT = dateTimePicker1.Value;
            string Date = DT.Date.ToShortDateString();
            try
            {
                int result = cont.ADDSlot(doctor, Int32.Parse(textBox1.Text),Date, DateTime.Parse(StarttextBox3.Text).ToString(), DateTime.Parse(EndtextBox2.Text).ToString(), ID);
                if (result == 0)
                {
                    MessageBox.Show("The insertion is failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                    dataGridView1.Refresh();
                }
            }
            catch(Exception exc)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = cont.ShowSlots(doctor);
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

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                Id_App = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Day = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                //MessageBox.Show(Id_App.ToString());
            }
            catch(Exception exc) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {   // MessageBox.Show("gfghhgf");
            if (textBox2.Text == "")
                MessageBox.Show("Please Enter Valid Data");

            else
            {
                string name = textBox2.Text;
                try
                {
                    int Fail = Int16.Parse(name);
                    MessageBox.Show("invalid Data");
                }
                catch (Exception)
                {
                }
            }

            try
            {
                int result = cont.Register(doctor, Id_App, Day, textBox2.Text, ID);
                if (result == 0)
                {
                    MessageBox.Show("The Registeration is failed");
                }
                else
                {
                    MessageBox.Show("The Registeration is successeded!");
                    dataGridView1.Refresh();
                }
            }
            catch (Exception exc)
            { }
        }

    }
    
}
