using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HOSPITAL_0
{
    public partial class Manager_Hiring : Form
    {
        Controller controllerObj;
        public Manager_Hiring()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.showstuff();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.showdoctor();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.shownurse();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (stuff_id.Text == "" || stuff_fname.Text == "" ||stuff_address.Text=="" || stuff_dapartment .Text == "" || stuff_mname.Text == "" || stuff_lname.Text == "" || stuff_salary.Text == "" || stuff_specializations.Text=="")
            {
                MessageBox.Show("Incorrect input!   enter all needed input");
            }
            else
            {
                int y;
                float c;
                if (int.TryParse(stuff_id.Text, out y))
                {
                    if (float.TryParse(stuff_salary.Text, out c))
                    {
                        float salary = 5000;//float.Parse(doctor_salary.Text, CultureInfo.InvariantCulture.NumberFormat);
                        //float salary =(float) Convert.ToDouble(doctor_salary.Text);
                        int id = Convert.ToInt32(stuff_id.Text);
                        int dep_id= Convert.ToInt32(stuff_dapartment.Text);
                        int r = controllerObj.hirestuff1(id, stuff_fname.Text, stuff_mname.Text, stuff_lname.Text, stuff_address.Text, salary,stuff_specializations.Text, dep_id);
                        if (r > 0)
                            MessageBox.Show(" inserted successfully");
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!   Please enter id integer number only");
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter id integer number only");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Manager_Hiring_Load(object sender, EventArgs e)
        {
            timer1.Start();
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.getalldepid();
            stuff_dapartment.DisplayMember = "id";
            stuff_dapartment.ValueMember = "id";
            stuff_dapartment.DataSource = dt1;
            doctor_dapartment.DisplayMember = "id";
            doctor_dapartment.ValueMember = "id";
            doctor_dapartment.DataSource = dt1;
            nurse_dapartment.DisplayMember = "id";
            nurse_dapartment.ValueMember = "id";
            nurse_dapartment.DataSource = dt1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form M_P_C = new Manager_Patient_Complaints();
            this.Hide();
            M_P_C.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (stuff_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter stuff id ");
            }
            else
            {
                int y;
                if (int.TryParse(stuff_id.Text, out y))
                {
                    int id = Convert.ToInt32(stuff_id.Text); 
                    int r = controllerObj.deletestuff(id);
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

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (doctor_id.Text == "" || doctor_fname.Text == "" || doctor_address.Text == "" || doctor_dapartment.Text == "" || doctor_mname.Text == "" || doctor_lname.Text == "" || doctor_salary.Text == "" )
            {
                MessageBox.Show("Incorrect input!   enter all needed input");
            }
            else
            {
                int y;
                float c;
                if (int.TryParse(doctor_id.Text, out y))
                {
                    if (float.TryParse(doctor_salary.Text, out c))
                    {
                        float salary = 5000;// float.Parse(doctor_salary.Text, CultureInfo.InvariantCulture.NumberFormat);
                        //float salary = (float)Convert.ToDouble(doctor_salary.Text);
                        int id = Convert.ToInt32(doctor_id.Text);
                        int dep_id = Convert.ToInt32(doctor_dapartment.Text);
                        int r = controllerObj.hiredoctor1(id, doctor_fname.Text, doctor_mname.Text, doctor_lname.Text, doctor_address.Text, salary, dep_id);
                        if (r > 0)
                            MessageBox.Show(" inserted successfully");
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!   Please enter id integer number only");
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter id integer number only");
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if ( nurse_id.Text == "" || nurse_fname.Text == "" || nurse_address.Text == "" || nurse_dapartment.Text == "" || nurse_mname.Text == "" || nurse_lname.Text == "" || nurse_salary.Text == "")
            {
                MessageBox.Show("Incorrect input!   enter all needed input");
            }
            else
            {
                int y;
                float c;
                if (int.TryParse(nurse_id.Text, out y))
                {
                    if (float.TryParse(nurse_salary.Text, out c))
                    {
                        float salary = 5000;// float.Parse(doctor_salary.Text, CultureInfo.InvariantCulture.NumberFormat);
                        //float salary = (float)Convert.ToDouble(doctor_salary.Text);
                        int id = Convert.ToInt32(nurse_id.Text);
                        int dep_id = Convert.ToInt32(nurse_dapartment.Text);
                        int r = controllerObj.hirenurse1(id, nurse_fname.Text, nurse_mname.Text, nurse_lname.Text, nurse_address.Text, salary, dep_id);
                        if (r > 0)
                            MessageBox.Show(" inserted successfully");
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect input!   Please enter id integer number only");
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect input!   Please enter id integer number only");
                }
            }
        }

        private void nurse_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (doctor_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter doctor id ");
            }
            else
            {
                int y;
                if (int.TryParse(doctor_id.Text, out y))
                {
                    int id = Convert.ToInt32(doctor_id.Text);
                    int r = controllerObj.deletedoctor(id);
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

        private void button19_Click(object sender, EventArgs e)
        {
            if (nurse_id.Text == "")
            {
                MessageBox.Show("Incorrect input!   Please enter nurse id ");
            }
            else
            {
                int y;
                if (int.TryParse(nurse_id.Text, out y))
                {
                    int id = Convert.ToInt32(nurse_id.Text);
                    int r = controllerObj.deletenurse(id);
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
    }
}
