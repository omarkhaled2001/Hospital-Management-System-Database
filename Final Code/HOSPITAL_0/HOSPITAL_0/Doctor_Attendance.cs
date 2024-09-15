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
    public partial class Doctor_Attendance : Form
    {
        Controller controllerObj;
        public Doctor_Attendance()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_Schedule_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Doctor_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id");
            }
            else
            {
                int y;

                if (int.TryParse(Doctor_id.Text, out y))
                {
                    string current_day;
                    int doc_id = Convert.ToInt32(Doctor_id.Text);
                    int attendence = 1;
                    current_day = Convert.ToString(DateTime.Now);
                    int r = controllerObj.insertdocattendence(doc_id, attendence, current_day);
                    if (r > 0)
                        MessageBox.Show(" inserted successfully");
                    else
                        MessageBox.Show("Insertion Failed");
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Click on Attend Button");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form D_S = new Doctor_Schedule();
            this.Hide();
            D_S.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form D_O_S = new Doctor_Organize_Schedule();
            this.Hide();
            D_O_S.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form D_M_R = new Doctor_Monthly_Report();
            this.Hide();
            D_M_R.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form D_R = new Doctor_Raise();
            this.Hide();
            D_R.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form D_R_O = new Doctor_Reserve_Overtime();
            this.Hide();
            D_R_O.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form D_S_C = new Doctor_Set__Complaints();
            this.Hide();
            D_S_C.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form D_P_R = new Doctor_Patient_Report();
            this.Hide();
            D_P_R.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
