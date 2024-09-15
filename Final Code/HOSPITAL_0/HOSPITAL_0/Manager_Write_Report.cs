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
    public partial class Manager_Write_Report : Form
    {
        Controller controllerObj;
        public Manager_Write_Report()
        {
            InitializeComponent();
        }

        private void Manager_Write_Report_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.getalldepid();
            Department_id.DisplayMember = "id";
            Department_id.ValueMember = "id";
            Department_id.DataSource = dt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form M_H = new Manager_Hiring();
            this.Hide();
            M_H.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form M_P_N_R = new Manager_Doctor_Nurse_Rate();
            this.Hide();
            M_P_N_R.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form M_A_R = new Manager_Approve_Request();
            this.Hide();
            M_A_R.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Doctor_id.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();// doctor id
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Manager_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();// nurse id
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Manager_id.Text == "" || Doctor_id.Text == "" || Report.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id and your doctor id and Report");
            }
            else
            {
                int y;
                if (int.TryParse(Manager_id.Text, out y))
                {
                    if (int.TryParse(Doctor_id.Text, out y))
                    {
                        int man_id = Convert.ToInt32(Manager_id.Text);
                        int Doc_id = Convert.ToInt32(Doctor_id.Text);
                        string doc_Report = Report.Text;
                        DateTime current_day = dateTimePicker1.Value;
                        int r= controllerObj.setreportfordoctor1(Doc_id, current_day, doc_Report,man_id);
                        if (r > 0)
                            MessageBox.Show(" inserted successfully");
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!   Please enter Doctor_id integer number only");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter Manager_id integer number only");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Manager_id.Text == "" || Nurse_id.Text == "" || Report.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter your id and your nurse id and Report");
            }
            else
            {
                int y;
                if (int.TryParse(Manager_id.Text, out y))
                {
                    if (int.TryParse(Nurse_id.Text, out y))
                    {
                        int man_id = Convert.ToInt32(Manager_id.Text);
                        int nur_id = Convert.ToInt32(Nurse_id.Text);
                        string nur_Report = Report.Text;
                        DateTime current_day =Convert.ToDateTime( dateTimePicker1.Text);
                        int r = controllerObj.setreportfornurse(nur_id, current_day, nur_Report, man_id);
                        if (r > 0)
                            MessageBox.Show(" inserted successfully");
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!   Please enter Nurse_id integer number only");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter Manager_id integer number only");
                }
            }
        }

        private void Report_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Manager_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nurse_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
