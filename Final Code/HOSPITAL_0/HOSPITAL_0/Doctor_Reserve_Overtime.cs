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
    public partial class Doctor_Reserve_Overtime : Form
    {
        Controller controllerObj;
        public Doctor_Reserve_Overtime()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Doctor_id.Text == "" || Extra_Hours.Text == "")
            {
                MessageBox.Show("Incorrect input!  Please enter Id and Extra Hours");
            }
            else
            {
                int y;
                double c;
                string choosen_date_day = dateTimePicker1.Value.ToString();
                if (int.TryParse(Doctor_id.Text, out y))
                {
                    if (double.TryParse(Extra_Hours.Text, out c))
                    {
                        int doc_id = Convert.ToInt32(Doctor_id.Text);
                        double extra_hour = Convert.ToDouble(Extra_Hours.Text);

                        int r = controllerObj.reserveovertime(doc_id, extra_hour, choosen_date_day);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Reserve_Overtime_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form D_A = new Doctor_Attendance();
            this.Hide();
            D_A.Show();
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
    }
}
