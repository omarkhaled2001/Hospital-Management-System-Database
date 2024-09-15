using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_0
{
    public partial class Patient_emer_doctor : Form
    {
        Controller controllerObj;
        public Patient_emer_doctor()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void emer_doctor_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Reserve_doctor rd = new Patient_Reserve_doctor();
            rd.Show();
        }
    }
}
