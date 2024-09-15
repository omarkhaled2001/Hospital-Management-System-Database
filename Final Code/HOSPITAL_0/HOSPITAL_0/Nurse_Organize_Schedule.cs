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
    public partial class Nurse_Organize_Schedule : Form
    {
        Controller controllerObj;
        string[] arr_start_pm_am = new string[2] { "AM", "PM" };
        string[] arr_end_pm_am = new string[2] { "AM", "PM" };
        string[] arr_Role = new string[2] { "Normal", "Emergency" };
        string[] arr_days = new string[7] { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        string[] arr_new_days = new string[7] { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        string[] arr_start_minitues = new string[60];
        string[] arr_start_hours = new string[12];
        string[] arr_End_minitues = new string[60];
        string[] arr_End_hours = new string[12];
        public Nurse_Organize_Schedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form N_A = new Nurse_Attendance();
            this.Hide();
            N_A.Show();

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

        private void Nurse_Organize_Schedule_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
            Role.DataSource = arr_Role;
            for (int i = 0; i < 60; i++)
            {
                arr_start_minitues[i] = i.ToString();
                arr_End_minitues[i] = i.ToString();
            }
            for (int i = 0; i < 12; i++)
            {
                arr_start_hours[i] = i.ToString();
                arr_End_hours[i] = i.ToString();
            }
            Start.DataSource = arr_start_pm_am;
            End.DataSource = arr_end_pm_am;
            //------------------------------
            Day.DataSource = arr_days;
            New_Day.DataSource = arr_new_days;
            //------------------------------
            Start_Hour.DataSource = arr_start_hours;
            End_Hour.DataSource = arr_End_hours;
            //------------------------------
            Start_Minute.DataSource = arr_start_minitues;
            End_Minute.DataSource = arr_End_minitues;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Nurse_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id and choose The Date");
            }
            else
            {
                int y;
                if (int.TryParse(Nurse_id.Text, out y))
                {
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    string day = Day.Text;
                    int r = controllerObj.deletenurseshift(nur_id, day);
                    if (r > 0)
                        MessageBox.Show(" delete successfully");
                    else
                        MessageBox.Show("delete Failed");
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Nurse_id.Text == "" )
            {
                MessageBox.Show("Incorrect input!   Please enter your id and #of Reservations");
            }
            else
            {
                int y;
                if (int.TryParse(Nurse_id.Text, out y))
                {
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    string day = Day.Text;
                    string work_kind = Role.Text;
                    string start_End_shift = "From " + Start_Hour.Text + " : " + Start_Minute.Text + " " + Start.Text + " To " + End_Hour.Text + " : " + End_Minute.Text + " " + End.Text;
                    int r = controllerObj.insertnurseshift(nur_id, day, start_End_shift, work_kind);
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

        private void button11_Click(object sender, EventArgs e)
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
                    string UPDATED_SHIFT = "From " + Start_Hour.Text + " : " + Start_Minute.Text + " " + Start.Text + " To " + End_Hour.Text + " : " + End_Minute.Text + " " + End.Text;
                    //UPDATE doctor_shift SET start_end_shift=new_start_end WHERE nur_id=id and day=current_day
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    string day = Day.Text;
                    int r = controllerObj.updatenurseshiftshift(nur_id, day, UPDATED_SHIFT);
                    if (r > 0)
                        MessageBox.Show(" update shift successfully");
                    else
                        MessageBox.Show("update shift Failed");
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Nurse_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id ");
            }
            else
            {
                int y;
                if (int.TryParse(Nurse_id.Text, out y))
                {
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    string day = Day.Text;
                    string updated_day = New_Day.Text;
                    int r = controllerObj.updatenurseshiftday(nur_id, day, updated_day);
                    if (r > 0)
                        MessageBox.Show(" update day successfully");
                    else
                        MessageBox.Show("update day Failed");

                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
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
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    DataTable dt = controllerObj.shownurseshift(nur_id);
                    dataGridView2.DataSource = dt;
                    dataGridView2.Refresh();
                    //dt=get all shifts for doc id in 
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }
    }
}


