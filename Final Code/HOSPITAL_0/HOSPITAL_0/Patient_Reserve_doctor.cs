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
    public partial class Patient_Reserve_doctor : Form
    {
        Controller controllerObj;
        public Patient_Reserve_doctor()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Reserve_doctor_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Reserve_test rt = new Patient_Reserve_test();
            rt.Show();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Normal_doctor nd = new Patient_Normal_doctor();
            nd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_emer_doctor ed = new Patient_emer_doctor();
            ed.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Reserve_checkup rc = new Patient_Reserve_checkup();
            rc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_reserve_vaccine rv = new Patient_reserve_vaccine();
            rv.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_reserve_ray rr = new Patient_reserve_ray();
            rr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_give_report gr = new Patient_give_report();
            gr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_print_receipt pr = new Patient_print_receipt();
            pr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Give_feedback gf = new Patient_Give_feedback();
            gf.Show();
        }
    }
}
