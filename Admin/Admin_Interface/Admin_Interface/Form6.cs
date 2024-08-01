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
    public partial class Form6 : Form
    {
        Controller controllerObj;
        public Form6()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.selectID_Combobox();
            Clinic_ID_Combobox.DataSource = dt;
            Clinic_ID_Combobox.DisplayMember = "ID";
            Clinic_ID_Combobox.SelectedItem = null;

        }


        private void Create_btn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            bool HasErrros = false;
            //============Checker For the Clinic ID

             if (string.IsNullOrEmpty(Clinic_ID_Combobox.Text))
            {
                errorProvider1.SetError(Clinic_ID_Combobox, "This Field is Required");
                HasErrros = true;

            }
            else
            {
                errorProvider1.SetError(Clinic_ID_Combobox, "");


            }
            if (Clinic_ID_Combobox.Text == "")
            {
                errorProvider1.SetError(Clinic_ID_Combobox, "This Field is Required");
                HasErrros = true;

            }

            //===========Checker for the First Name
            if (!string.IsNullOrEmpty(FName_Txtbox.Text))
            {
                errorProvider1.SetError(FName_Txtbox, "");
            }

            if (int.TryParse(FName_Txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(FName_Txtbox, "Please Enter Characters ONLY");
                HasErrros = true;
            }
            if (FName_Txtbox.Text.Length < 3)
            {
                errorProvider1.SetError(FName_Txtbox, "The First Name MUST be AT LEAST 3 Charachters");
                HasErrros = true;
            }
            if (FName_Txtbox.Text == "")
            {
                errorProvider1.SetError(FName_Txtbox, "This Field is Required");
                HasErrros = true;
            }
         
            //===============Checker For the user name

            if (!string.IsNullOrEmpty(UserName_txtbox.Text))
            {
                errorProvider1.SetError(UserName_txtbox, "");
            }
            
            if (UserName_txtbox.Text.Length < 3)
            {
                errorProvider1.SetError(UserName_txtbox, "The User Name MUST be AT LEAST 3 Characters");
                HasErrros = true;

            }

            if (HasErrros == false)
            {
                //========Checker for the user name
                int Result = controllerObj.checkDUserName(UserName_txtbox.Text, Int32.Parse(Clinic_ID_Combobox.Text));

                if (Result == 0)

                {
                    errorProvider1.SetError(UserName_txtbox, "");

                }
                else
                {
                    errorProvider1.SetError(UserName_txtbox, "The User Name is Already Created");
                    HasErrros = true;


                }
            }
            if (UserName_txtbox.Text == "")
            {
                errorProvider1.SetError(UserName_txtbox, "This Field is Required");
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
            //===============Checker For the Phone number
            if (!string.IsNullOrEmpty(PhoneNumber_Mask.Text))
            {
                errorProvider1.SetError(PhoneNumber_Mask, "");

            }
            if (PhoneNumber_Mask.Text.Length < 10)
            {
                errorProvider1.SetError(PhoneNumber_Mask, "Phone Number MUST be 10 Characters");
                HasErrros = true;


            }
            if (PhoneNumber_Mask.Text == "")
            {

                errorProvider1.SetError(PhoneNumber_Mask, "This Field is Required");
                HasErrros = true;

            }



            //===============Checker for the gender
            if (string.IsNullOrEmpty(Gender_Combobox.Text))
            {
                errorProvider1.SetError(Gender_Combobox, "This Field is Required");
                HasErrros = true;

            }
            else
            {
                errorProvider1.SetError(Gender_Combobox, "");


            }
            if (Gender_Combobox.Text == "")
            {
                errorProvider1.SetError(Gender_Combobox, "This Field is Required");
                HasErrros = true;

            }
            //===========Checker for the fees
            if (!string.IsNullOrEmpty(Fees_txtbox.Text))
            {
                errorProvider1.SetError(Fees_txtbox, "");
            }

            int Accepted_Fees = 0;
            Int32.TryParse(Fees_txtbox.Text, out Accepted_Fees);
            if (Accepted_Fees < 0)
            {
                errorProvider1.SetError(Fees_txtbox, "Negative Numbers are NOT Allowed!!, Please Enter POSITIVE Numbers");
                HasErrros = true;

            }

            if (!int.TryParse(Fees_txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(Fees_txtbox, "Please Enter Numbers ONLY");
                HasErrros = true;

            }
            if (Fees_txtbox.Text.Length < 2)
            {
                errorProvider1.SetError(Fees_txtbox, "Salary MUST BE AT LEASE 2 Numbers");
                HasErrros = true;

            }
            if ((Fees_txtbox.Text == ""))
            {

                errorProvider1.SetError(Fees_txtbox, "This Field is Required");
                HasErrros = true;

            }
            //==============Checker for the specialization

            if (!string.IsNullOrEmpty(Specialization_txtbox.Text))
            {
                errorProvider1.SetError(Specialization_txtbox, "");

            }
            if (Specialization_txtbox.Text == "")
            {
                errorProvider1.SetError(Specialization_txtbox, "This Field is Required");
                HasErrros = true;

            }
            //==============Chekcer for the address

            if (Address_txtbox.Text == "")
            {
                errorProvider1.SetError(Address_txtbox, "This Field is Required");
                HasErrros = true;

            }
            if (!string.IsNullOrEmpty(Address_txtbox.Text))
            {
                errorProvider1.SetError(Address_txtbox, "");

            }
        
            if (Address_txtbox.Text == "")
            {
                errorProvider1.SetError(Address_txtbox, "This Field is Required");
                HasErrros = true;

            }
            //=======Checker for the Birth Date
            if (BD_DatetimePicker.Text == "")
            {
                errorProvider1.SetError(BD_DatetimePicker, "This Field is Required");
                HasErrros = true;

            }
            if (!string.IsNullOrEmpty(BD_DatetimePicker.Text))
            {
                errorProvider1.SetError(BD_DatetimePicker, "");

            }
            //===============Checker for the Scientific Certificate
            if (string.IsNullOrEmpty(Sci_Certi_combobox.Text))
            {
                errorProvider1.SetError(Sci_Certi_combobox, "This Field is Required");
                HasErrros = true;

            }
            else
            {
                errorProvider1.SetError(Sci_Certi_combobox, "");


            }
            if (Sci_Certi_combobox.Text == "")
            {
                errorProvider1.SetError(Sci_Certi_combobox, "This Field is Required");
                HasErrros = true;

            }


            if (HasErrros == false)
            {
                int result = controllerObj.insert_Doctor(Int32.Parse(Clinic_ID_Combobox.Text), FName_Txtbox.Text,
                  UserName_txtbox.Text, Pass_txtbox.Text, DateTime.Parse(BD_DatetimePicker.Text).ToString(), Gender_Combobox.Text, PhoneNumber_Mask.Text,
                 Specialization_txtbox.Text, Address_txtbox.Text, Int32.Parse(Fees_txtbox.Text), Sci_Certi_combobox.Text);
                
                    if (result == 0)
                    {
                    MessageBox.Show("Please Enter Valid Data");

                    }
                else
                    {
                    MessageBox.Show("The Account is Created Successfully");
                    Clinic_ID_Combobox.SelectedItem = null;
                    FName_Txtbox.Text = "";
                    UserName_txtbox.Text = "";
                    Pass_txtbox.Text = "";
                    PhoneNumber_Mask.Text = "";
                    Gender_Combobox.Text = "    ";
                    Address_txtbox.Text = "";
                    Fees_txtbox.Text = "";
                    Specialization_txtbox.Text = "";
                    Sci_Certi_combobox.Text = "    ";
                    BD_DatetimePicker.Text = "";


                }
                }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Clinic_and_time_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if ((!int.TryParse(FName_Txtbox.Text, out parsedValue))
            
               & (int.TryParse(PhoneNumber_Mask.Text, out parsedValue))
               & ((int.TryParse(Fees_txtbox.Text, out parsedValue))
               & (!int.TryParse(Specialization_txtbox.Text, out parsedValue))
               & (Sci_Certi_combobox.SelectedIndex > -1)
               & (Gender_Combobox.SelectedIndex > -1)))

            {
                MessageBox.Show("The Account is Edited Successfully");
            }
            else
            {
                MessageBox.Show("Please Enter Valid Data");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FName_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void First_Name_label_Click(object sender, EventArgs e)
        {

        }

        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void Birthday_label_Click(object sender, EventArgs e)
        {

        }

        private void ClinicID_label_Click(object sender, EventArgs e)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, ClinicID_label.Width, ClinicID_label.Height);

            this.ClinicID_label.Region = new Region(path);


        }

        private void UserName_label_Click(object sender, EventArgs e)
        {

        }

        private void Gender_label_Click(object sender, EventArgs e)
        {

        }

        private void Phone_number_label_Click(object sender, EventArgs e)
        {

        }

        private void Specialization_label_Click(object sender, EventArgs e)
        {

        }

        private void Address_label_Click(object sender, EventArgs e)
        {

        }

        private void Scientific_Certificate_label_Click(object sender, EventArgs e)
        {

        }

        private void Fees_label_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void UserName_txtbox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Pass_txtbox_TextChanged(object sender, EventArgs e)
        {
            Pass_txtbox.PasswordChar = '*';

        }

        private void ClinicID_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FName_Txtbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Clinic_ID_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
