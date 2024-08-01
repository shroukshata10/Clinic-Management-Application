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
    public partial class Form8 : Form
    {
        Controller ControllerObj = new Controller();
        public Form8()
        {
            InitializeComponent();
            DataTable dt = ControllerObj.selectID_Combobox();
            ClinicID_combobox.DataSource = dt;
            ClinicID_combobox.DisplayMember = "ID";
            ClinicID_combobox.SelectedItem = null;
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The account is deleted Successfully ");
        }

        private void No_btn_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (ClinicID_combobox.Text == "")
            {
                errorProvider1.SetError(ClinicID_combobox, "This Field is Required");
                flag = true;
            }

            if (flag == false)
            {
                DataTable dt = ControllerObj.selectReceptionist(Int32.Parse(ClinicID_combobox.Text));
                if (dt == null)
                {
                    this.SelectReceptionist_DataGrid.DataSource = null;
                    SelectReceptionist_DataGrid.Rows.Clear();
                    MessageBox.Show("There are No Receptionists in this Clinic");
                  
                    flag = true;
                }
                else

                    SelectReceptionist_DataGrid.DataSource = dt;

            }

        }


        /*  if (flag == false)
              {
                  DataTable dt = ControllerObj.selectReceptionist(RID_TxtBox.Text);
              if (dt == null)
              {
                  MessageBox.Show("There are NO Receptionists in this Clinic");
              }
              else
              {
                  SelectReceptionist_DataGrid.DataSource = dt;

              }*/
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DoctorDelete_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            int ParsedValue;
            //========Checker for the user name
            if (!string.IsNullOrEmpty(RUserNameUpdate_txtBox.Text))
            {
                errorProvider1.SetError(RUserNameUpdate_txtBox, "");

            }
            if (RUserNameUpdate_txtBox.Text == "")
            {
                errorProvider1.SetError(RUserNameUpdate_txtBox, "Please Enter the User Name");
                flag = true;
            }
            int rst = ControllerObj.Check_Rec_UserName(RUserNameUpdate_txtBox.Text, Int32.Parse(ClinicID_combobox.Text));
            if (rst == 0)
            {
                MessageBox.Show("The Receptionist is NOT Found");
                flag = true;


            }
            ///Checker for the salary
            if (!string.IsNullOrEmpty(RSalaryUpdate_txtBox.Text))
            {
                errorProvider1.SetError(RSalaryUpdate_txtBox, "");

            }
            
            if(!int.TryParse(RSalaryUpdate_txtBox.Text, out ParsedValue))
            {
                errorProvider1.SetError(RSalaryUpdate_txtBox, "Please Enter Numbers Only");
                flag = true;

            }
            if (Int32.Parse(RSalaryUpdate_txtBox.Text) < 0)
            {
                errorProvider1.SetError(RSalaryUpdate_txtBox, "Please Enter Positive Number Only");
                flag = true;
            }
            if (RSalaryUpdate_txtBox.Text == "")
            {
                errorProvider1.SetError(RSalaryUpdate_txtBox, "Please Enter the Salary");
                flag = true;
            }

           


            if (flag == false)
            {
                int result = ControllerObj.updateRecep(RUserNameUpdate_txtBox.Text, Int32.Parse(RSalaryUpdate_txtBox.Text));
                if (result == 0)
                {
                    MessageBox.Show("The row is updated successfully");

                }
                else
                {
                    MessageBox.Show("No rows are updated");
                    flag = true;
                }
            }
        }

        private void DoctorDelete_Click_1(object sender, EventArgs e)
        {
            int result = ControllerObj.deleteReceptionist(RecDelete_txtBox.Text);
            if (result == 0)
            {
                MessageBox.Show("The Receptionist is deleted Successfully");

            }
            else
            {
                MessageBox.Show("No rows are deleted");

            }

        }

        private void RID_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
