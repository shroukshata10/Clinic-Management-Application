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
    public partial class ViewAssignedPatientsForm : Form
    {
        string username;
        string patientuser;
        

        Controller co = new Controller();
        public ViewAssignedPatientsForm()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            PatientInformationForm Pform = new PatientInformationForm();
            Pform.Show();
            this.Hide();

        }

        public void setUsername(string user)
        {
            username = user;
        }
      
        private void B_Click(object sender, EventArgs e)
        {
            DoctorMainForm Pform = new DoctorMainForm();
            Pform.setUsername(username);
            this.Hide();
            Pform.Show();

        }
        private void ViewAssignedPatientsForm_Load(object sender, EventArgs e)
        {
            int x = co.GetPatientNumber(username);
            DataTable dt = co.GetMyPatient(username);
            try
            {
                int txtno = x;
                int pointX = 30;
                int pointY = 40;
                int X = 70;
                int xl = 10;
                int yl = 10;
                int xt = 120;
                int yt = 10;
                flowLayoutPanel1.Controls.Clear();
              
                
                
                

                for (int i = 0; i < txtno; i++)
                {
                    Panel p = new Panel();
                    Label l = new Label();
                    TextBox a = new TextBox();
                    TextBox b = new TextBox();
                    Label l2 = new Label();
                    TextBox date = new TextBox();
                    Label l3 = new Label();

                    a.Enabled = false;
                    b.Enabled = false;
                    date.Enabled = false;
                    a.Size = new System.Drawing.Size(300, 27);
                    b.Size = new System.Drawing.Size(300, 27);
                    date.Size = new System.Drawing.Size(300, 27);
                    a.BackColor = System.Drawing.Color.White;
                    b.BackColor = System.Drawing.Color.White;
                    date.BackColor = System.Drawing.Color.White;

                    l.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
                    l2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
                    l3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
                    a.Text = (dt.Rows[i].Field<string>("PName"));
                    b.Text = (dt.Rows[i].Field<string>("Patient_UserName"));
                    listBox1.Items.Add(b.Text);
                    date.Text = (dt.Rows[i].Field<DateTime>("Date_Time")).ToLongDateString()+ "  From " + (dt.Rows[i].Field<TimeSpan>("Start_Time")).ToString() + " To" + (dt.Rows[i].Field<TimeSpan>("End_Time")).ToString();

                    int Y = 70;
                    p.Size = new System.Drawing.Size(450, 150);
                    p.Location = new Point(X, Y);
                    X = X + 80;
                    l.Location = new Point(xl, yl);
                    l2.Location = new Point(xl, 50);
                    b.Location = new Point(xl + 110, 50);
                    l3.Location = new Point(xl, 90);
                    date.Location = new Point(xl + 110, 90);
                   
                    l2.ForeColor = System.Drawing.Color.Black;
                  
                    a.Location = new Point(xt, yt);
                    l.Text = "Patient Name:";
                    l2.Text = "Patient ID";
                    l3.Text = "Date-Time";
                    p.BackColor = System.Drawing.Color.Transparent;
                    p.Controls.Add(l);
                    p.Controls.Add(a);
                    p.Controls.Add(l2); p.Controls.Add(b);
                    p.Controls.Add(l3); p.Controls.Add(date);
                    flowLayoutPanel1.Controls.Add(p);
                    patientuser = b.Text;
                    
                   

                    flowLayoutPanel1.Show();
                  

                }
               
               
               
                flowLayoutPanel1.Show();
            }
            catch (Exception)
            {
               // MessageBox.Show(e.ToString());
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                PatientInformationForm Pform = new PatientInformationForm();
                Pform.setPUsername(listBox1.Text);
                Pform.setDUsername(username);
                this.Hide();
                Pform.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DoctorMainForm Pform = new DoctorMainForm();
            Pform.setUsername(username);
            this.Hide();
            Pform.Show();
        }
    }
}
