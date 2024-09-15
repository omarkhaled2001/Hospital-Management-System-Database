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
    public partial class Nurse_Attendance : Form
    {
        Controller controllerObj;
        public Nurse_Attendance()
        {
            InitializeComponent();
        }

        private void Attend_Click(object sender, EventArgs e)
        {
            if (Nurse_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id");
            }
            else
            {
                int y;

                if (int.TryParse(Nurse_id.Text, out y))
                {
                    string current_day;
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    int attendence = 1;
                    current_day = Convert.ToString(DateTime.Now);
                    int r = controllerObj.insertnurseattendence(nur_id, attendence, current_day);
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

        private void button3_Click(object sender, EventArgs e)
        {

            Form N_O_S = new Nurse_Organize_Schedule();
            this.Hide();
            N_O_S.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form N_M_R = new Nurse_Monthly_Report();
            this.Hide();
            N_M_R.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form N_R = new Nurse_Raise();
            this.Hide();
            N_R.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form N_R_O = new Nurse_Reserve_Overtime();
            this.Hide();
            N_R_O.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form N_S_C = new Nurse_Set_Complaints();
            this.Hide();
            N_S_C.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Nurse_Attendance_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }
    }
}
//Form N_A = new Nurse_Attendance();
//this.Hide();
//N_A.Show();
//Form N_O_S = new Nurse_Organize_Schedule();
//this.Hide();
//N_O_S.Show();
//Form N_M_R = new Nurse_Monthly_Report();
//this.Hide();
//N_M_R.Show();
//Form N_R = new Nurse_Raise();
//this.Hide();
//N_R.Show();
//Form N_R_O = new Nurse_Reserve_Overtime();
//this.Hide();
//N_R_O.Show();
//Form N_S_C = new Nurse_Set_Complaints();
//this.Hide();
//N_S_C.Show();
