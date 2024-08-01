using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receptionist
{
    public partial class Doc_Available : Form
    {
      public Controller Cclinic = new Controller();
        public static string doctor = "";
        public static int ID = 0;
        public Doc_Available()
        {
            InitializeComponent();
            
        }  

       

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cclinic.Drsetter(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            doctor = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            Cclinic.CIDsetter(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString())); 
            ID= Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            Main_Menu form = new Main_Menu(doctor,ID);
            form.Show();
            this.Hide();
           
           
            
           // MessageBox.Show(Cclinic.Drgetter()); //checker
            //MessageBox.Show(Cclinic.CIDgetter().ToString()); //checker
        }


        private void Backbutton_Click_1(object sender, EventArgs e)
        {
            DataTable dt = Cclinic.ShowDoctors();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Show();
        }
    }
}
/*DataTable dt = cont.searchAppointments(Int16.Parse(textBox2.Text), textBox1.Text);
dataGridView1.DataSource = dt;
dataGridView1.Refresh();
dataGridView1.Show();*/