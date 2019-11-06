using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch_tutorial
{
    public partial class Form1 : Form
    {
        DateTime time = new DateTime();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = DateTime.MinValue;
            label1.Text = time.ToString("HH：mm：ss：ff");
        }

        private void StartStopbutton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                StartStopbutton.Text = "スタート";
            }
            else
            {
                StartStopbutton.Text = "ストップ";
            }

            timer1.Enabled = !timer1.Enabled;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                time = DateTime.MinValue;
                label1.Text = time.ToString("HH：mm：ss：ff");
                LapList.Items.Clear();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddMilliseconds(10);
            label1.Text = time.ToString("HH：mm：ss：ff");
        }

        private void Rapbutton_Click(object sender, EventArgs e)
        {
            LapList.Items.Add(time.ToString("HH：mm：ss：ff"));
            time = DateTime.MinValue;
            label1.Text = time.ToString("HH：mm：ss：ff");
        }
    }
}
