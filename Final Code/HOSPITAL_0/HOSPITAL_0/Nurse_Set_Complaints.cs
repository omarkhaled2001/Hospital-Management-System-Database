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
    public partial class Nurse_Set_Complaints : Form
    {
        Controller controllerObj;
        public Nurse_Set_Complaints()
        {
            InitializeComponent();
        }

        private void Nurse_Set_Complaints_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.getalldepid();
            Department_id.DisplayMember = "id";
            Department_id.ValueMember = "id";
            Department_id.DataSource = dt1;
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form N_R_O = new Nurse_Reserve_Overtime();
            this.Hide();
            N_R_O.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Department_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please choose your department id");
            }
            else
            {
                int dep_id = Convert.ToInt32(Department_id.Text);
                DataTable dt = controllerObj.getalldocdepid(dep_id);
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Doctor_id.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();// nurse id
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //(date)
            if (Doctor_id.Text == "" || Complaint.Text == "" || Nurse_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id and nurse id and your complaints");
            }
            else
            {
                int y;
                string current_day;
                if (int.TryParse(Doctor_id.Text, out y))
                {
                    int doc_id = Convert.ToInt32(Doctor_id.Text);
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    current_day = Convert.ToString(DateTime.Now);// (Today) 
                    string complaints = Complaint.Text; //complaints
                    int c = -1;
                    int r = controllerObj.nursesetcomplains(nur_id, doc_id,  current_day, complaints, c);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }
    }
}


