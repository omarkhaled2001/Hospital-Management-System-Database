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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 10)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Form log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
