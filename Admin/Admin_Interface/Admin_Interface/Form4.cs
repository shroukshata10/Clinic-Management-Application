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
    public partial class Form4 : Form
    {
        Controller controllerObj = new Controller();
        public Form4()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            //===============Checker For the user name
            bool HasErrros = false;
            if (!string.IsNullOrEmpty(User_textbox.Text))
            {
                errorProvider1.SetError(User_textbox, "");
            }

            if (User_textbox.Text.Length < 3)
            {
                errorProvider1.SetError(User_textbox, "The User Name MUST be AT LEAST 3 Characters");
                HasErrros = true;

            }
            if (User_textbox.Text == "")
            {
                errorProvider1.SetError(User_textbox, "This Field is Required");
                HasErrros = true;
            }
            //============Checker for the Password
            if (!string.IsNullOrEmpty(Pass_txtbox.Text))
            {
                errorProvider1.SetError(Pass_txtbox, "");

            }
            if (Pass_txtbox.Text.Length < 6)
            {
                errorProvider1.SetError(Pass_txtbox, "The User Name MUST be AT LEAST 6 Charachters");
                HasErrros = true;

            }
            if (Pass_txtbox.Text == "")
            {
                errorProvider1.SetError(Pass_txtbox, "This Field is Required");
                HasErrros = true;

            }
            if (HasErrros == false)
                {
                int result = controllerObj.AddAdmin(User_textbox.Text, Pass_txtbox.Text);
                MessageBox.Show("The User Name and Password is added Successfully");
            }
            }

        private void Pass_txtbox_TextChanged(object sender, EventArgs e)
        {
            Pass_txtbox.PasswordChar = '*';

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
