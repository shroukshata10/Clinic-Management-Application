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
    public partial class UpdateInfoForm : Form
    {
        string username;
        Controller co = new Controller();
        public UpdateInfoForm()
        {
            InitializeComponent();
        }
        public void setUsername(string user)
        {
            username = user;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please fill all data");
                return;
            }
            else
            {

                string Name = textBox1.Text;
                string address = textBox2.Text;
                string phone = textBox3.Text;
                string fees = textBox6.Text;
                int fee = Convert.ToInt32(fees);
                string pass = textBox7.Text;
                bool x = co.UpdateDoctorInfo(Name, address, phone, fee, pass, username);
                if (x == true)
                    MessageBox.Show("Done");
                else
                    MessageBox.Show("Failed");


            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateInfoForm_Load(object sender, EventArgs e)
        {

        }
        public void SetMyInfo(string Name,string add,string phone,string fees,string password)
        {
            textBox1.Text = Name;
            textBox2.Text = add;
            textBox3.Text = phone;
            textBox6.Text = fees;
            textBox7.Text = password;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorPerInfoForm df = new DoctorPerInfoForm();
            df.setUsername(username);
            df.Show();
            this.Hide();
        }
    }
}
