using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorYapimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label4.Text = "1";
            PictureBox2.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label4.Text = "0";
            PictureBox2.Visible = false;
            label7.BackColor = Color.DarkGray;
            label8.BackColor = Color.DarkGray;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label4.Text == "1")
            {
                pictureBox1.Top -= 5;

            }
            if (pictureBox1.Location.Y <= 0)
            {
                timer1.Stop();
                label7.BackColor = Color.Yellow;
                label8.BackColor = Color.Yellow;

            }

            if (label4.Text == "0")
            {
                pictureBox1.Top += 5;

            }
            if (pictureBox1.Location.Y >= 350)  
            timer1.Stop();
            label5.BackColor = Color.Yellow;
            label6.BackColor = Color.Yellow;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox2.Visible = true;
            label4.Visible = false;
        }
    }
    }
