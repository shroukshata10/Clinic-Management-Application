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
    public partial class Form7 : Form
    {
        Controller controllerObj = new Controller();
        public Form7()
        {
            InitializeComponent();
            DataTable dt = controllerObj.selectID_Combobox();
            ClinicID_Combobox.DataSource = dt;
            ClinicID_Combobox.DisplayMember = "ID";
            ClinicID_Combobox.SelectedItem = null;

        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            /*& !int.TryParse(FName_txtbox.Text,out parsedValue)
                &(!int.TryParse(RLName_txtbox.Text, out parsedValue))
                & (RGender_Combobox.SelectedIndex>-1)
               &(!int.TryParse(RPhone_num_txtbox.Text, out parsedValue))
               & (int.TryParse(Salary_txtbox.Text, out parsedValue))*/
            // DateTime dt = DateTime.ParseExact(RBD_DataTimePicker, "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            int parsedValue;
            bool HasErrros = false;
            //============Checker For the Clinic ID

            //============Checker For the Clinic ID

            if (string.IsNullOrEmpty(ClinicID_Combobox.Text))
            {
                errorProvider1.SetError(ClinicID_Combobox, "This Field is Required");
                HasErrros = true;

            }
            else
            {
                errorProvider1.SetError(ClinicID_Combobox, "");


            }
            if (ClinicID_Combobox.Text == "")
            {
                errorProvider1.SetError(ClinicID_Combobox, "This Field is Required");
                HasErrros = true;

            }


            //===========Checker for the First Name
            if (!string.IsNullOrEmpty(RFName_TxtBox.Text))
            {
                errorProvider1.SetError(RFName_TxtBox, "");
            }

            if (int.TryParse(RFName_TxtBox.Text, out parsedValue))
            {
                errorProvider1.SetError(RFName_TxtBox, "Please Enter Characters ONLY");
                HasErrros = true;
            }
            if (RFName_TxtBox.Text.Length < 3)
            {
                errorProvider1.SetError(RFName_TxtBox, "The First Name MUST be AT LEAST 3 Charachters");
                HasErrros = true;
            }
            if (RFName_TxtBox.Text == "")
            {
                errorProvider1.SetError(RFName_TxtBox, "This Field is Required");
                HasErrros = true;
            }
         

            
            //===============Checker For the user name

            if (!string.IsNullOrEmpty(RUserName_txtbox.Text))
            {
                errorProvider1.SetError(RUserName_txtbox, "");
            }
            
            if (RUserName_txtbox.Text.Length < 3)
            {
                errorProvider1.SetError(RUserName_txtbox, "The User Name MUST be AT LEAST 3 Characters");
                HasErrros = true;
            }

            if (HasErrros == false)
            {
                //========Checker for the user name
                int Result = controllerObj.Check_Rec_UserName(RUserName_txtbox.Text, Int32.Parse(ClinicID_Combobox.Text));

                if (Result == 0)

                {
                    errorProvider1.SetError(RUserName_txtbox, "");

                }
                else
                {
                    errorProvider1.SetError(RUserName_txtbox, "The User Name is Already Created");
                    HasErrros = true;


                }
            }
            if (RUserName_txtbox.Text == "")
            {
                errorProvider1.SetError(RUserName_txtbox, "This Field is Required");
                HasErrros = true;
            }
            //============Checker for the Password
            if (!string.IsNullOrEmpty(RPass_txtbox.Text))
            {
                errorProvider1.SetError(RPass_txtbox, "");

            }
            if (RPass_txtbox.Text.Length < 6)
            {
                errorProvider1.SetError(RPass_txtbox, "The User Name MUST be AT LEAST 6 Charachters");
                HasErrros = true;

            }
            if (RPass_txtbox.Text == "")
            {
                errorProvider1.SetError(RPass_txtbox, "This Field is Required");
                HasErrros = true;

            }
            //===============Checker For the Phone number
            if (!string.IsNullOrEmpty(ReceptionistPhone_Masked.Text))
            {
                errorProvider1.SetError(ReceptionistPhone_Masked, "");

            }
            if (ReceptionistPhone_Masked.Text.Length < 10)
            {
                errorProvider1.SetError(ReceptionistPhone_Masked, "Phone Number MUST be 10 Characters");
                HasErrros = true;


            }
            if (ReceptionistPhone_Masked.Text == "")
            {

                errorProvider1.SetError(ReceptionistPhone_Masked, "This Field is Required");
                HasErrros = true;

            }



            //===============Checker for the gender
            if (string.IsNullOrEmpty(RGender_Combobox.Text))
            {
                errorProvider1.SetError(RGender_Combobox, "This Field is Required");
                HasErrros = true;

            }
            else
            {
                errorProvider1.SetError(RGender_Combobox, "");


            }
            if (RGender_Combobox.Text == "")
            {
                errorProvider1.SetError(RGender_Combobox, "This Field is Required");
                HasErrros = true;

            }


            //=======Checker for the Birth Date
            if (!string.IsNullOrEmpty(RBD_DataTimePicker.Text))
            {
                errorProvider1.SetError(RBD_DataTimePicker, "");

            }
            if (RBD_DataTimePicker.Text == "")
            {
                errorProvider1.SetError(RBD_DataTimePicker, "This Field is Required");
                HasErrros = true;

            }
          
           
            //===========Checker for the Salary
            if (!string.IsNullOrEmpty(Salary_txtbox.Text))
            {
                errorProvider1.SetError(Salary_txtbox, "");
            }

            int Accepted_Fees = 0;
            Int32.TryParse(Salary_txtbox.Text, out Accepted_Fees);
            if (Accepted_Fees < 0)
            {
                errorProvider1.SetError(Salary_txtbox, "Negative Numbers are NOT Allowed!!, Please Enter POSITIVE Numbers");
                HasErrros = true;

            }

            if (!int.TryParse(Salary_txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(Salary_txtbox, "Please Enter Numbers ONLY");
                HasErrros = true;

            }
            if (Salary_txtbox.Text.Length < 4)
            {
                errorProvider1.SetError(Salary_txtbox, "Salary MUST BE AT LEASE 4 Numbers");
                HasErrros = true;

            }
            if ((Salary_txtbox.Text == ""))
            {

                errorProvider1.SetError(Salary_txtbox, "This Field is Required");
                HasErrros = true;
            }

            if (HasErrros == false)
            { 
                int result = controllerObj.insert_receptionist(Int32.Parse(ClinicID_Combobox.Text), RFName_TxtBox.Text,  RUserName_txtbox.Text, RPass_txtbox.Text,
                    DateTime.Parse(RBD_DataTimePicker.Text).ToString(), RGender_Combobox.Text, ReceptionistPhone_Masked.Text, Int32.Parse(Salary_txtbox.Text));
                if (result == 0)

                {
                    MessageBox.Show("Please Enter Valid Data");

                }
                else

                {

                    MessageBox.Show("The Account is created successfully");
                    ClinicID_Combobox.SelectedItem = null;
                    RFName_TxtBox.Text = "";
                    RUserName_txtbox.Text = "";
                    RPass_txtbox.Text = "";
                    ReceptionistPhone_Masked.Text = "";
                    RGender_Combobox.Text = "   ";
                    RBD_DataTimePicker.Text = "";
                    Salary_txtbox.Text = "";
                }

            }
        }
        
        

    
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            /*  int parsedValue;
              if (!int.TryParse(FName_txtbox.Text, out parsedValue)
                  & (!int.TryParse(Lname_txtbox.Text, out parsedValue))
                  & (Gender_combobox.SelectedIndex > -1)
                  & (int.TryParse(Phone_num_txtbox.Text, out parsedValue))
                 & (int.TryParse(Salary_txtbox.Text, out parsedValue))
                 & int.TryParse(BD_txtbox.Text, out parsedValue))
              {
                  MessageBox.Show("The Account is Edited successfully");
              }
              else
              {
                  MessageBox.Show("Please Enter Valid Data");
              }*/
        }

        private void UserName_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBD_DataTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void RPass_txtbox_TextChanged(object sender, EventArgs e)
        {
            RPass_txtbox.PasswordChar = '*';

        }

        private void ReceptionistPhone_Masked_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }

        private void ClinicID_txtbox_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
