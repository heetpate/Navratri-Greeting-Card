using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Security.Cryptography.X509Certificates;

//Heet Patel
//23 April, 2024
//Navratri Greeting Card

namespace Navratri_Greeting_Card
{
    public partial class Form1 : Form
    {
        SolidBrush purpleBrush = new SolidBrush(Color.Purple);    // Set all my colors, fonts, and sounds.
        SolidBrush pinkBrush = new SolidBrush(Color.Pink);
        //  SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush brownBrush = new SolidBrush(Color.Brown);

        Font drawFont = new Font("STENCIL", 32, FontStyle.Bold);
        Font arialFont = new Font("Arial", 12, FontStyle.Bold);

        Pen blackPen = new Pen(Color.Black, 2);
        Pen orangePen = new Pen(Color.Orange, 5);
        Pen PurplePen = new Pen(Color.Purple, 10);
        Pen yellowPen = new Pen(Color.Yellow, 10);
        Pen pen = new Pen(Color.Brown, 5);
        Pen bluePen = new Pen(Color.Blue, 5);

        SoundPlayer firework = new SoundPlayer(Properties.Resources.firework);
        SoundPlayer dholBeat = new SoundPlayer(Properties.Resources.dhol_beats_);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.Yellow);

            g.DrawLine(bluePen, 100, 200, 200, 100);  // Draw first stick
            g.DrawLine(bluePen, 200, 100, 250, 150);

            g.DrawLine(bluePen, 300, 200, 200, 100);   // Draw second stick
            g.DrawLine(bluePen, 200, 100, 150, 150);

            g.DrawLine(blackPen, 10, 23, 2000, 23); //code for the lighting line

            g.DrawString("Happy Navratri", drawFont, purpleBrush, 350, 200);

            for (int i = 0; i < 27; i++)
            {
                g.DrawEllipse(orangePen, 10 + i * 50, 25, 10, 20);
                g.FillEllipse(yellowBrush, 10 + i * 50, 25, 10, 20);
            }
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.Yellow);

            dholBeat.Play();

            Pen blackPen = new Pen(Color.Black, 2);

            int x = 0;

            while (x < 225)
            {
                g.Clear(Color.Yellow);
                g.DrawString("Happy Navratri", drawFont, purpleBrush, 350, 0 + x);
                x = x + 20;
                Thread.Sleep(200);
            }

            for (int i = 0; i < 501; i = i + 500)   // Makes the two candies.
            {
                g.FillEllipse(pinkBrush, 220 + i, 330, 100, 75);
                g.FillPie(brownBrush, 170 + i, 320, 100, 100, 135, 90);
                g.FillPie(brownBrush, 270 + i, 320, 100, 100, 315, 90); 
            }
            firework.Play();

            g.DrawLine(bluePen, 100, 200, 200, 100);  // Draw first stick
            g.DrawLine(bluePen, 200, 100, 250, 150);

            g.DrawLine(bluePen, 300, 200, 200, 100);   // Draw second stick
            g.DrawLine(bluePen, 200, 100, 150, 150);

            Random random = new Random();   // Random code for random colors
            for (int z = 0; z < 50; z++)   // Loops for the colour to go for 
            {
                for (int i = 0; i < 27; i++)  //how many times the colour repeats
                {
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    g.FillEllipse(new SolidBrush(randomColor), 10 + i * 50, 25, 10, 20);  //random colour code
                    g.DrawLine(blackPen, 10, 23, 2000, 25);
                }
                Thread.Sleep(200);
            }
            dholBeat.Stop();
            firework.Stop();
        }
    }
}



