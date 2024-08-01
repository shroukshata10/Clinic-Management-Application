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
    public partial class Doc_Info : Form
    {
        Controller cont = new Controller();
        public static string doctor = "";
        public static int ID = 0;
        public Doc_Info(string doc, int id)
        {
            InitializeComponent();
            doctor = doc;
            ID = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Main_Menu form = new Main_Menu(doctor,ID);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable doctor= cont.Doctor_Info();

            NtextBox1.Text = doctor.Rows[0][0].ToString();
            AtextBox4.Text = doctor.Rows[0][1].ToString();
            FtextBox3.Text = doctor.Rows[0][2].ToString();
            StextBox2.Text = doctor.Rows[0][3].ToString();

            DataTable Doc = cont.Doctor_Ava();
            dataGridView1.DataSource = Doc;
            dataGridView1.Refresh();
            dataGridView1.Show();
            //string[] time = new string[];




        }

        private void Doc_Info_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
