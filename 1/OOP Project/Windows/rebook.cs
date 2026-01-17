using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Project;

namespace OOP_Project.Windows
{
    public partial class rebook : Form
    {
        public rebook()
        {
            InitializeComponent();
        }

        private void rebook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Form1 and hide the current rebook form
            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open exispatient form and hide the current rebook form
            var patientForm = new exispatient();
            patientForm.Show();
            this.Hide();
        }
    }
}
