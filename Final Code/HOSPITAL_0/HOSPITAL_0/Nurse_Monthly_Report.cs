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
    public partial class Nurse_Monthly_Report : Form
    {
        Controller controllerObj;
        public Nurse_Monthly_Report()
        {
            InitializeComponent();
        }

        private void Nurse_Monthly_Report_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Show_My_Report_Click(object sender, EventArgs e)
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
                    DataTable dt = controllerObj.getnurseevaluation(nur_id);
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
            Monthly_Report.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();// nurse_report
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
    }
}

      




