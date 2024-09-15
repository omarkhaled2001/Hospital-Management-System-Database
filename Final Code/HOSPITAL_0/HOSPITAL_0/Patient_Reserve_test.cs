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
    public partial class Patient_Reserve_test : Form
    {
        Controller controllerObj;
        public Patient_Reserve_test()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Reserve_doctor rd = new Patient_Reserve_doctor();
            rd.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void Reserve_test_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
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
