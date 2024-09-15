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
    public partial class Patient_Normal_doctor : Form
    {
        Controller controllerObj;
        public Patient_Normal_doctor()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Normal_doctor_Load(object sender, EventArgs e)
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
