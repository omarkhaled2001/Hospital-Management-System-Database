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
    public partial class Manager_Doctor_Nurse_Complaints : Form
    {
        Controller controllerObj;
        public Manager_Doctor_Nurse_Complaints()
        {
            InitializeComponent();
        }

        private void Manager_Doctor_Nurse_Complaints_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Doc
            DateTime date = dateTimePicker1.Value;
            int year = Convert.ToInt32(date.Year.ToString());
            int month = Convert.ToInt32(date.Month.ToString());
            int day = Convert.ToInt32(date.Day.ToString());
            DataTable dt = controllerObj.receive_complaints_from_doctor(year, month, day);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Nur
            DateTime date = dateTimePicker1.Value;
            int year = Convert.ToInt32(date.Year.ToString());
            int month = Convert.ToInt32(date.Month.ToString());
            int day = Convert.ToInt32(date.Day.ToString());
            DataTable dt = controllerObj.receive_complaints_from_nurse(year, month, day);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form M_H = new Manager_Hiring();
            this.Hide();
            M_H.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form M_P_C = new Manager_Patient_Complaints();
            this.Hide();
            M_P_C.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form M_P_N_R = new Manager_Doctor_Nurse_Rate();
            this.Hide();
            M_P_N_R.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form M_W_R = new Manager_Write_Report();
            this.Hide();
            M_W_R.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form M_A_R = new Manager_Approve_Request();
            this.Hide();
            M_A_R.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }
    }
}




