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
    public partial class Login : Form
    {
        string[] arr_users = new string[4] { "MANAGER", "DOCTOR", "NURSE", "RECIPTIONIST" };
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            USERS.DataSource = arr_users;
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            USER_NAME.Text = "";
            PASSWORD.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (USERS.SelectedItem.ToString() == "MANAGER")
            {
                if (USER_NAME.Text == "Admin")
                {
                    if (PASSWORD.Text == "$4_omar_kareem_shredan_nada_$4")
                    {
                        Form Mang_form = new Manager_Hiring();
                        Mang_form.Show();
                        this.Hide();
                    }
                    else
                    {
                        string message = "If you are Admin , Enter the correct PASSWORD";
                        string title = "WARNING";
                        MessageBox.Show(message, title);
                    }

                }
            }
            else if (USERS.SelectedItem.ToString() == "DOCTOR")
            {
                if (USER_NAME.Text == "Admin")
                {
                    if (PASSWORD.Text == "$4_omar_kareem_shredan_nada_$4")
                    {
                        Form Doc_form = new Doctor_Attendance();
                        Doc_form.Show();
                        this.Hide();
                    }
                    else
                    {
                        string message = "If you are Admin , Enter the correct PASSWORD";
                        string title = "WARNING";
                        MessageBox.Show(message, title);
                    }

                }
            }
            else if (USERS.SelectedItem.ToString() == "NURSE")
            {
                if (USER_NAME.Text == "Admin")
                {
                    if (PASSWORD.Text == "$4_omar_kareem_shredan_nada_$4")
                    {
                        Form Nur_form = new Nurse_Attendance();
                        Nur_form.Show();
                        this.Hide();
                    }
                    else
                    {
                        string message = "If you are Admin , Enter the correct PASSWORD";
                        string title = "WARNING";
                        MessageBox.Show(message, title);
                    }

                }
            }
            else if (USERS.SelectedItem.ToString() == "RECIPTIONIST")
            {
                if (USER_NAME.Text == "Admin")
                {
                    if (PASSWORD.Text == "$4_omar_kareem_shredan_nada_$4")
                    {

                    }
                    else
                    {
                        string message = "If you are Admin , Enter the correct PASSWORD";
                        string title = "WARNING";
                        MessageBox.Show(message, title);
                    }

                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            PASSWORD.UseSystemPasswordChar = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            PASSWORD.UseSystemPasswordChar = true;
        }
    }

}
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace SuperMarket_Project
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void label8_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {


//        }


//        private void button2_Click(object sender, EventArgs e)
//        {
//            if(USER_NAME.Text == "" || PASSWORD.Text == "" || USERS.SelectedItem == null)
//            {
//                string message = "Enter the USER_ROLE and USERNAME and PASSWORD";
//                string title = "WRONG INPUT";
//                MessageBox.Show(message, title);
//            }
//            else
//            {


//        

//        private void pictureBox3_Click(object sender, EventArgs e)
//        {

//        }

//        private void pictureBox1_Click(object sender, EventArgs e)
//        {
//           
//        }
//    }
//}