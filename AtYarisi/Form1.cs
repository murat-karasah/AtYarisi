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
        public int sayac = 0, speed1, speed2, speed3, at = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            sayac = 0;
            
            pictureBox1.Location = new Point(81,84) ;
            pictureBox2.Location = new Point(81, 222);
            pictureBox3.Location = new Point(81, 348);
            timer1.Dispose();
            timer1.Start();


        }

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

            pictureBox1.Left += rnd.Next(1, 10);
            pictureBox2.Left += rnd.Next(1, 10);
            pictureBox3.Left += rnd.Next(1, 10);
            sayac++;
            label1.Text = sayac.ToString();
          //  label1.Text = pictureBox1.Location.X.ToString();

           if (pictureBox1.Location.X >= 619 )
            {
                int at = 1;
                win(at);

            }
        else    if (pictureBox2.Location.X >= 619)
            {
                int at = 2;
                win(at);

            }

            else if (pictureBox3.Location.X >= 619)
            {
                int at = 3;
                win(at);

            }
           
        }

        private  void win(int at)
        {
            timer1.Stop();
            MessageBox.Show(at+". At Kazandı  Süre:" +sayac );
        }
    }
}
