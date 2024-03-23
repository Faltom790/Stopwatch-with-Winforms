using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form4
{   
    public partial class Form1 : Form
    {
        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Start();


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - startTime;
            lblClock.Text = ts.ToString(@"mm\:ss\.ff");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblClock.Text = "00:00:00";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
