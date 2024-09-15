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
    public partial class Manager_Doctor_Nurse_Rate : Form
    {
        Controller controllerObj;
        public Manager_Doctor_Nurse_Rate()
        {
            InitializeComponent();
        }

        private void Manager_Doctor_Nurse_Rate_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.getalldepid();
            Department_id.DisplayMember = "id";
            Department_id.ValueMember = "id";
            Department_id.DataSource = dt1;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Doctor_id.Text= dataGridView2.SelectedRows[0].Cells[0].Value.ToString();// doctor id
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form M_H = new Manager_Hiring();
            this.Hide();
            M_H.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form M_P_C = new Manager_Patient_Complaints();
            this.Hide();
            M_P_C.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form M_P_N_C = new Manager_Doctor_Nurse_Complaints();
            this.Hide();
            M_P_N_C.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form M_W_R = new Manager_Write_Report();
            this.Hide();
            M_W_R.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form M_A_R = new Manager_Approve_Request();
            this.Hide();
            M_A_R.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Nurse_id.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();// nurse id
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
                DataTable dt = controllerObj.getallnursedepid(dep_id);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Doctor_rate.Text=Query ret points
            if (Nurse_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please choose doctor id");
            }
            else
            {
                DateTime date = dateTimePicker1.Value;
                int year = Convert.ToInt32(date.Year.ToString());
                int month = Convert.ToInt32(date.Month.ToString());
                int day = Convert.ToInt32(date.Day.ToString());
                int nur_id = Convert.ToInt32(Nurse_id.Text);
                DataTable dt = controllerObj.rate_nurse(nur_id, month, year,day);
                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Doctor_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please choose nurse id");
            }
            else
            {
                DateTime date = dateTimePicker1.Value;
                int year = Convert.ToInt32(date.Year.ToString());
                int month = Convert.ToInt32(date.Month.ToString());
                int day = Convert.ToInt32(date.Day.ToString());
                int doc_id = Convert.ToInt32(Doctor_id.Text); 
                DataTable dt = controllerObj.rate_doctor(doc_id, month, year, day);
                dataGridView4.DataSource = dt;
                dataGridView4.Refresh();
            }
            //Nurse_rate.Text=Query ret points

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Query doc raise points set_raise_doctor(int inputdoctor_id, int x)
            if (Doctor_id.Text == "" || Raise_Points.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id");
            }
            else
            {
                int x;
                if (int.TryParse(Raise_Points.Text, out x))
                {
                    int doc_id = Convert.ToInt32(Doctor_id.Text); 
                    int raise = Convert.ToInt32(Raise_Points.Text);
                    int r = controllerObj.set_raise_doctor(doc_id, raise);
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
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Nurse_id.Text == "" || Raise_Points.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id");
            }
            else
            {
                int x;
                if (int.TryParse(Raise_Points.Text, out x))
                {
                    int nur_id = Convert.ToInt32(Nurse_id.Text);
                    int raise= Convert.ToInt32(Raise_Points.Text);
                    int r = controllerObj.set_raise_nurse(nur_id, raise);
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
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Nurse_rate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

