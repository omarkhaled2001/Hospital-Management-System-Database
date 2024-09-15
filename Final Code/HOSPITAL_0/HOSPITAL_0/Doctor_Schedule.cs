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
    public partial class Doctor_Schedule : Form
    {
        Controller controllerObj;
        public Doctor_Schedule()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Doctor_Schedule_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Doctor_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id");
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter the date");
            }
            else
            {
                int y;
                int total_num_of_patient = 0;
                if (int.TryParse(Doctor_id.Text, out y))
                {
                    int doc_id = Convert.ToInt32(Doctor_id.Text);
                    string choosen_day = dateTimePicker1.Value.ToString();
                    total_num_of_patient = controllerObj.numberpatientstoday(doc_id, choosen_day);
                    total_num_patient.Text = total_num_of_patient.ToString();
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Click on any of three Buttons");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    int doc_id = Convert.ToInt32(Doctor_id.Text);
                    string choosen_day = dateTimePicker1.Value.ToString();
                    DataTable dt1 = controllerObj.patientinfo2(doc_id, choosen_day);
                    Patient_id.DisplayMember = "patient_id";
                    Patient_id.ValueMember = "patient_id";
                    Patient_id.DataSource = dt1;
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Doctor_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id");
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter the date");
            }
            else
            {
                int y;
                if (int.TryParse(Doctor_id.Text, out y))
                {
                    int doc_id = Convert.ToInt32(Doctor_id.Text);
                    string choosen_day = dateTimePicker1.Value.ToString();
                    DataTable dt1 = controllerObj.patientinfo2(doc_id, choosen_day);
                    dataGridView1.DataSource = dt1;
                    dataGridView1.Refresh();

                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Doctor_id.Text == "" && Patient_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id and choose your patient id ");
            }
            else
            {
                int y;
                if (int.TryParse(Doctor_id.Text, out y))
                {
                    int doc_id = Convert.ToInt32(Doctor_id.Text);
                    int Pat_id = Convert.ToInt32(Patient_id.Text);
                    DataTable dt1 = controllerObj.getallpatientreports(doc_id, Pat_id);
                    dataGridView1.DataSource = dt1;
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if(Doctor_id.Text == "")
            {
                MessageBox.Show("Please!  enter your id first");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form D_A = new Doctor_Attendance();
            this.Hide();
            D_A.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patient_report.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();// patient_report
        }
    }
}
