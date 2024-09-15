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
    public partial class Doctor_Raise : Form
    {
        Controller controllerObj;
        string[] Month_arr = new string[12];
        string[] Year_arr = new string[1047];
        public Doctor_Raise()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Doctor_Raise_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
            for (int i = 1; i <= 12; i++)
            {
                Month_arr[i - 1] = i.ToString();
            }
            for (int i = 1973; i < 3020; i++)
            {
                Year_arr[i - 1973] = i.ToString();
            }
            Year.DataSource = Year_arr;
            Month.DataSource = Month_arr;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                //double Actual_Salary = 0;
                int num_days_per_week = 0;
                int actual_attendance_in_this_month = 00;
                int num_Permessions = 0;
                double ext_Hours = 0;
                double total_net_salary = 0;
                if (int.TryParse(Doctor_id.Text, out y))
                {
                    int doc_id = Convert.ToInt32(Doctor_id.Text);
                    int year = Convert.ToInt32(Year.Text);
                    int month = Convert.ToInt32(Month.Text);
                    //Actual_Salary = controllerObj.getdocsalary(doc_id);
                    num_days_per_week = controllerObj.getdocdaysperweek(doc_id);
                    num_Permessions = controllerObj.getmonthdocpermissions(doc_id, year, month);
                    ext_Hours = controllerObj.getdocextrahours(doc_id, year, month);
                    actual_attendance_in_this_month = controllerObj.docattendenceinthismonth(doc_id, year, month);
                    if (num_days_per_week != 0)
                    {
                        total_net_salary =  (actual_attendance_in_this_month / (num_days_per_week * 4.0)) + ext_Hours * 50 - (num_Permessions - 3) * 200;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!   Please enter a valid integer number for #Day Shifts/Weeky");
                    }

                    if (total_net_salary < 0)
                    {
                        total_net_salary = 0;
                    }
                   // Actual_salary.Text = Actual_Salary.ToString();
                    Day_Shifts_Week.Text = num_days_per_week.ToString();
                    Attendence.Text = actual_attendance_in_this_month.ToString();
                    Permissions.Text = num_Permessions.ToString();
                    Extra_Hours.Text = ext_Hours.ToString();
                    Net_salary.Text = total_net_salary.ToString();
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
