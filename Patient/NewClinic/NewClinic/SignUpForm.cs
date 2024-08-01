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
   

    public partial class SignUpForm : Form
    {
        Controller controllerObj;
        public static string username { get; set; }
        public SignUpForm()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            try
            {
                int Fail = Int16.Parse(name);
                MessageBox.Show("Name is invalid,Please,Don't enter a number!");
            }
            catch (Exception)
            {
            }

          if(Pusername.Text == " ")
            {
                MessageBox.Show("Please, Enter a Username!");
            }
            int parsedValue;
            if (!int.TryParse(Pusername.Text, out parsedValue))
            {
                username = Pusername.Text;
            }
            else
            {
                MessageBox.Show("Username is invalid,Please, Don't Enter a number!");
            }
            string age = textBox3.Text;
            if (age != "")
            {
                try
                {
                    int sucsess = Int16.Parse(age);
                    if (sucsess < 0 || sucsess > 100)
                    {
                        MessageBox.Show("Invalid Age");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Age");
                }
            }
          
                
            if (textBox1.Text == "" || Pusername.Text == "" || textBox3.Text == "" || maskedTextBox1.Text == "" || textBox4.Text == ""  || string.IsNullOrEmpty(comboBox1.Text))//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int s = controllerObj.Add_P_Account(Pusername.Text, 3, textBox5.Text, 1);
                int r = controllerObj.InsertPatient(textBox1.Text, maskedTextBox1.Text, textBox4.Text, Pusername.Text, Convert.ToInt32(textBox3.Text), dateTimePicker1.Value, comboBox1.Text);
               
                if ( s > 0 && r > 0)
                {
                    MessageBox.Show("You have signed up successfully!");
                    ProvidedFunctionalities Functionalities = new ProvidedFunctionalities(username);
                    Functionalities.Show();
                    this.Hide();
                }
                    
                else
                    MessageBox.Show("Sign up Failed,try again!");
            }

           

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
           
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeMyControl()
        {

            ;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            textBox5.UseSystemPasswordChar = true;
            // The control will allow no more than 14 characters.
            textBox5.MaxLength = 14;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (textBox5.UseSystemPasswordChar == false)
                textBox5.UseSystemPasswordChar = true;
            else
                textBox5.UseSystemPasswordChar = false;


        }

       
    }
}

