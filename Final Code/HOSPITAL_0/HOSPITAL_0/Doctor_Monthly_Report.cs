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
    public partial class Doctor_Monthly_Report : Form
    {
        Controller controllerObj;
        public Doctor_Monthly_Report()
        {
            InitializeComponent();
        }

        private void Monthly_Report_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
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
                if (int.TryParse(Doctor_id.Text, out y))
                {
                    int doc_id = Convert.ToInt32(Doctor_id.Text);
                    DataTable dt = controllerObj.getdocevaluation(doc_id);
                    dataGridView2.DataSource = dt;
                    dataGridView2.Refresh();

                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter integer number only");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Monthly_Report.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();// doctor_report
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
    }
}
