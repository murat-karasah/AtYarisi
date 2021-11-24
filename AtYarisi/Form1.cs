using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
     public   int sayac = 0,speed1,speed2,speed3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            pictureBox1.Left += rnd.Next(1, 15);
            pictureBox2.Left += rnd.Next(10, 20);
            pictureBox3.Left += rnd.Next(1, 15);
            sayac++;
            label1.Text = sayac.ToString();

        }
    }
}
