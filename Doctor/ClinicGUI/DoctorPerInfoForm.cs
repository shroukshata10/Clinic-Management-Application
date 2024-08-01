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
    public partial class DoctorPerInfoForm : Form
    {
        string MainUSername;
        Controller controller = new Controller();
        public void setUsername(string user)
        {
            MainUSername = user;
        }
      
        public DoctorPerInfoForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorMainForm Fd = new DoctorMainForm();
            Fd.setUsername(MainUSername);
            Fd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AssignedClinicsForm Acf = new AssignedClinicsForm();
            Acf.setUserName(MainUSername);
            Acf.SetDataGrid(MainUSername);
            Acf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateInfoForm Uf = new UpdateInfoForm();
            Uf.setUsername(MainUSername);
            DataTable doctorInfo = controller.getDoctorInfo(MainUSername);
            DataTable pass = controller.getPassword(MainUSername);
            string name = (doctorInfo.Rows[0].Field<string>("DName"));
            string add = (doctorInfo.Rows[0].Field<string>("D_Address"));
            string phone = (doctorInfo.Rows[0].Field<string>("Dphone_number"));
            string password = (pass.Rows[0].Field<string>("Password"));
            int fees = Int32.Parse((doctorInfo.Rows[0][5]).ToString());
            string f = fees.ToString() ;
            // TO DO 
            Uf.SetMyInfo(name, add, phone, f, password);
            Uf.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DoctorPerInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable doctorInfo = controller.getDoctorInfo(MainUSername);
                DataTable docDegree = controller.GetDoctorDegree(MainUSername);
                if (doctorInfo != null)
                {
                    textBox1.Text = (doctorInfo.Rows[0].Field<string>("DName"));
                    textBox2.Text = (doctorInfo.Rows[0].Field<string>("D_Address"));
                    textBox3.Text = (doctorInfo.Rows[0].Field<string>("Dphone_number"));
                    textBox5.Text = (doctorInfo.Rows[0].Field<string>("Specialization"));

                    int fees = Int32.Parse((doctorInfo.Rows[0][5]).ToString());
                    textBox6.Text = fees.ToString() +" EGP";
                    for (int i = 0; i < docDegree.Rows.Count; i++)
                    {
                        listBox1.Items.Add(docDegree.Rows[i].Field<string>("Dr_Degree"));
                    }
                   
                   
                }
            }
            catch(Exception exc)
            {
                
            }

        }
    }
}
