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
    public partial class Nurse_Reserve_Overtime : Form
    {
        Controller controllerObj;
        public Nurse_Reserve_Overtime()
        {
            InitializeComponent();
        }

        private void Nurse_Reserve_Overtime_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form N_A = new Nurse_Attendance();
            this.Hide();
            N_A.Show();

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

        private void button9_Click(object sender, EventArgs e)
        {
            if (Nurse_id.Text == "" || Extra_Hours.Text == "")
            {
                MessageBox.Show("Incorrect input!  Please enter Id and Extra Hours");
            }
            else
            {
                int y;
                double c;
                string choosen_date_day = dateTimePicker1.Value.ToString();
                if (int.TryParse(Nurse_id.Text, out y))
                {
                    if (double.TryParse(Extra_Hours.Text, out c))
                    {
                        int nur_id = Convert.ToInt32(Nurse_id.Text);
                        double extra_hour = Convert.ToDouble(Extra_Hours.Text);

                        int r = controllerObj.reserveovertimenurse(nur_id, extra_hour, choosen_date_day);
                        if (r > 0)
                            MessageBox.Show(" inserted successfully");
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!   Please enter extra hour number only");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter id integer number only");
                }
            }
        }
    }
}





