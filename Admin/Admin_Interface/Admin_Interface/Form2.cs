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
    public partial class Form2 : Form
    {
        Controller controllerObj;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("hnaa");
            controllerObj = new Controller();
        }



        private void Add_btn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int parsedValue = 0;

            //Checker for the ID
            if (!string.IsNullOrEmpty(ID_txtbox.Text))
            {

                errorProvider1.SetError(ID_txtbox, "");

            }
           
            int Accepted_ID = 0;
            Int32.TryParse(ID_txtbox.Text, out Accepted_ID);
            if (Accepted_ID < 0)
            {
                errorProvider1.SetError(ID_txtbox, "Negative Numbers are NOT Allowed!!, Please Enter POSITIVE Numbers");
                flag = true;

            }

            if (!int.TryParse(ID_txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(ID_txtbox, "Please Enter Numbers ONLY");
                flag = true;

            }
           

            if (ID_txtbox.Text.Length < 5)
            {
                errorProvider1.SetError(ID_txtbox, "Clinic ID MUST BE AT LEASE 5 Numbers");
                flag = true;

            }
            if (flag == false)
            {

                int rst = controllerObj.checkClinic(Int32.Parse(ID_txtbox.Text));
                if (rst == 0)
                {

                    errorProvider1.SetError(ID_txtbox, "");

                }
                else
                {
                    errorProvider1.SetError(ID_txtbox, "This Clinic is Already Created");
                    flag = true;

                }
            }

            if ((ID_txtbox.Text == ""))
            {

                errorProvider1.SetError(ID_txtbox, "This Field is Required");
                flag = true;

            }
        
          

            //==============Checker for Phone Number

            if (!string.IsNullOrEmpty(ClinicPhone_Masked.Text))
            {

                errorProvider1.SetError(ClinicPhone_Masked, "");
            }
            int AcceptedPhoneNumber = 0;
            Int32.TryParse(ClinicPhone_Masked.Text, out AcceptedPhoneNumber);
            if (AcceptedPhoneNumber < 0)
            {
                errorProvider1.SetError(ID_txtbox, "Negative Numbers are NOT Allowed!!, Please Enter POSITIVE Numbers");
                flag = true;

            }
            if (int.TryParse(ClinicPhone_Masked.Text, out parsedValue))
            {
                errorProvider1.SetError(ClinicPhone_Masked, "Please Enter Numbers ONLY");
                flag = true;

            }

            if (ClinicPhone_Masked.Text.Length < 10)
            {
                errorProvider1.SetError(ClinicPhone_Masked, "Phone Number MUST be 10 Characters");
                flag = true;


            }
            if (ClinicPhone_Masked.Text == "")
            {

                errorProvider1.SetError(ClinicPhone_Masked, "This Field is Required");
                flag = true;


            }
            //=============Checker For Clinic Name


            if (!string.IsNullOrEmpty(ClinicName_txtbox.Text))
            {

                errorProvider1.SetError(ClinicName_txtbox, "");

            }
            if (ClinicName_txtbox.Text.Length < 5)
            {
                errorProvider1.SetError(ClinicName_txtbox, "Clinic Name MUST be AT LEAST 5 Characters");
                flag = true;


            }
            if (int.TryParse(ClinicName_txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(ClinicName_txtbox, "Please Enter Letters Only");
                flag = true;


            }
            if (ClinicName_txtbox.Text == "")
            {

                errorProvider1.SetError(ClinicName_txtbox, "This Field is Required");
                flag = true;


            }
            //==========Checker For the City

            if (!string.IsNullOrEmpty(City_txtbox.Text))
            {

                errorProvider1.SetError(City_txtbox, "");

            }
            if (City_txtbox.Text.Length < 3)
            {
                errorProvider1.SetError(City_txtbox, "City Name MUST be AT LEAST 3 Characters");
                flag = true;

            }
            if (int.TryParse(City_txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(City_txtbox, "Please Enter Letters Only");
                flag = true;

            }
            if (City_txtbox.Text == "")
            {

                errorProvider1.SetError(City_txtbox, "This Field is Required");
                flag = true;

            }
            //=============Governorate Checker

            if (!string.IsNullOrEmpty(Governorate_txtbox.Text))
            {

                errorProvider1.SetError(Governorate_txtbox, "");


            }
           if (Governorate_txtbox.Text.Length < 3)
            {
                errorProvider1.SetError(Governorate_txtbox, "Governorate Name MUST be AT LEAST 3 Characters");
                flag = true;


            }
            if (int.TryParse(Governorate_txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(Governorate_txtbox, "Please Enter Letters Only");
                flag = true;

            }
            if (Governorate_txtbox.Text == "")
            {

                errorProvider1.SetError(Governorate_txtbox, "This Field is Required");
                flag = true;


            }

            //==============Street Checker

            // int Street_acceptednumber = Convert.ToInt32(Street_txtbox.Text);
            if (!string.IsNullOrEmpty(Street_txtbox.Text))
            {

                errorProvider1.SetError(Street_txtbox, "");

            }
            int Accepted_Street = 0;
            Int32.TryParse(Street_txtbox.Text, out Accepted_Street);
            if (Accepted_Street < 0)
            {
                errorProvider1.SetError(Street_txtbox, "Negative Numbers are NOT Allowed!!");
                flag = true;

            }
            if (!int.TryParse(Street_txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(Street_txtbox, "Please Enter Numbers Only");
                flag = true;

            }
            if (Street_txtbox.Text == "")
            {

                errorProvider1.SetError(Street_txtbox, "This Field is Required");
                flag = true;

            }
            //================Zip Code Checker
            //int ZipCode_acceptednumber = Convert.ToInt32(zipCode_txtbox.Text);

            if (!string.IsNullOrEmpty(zipCode_txtbox.Text))
            {

                errorProvider1.SetError(zipCode_txtbox, "");


            }
            int Accepted_ZipCode = 0;
            Int32.TryParse(zipCode_txtbox.Text, out Accepted_ZipCode);
            if (Accepted_ZipCode < 0)
            {
                errorProvider1.SetError(zipCode_txtbox, "Negative Numbers are NOT Allowed!!");
                flag = true;
            }
            if (!int.TryParse(zipCode_txtbox.Text, out parsedValue))
            {
                errorProvider1.SetError(zipCode_txtbox, "Please Enter Numbers Only");
                flag = true;

            }
            if (zipCode_txtbox.Text == "")
            {

                errorProvider1.SetError(zipCode_txtbox, "This Field is Required");
                flag = true;

            }



            if (flag == false)
            {
                int result = controllerObj.InsertClinic(Int32.Parse(ID_txtbox.Text), ClinicPhone_Masked.Text, ClinicName_txtbox.Text, City_txtbox.Text,
                   Governorate_txtbox.Text, Street_txtbox.Text, zipCode_txtbox.Text);

                if (result == 0)
                {
                    MessageBox.Show("Please Enter Valid Data");


                }
                else
                {

                    MessageBox.Show("The Clinic is Created Successfully");
                    ID_txtbox.Text = "";
                    ClinicPhone_Masked.Text = "";
                    ClinicName_txtbox.Text = "";
                    City_txtbox.Text = "";
                    Governorate_txtbox.Text = "";
                    Street_txtbox.Text = "";
                    zipCode_txtbox.Text = "";

                }
            }
 }


        private void Name_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)

        {

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void ID_txtbox_TextChanged(object sender, EventArgs e)
        {
            // Name is required
            
        }

        private void ID_label_Click(object sender, EventArgs e)
        {

        }

        private void Phone_number_label_Click(object sender, EventArgs e)
        {

        }

        private void city_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Street_Label_Click(object sender, EventArgs e)
        {

        }

        private void ZipCode_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bakc_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void ClinicPhone_Masked_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
