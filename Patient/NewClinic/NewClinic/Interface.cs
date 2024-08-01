using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewClinic
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
          SignUpForm SignIN = new SignUpForm();
            SignIN.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpForm SIgnup = new SignUpForm();
            SIgnup.Show();
            this.Hide();
        }
    }
}
