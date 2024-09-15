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
    public partial class Nurse_Raise : Form
    {
        Controller controllerObj;
        string[] Month_arr = new string[12];
        string[] Year_arr = new string[1047];
        public Nurse_Raise()
        {
            InitializeComponent();
        }

        private void Nurse_Raise_Load(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (Nurse_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id");
            }
            else
            {
                int y;
                double Actual_Salary = 0;
                int num_days_per_week = 0;
                int actual_attendance_in_this_month = 00;
                int num_Permessions = 0;
                double ext_Hours = 0;
                double total_net_salary = 0;
                if (int.TryParse(Nurse_id.Text, out y))
                {
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    int year = Convert.ToInt32(Year.Text);
                    int month = Convert.ToInt32(Month.Text);
                    Actual_Salary = controllerObj.getnursesalary(nur_id);
                    num_days_per_week = controllerObj.getnursedaysperweek(nur_id);
                    num_Permessions = controllerObj.getmonthnursepermissions(nur_id, year, month);
                    ext_Hours = controllerObj.getnurseextrahours(nur_id, year, month);
                    actual_attendance_in_this_month = controllerObj.nurseattendenceinthismonth(nur_id, year, month);
                    if (num_days_per_week != 0)
                    {
                        total_net_salary = Actual_Salary * (actual_attendance_in_this_month / (num_days_per_week * 4.0)) + ext_Hours * 50 - (num_Permessions - 3) * 200;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!   Please enter a valid integer number for #Day Shifts/Weeky");
                    }

                    if (total_net_salary < 0)
                    {
                        total_net_salary = 0;
                    }
                    Actual_salary.Text = Actual_Salary.ToString();
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
    }
}

