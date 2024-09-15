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
    public partial class Doctor_Patient_Report : Form
    {
        Controller controllerObj;
        public Doctor_Patient_Report()
        {
            InitializeComponent();
        }

        private void Doctor_Patient_Report_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Doctor_id.Text == "" || Patient_id.Text == ""|| Patient_Report.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id and your patient id and Report");
            }
            else
            {
                int y;
                if (int.TryParse(Doctor_id.Text, out y))
                {
                    if (int.TryParse(Patient_id.Text, out y))
                    {
                        int Doc_id = Convert.ToInt32(Doctor_id.Text);
                        int Pat_id = Convert.ToInt32(Patient_id.Text);
                        string Pat_Report = Patient_Report.Text;
                        string current_day = Convert.ToString(DateTime.Now); ;
                        int r = controllerObj.docwritepatientreport(Pat_Report,Doc_id, Pat_id, current_day);
                        if (r > 0)
                            MessageBox.Show(" inserted successfully");
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!  patient id Please enter integer number only");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter doctor id integer number only");
                }
            }
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
    }
}
