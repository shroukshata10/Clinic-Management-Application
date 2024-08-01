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
    public partial class Form5 : Form
    {
        Controller controllerObj;

        public Form5()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.selectID_Combobox();
            Clinic_ID_Combobox.DataSource = dt;
            Clinic_ID_Combobox.DisplayMember = "ID";
            Clinic_ID_Combobox.SelectedItem = null;

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
        private void Account1_btn_Click(object sender, EventArgs e)
        {

        }

        private void edit_ac1_btn_Click(object sender, EventArgs e)
        {
        }

        private void edit_ac2_btn_Click(object sender, EventArgs e)
        {
        }

        private void edit_ac3_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Delete_ac1_btn_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void Delete_ac2_btn_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void delete_ac3_btn_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if(Clinic_ID_Combobox.Text == "")
            {
                errorProvider1.SetError(Clinic_ID_Combobox, "This Field is Required");
                flag = true;
            }
        
            if (flag == false)
            {
                DataTable dt = controllerObj.select_Doctors(Int32.Parse(Clinic_ID_Combobox.Text));
                if (dt == null)
                {
                    
                    this.SelectDoctor_DataGrid.DataSource = null;
                    SelectDoctor_DataGrid.Rows.Clear();
                    MessageBox.Show("There are No Doctors in this Clinic");
                }
                else
                
                    SelectDoctor_DataGrid.DataSource = dt;
                 
            }
           
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            int parsedValue;
            //========Checker for the user name
            if (!string.IsNullOrEmpty(FeesUpdate_txtBox.Text))
            {
                errorProvider1.SetError(FeesUpdate_txtBox, "");
            }
            if (DUserNameUpdate_txtBox.Text == "")
            {
                errorProvider1.SetError(DUserNameUpdate_txtBox, "Please Enter the User Name");
                flag = true;
            }

            int rst = controllerObj.checkDUserName(DUserNameUpdate_txtBox.Text, Int32.Parse(Clinic_ID_Combobox.Text));
            if (rst == 0)
            {
                MessageBox.Show("The Doctor is NOT Found");


            }
            //Check For the Fees
            if (!string.IsNullOrEmpty(FeesUpdate_txtBox.Text))
            {
                errorProvider1.SetError(FeesUpdate_txtBox, "");
            }
           

            if (!int.TryParse(FeesUpdate_txtBox.Text, out parsedValue))
            {
                errorProvider1.SetError(FeesUpdate_txtBox, "Please Enter Numbers ONLY");
                flag = true;
            }
            if (Int32.Parse(FeesUpdate_txtBox.Text) < 0)
            {
                errorProvider1.SetError(FeesUpdate_txtBox, "Please Enter Positive Numbers ONLY");
                flag = true;

            }
            if (FeesUpdate_txtBox.Text == "")
            {
                errorProvider1.SetError(FeesUpdate_txtBox, "Please Enter the Fees");
                flag = true;
            }
          
          
            
          

            if (flag == false)
            {
               int result = controllerObj.UpdateDoctor(DUserNameUpdate_txtBox.Text, Int32.Parse(FeesUpdate_txtBox.Text));
               if (result == 0)
               {
               MessageBox.Show("No rows are updated");
               flag = true;
               }
               else
               {
               MessageBox.Show("The row is updated successfully");
               }
            }
                
            
        }
          
        private void DoctorDelete_Click(object sender, EventArgs e)
        {
            int result = controllerObj.DeleteDoctor(DRDelete_txtBox.Text);
            if (result != 0)
            {
                MessageBox.Show("The Doctor is Deleted Successfully");

            }
            else
            {
                MessageBox.Show("No rows are deleted");

            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.Show();
        }
    }
}
