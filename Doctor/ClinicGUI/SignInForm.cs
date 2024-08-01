using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewClinic;
using Receptionist;
using Admin_Interface;


namespace ClinicGUI
{
    public partial class SignInForm : Form
    {
        Controller controller = new Controller();
        public SignInForm()
        {
            InitializeComponent();
            InitializeMyControl();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username!="" && password != "")
            {

                char type = controller.checkUsernameandPass(username, password);
                if (type == 'D')
                {
                    DoctorMainForm Df = new DoctorMainForm();
                    Df.setUsername(username);
                    Df.Show();

                    this.Hide();
                }
                if (type == 'P')
                {
                    ProvidedFunctionalities pv = new ProvidedFunctionalities(username);
                    pv.Show();
                    this.Hide();
                }
                if (type == 'A')
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
             
                if (type == 'R')
                {
                    Doc_Available Df = new Doc_Available();
                    Df.Show();
                    this.Hide();
                }

                if (type == '0')
                {
                    MessageBox.Show("The user and password you entered does not match our records.try again");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            
        }
        private void InitializeMyControl()
        {

            // The password character is an asterisk.
            textBox2.UseSystemPasswordChar = true;
            // The control will allow no more than 14 characters.
            textBox2.MaxLength = 14;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text!="")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = System.Drawing.Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false ;

                }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUpForm su = new SignUpForm();
            su.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false ;

        }
    }
}
