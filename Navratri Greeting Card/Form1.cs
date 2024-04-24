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

namespace Navratri_Greeting_Card
{
    public partial class Form1 : Form
    {
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

            SolidBrush purpleBrush = new SolidBrush(Color.Purple);
            SolidBrush pintBrush = new SolidBrush(Color.Pink);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            Font drawFont = new Font("STENCIL", 32, FontStyle.Bold);

            Pen blackPen = new Pen(Color.Black, 2);
            Pen orangePen = new Pen(Color.Orange, 5);
            Pen PurplePen = new Pen(Color.Purple, 10);
            Pen YellowPen = new Pen(Color.Yellow, 10);

            //g.DrawRectangle(drawPen1, 75, 75 , 4, 100);

            //code for the dandia
            //g.DrawLine(PurplePen, 150, 150, 250, 250);
            //g.DrawLine(PurplePen, 250, 150, 150, 250);
            //g.DrawLine(PurplePen, 900, 900, 750, 750);
            //g.DrawLine(PurplePen, 350, 350, 150, 650);

            Pen pen = new Pen(Color.Brown, 5);

            // Draw first stick
            g.DrawLine(pen, 100, 200, 200, 100);
            g.DrawLine(pen, 200, 100, 250, 150);

            // Draw second stick
            g.DrawLine(pen, 300, 200, 200, 100);
            g.DrawLine(pen, 200, 100, 150, 150);

            g.DrawLine(blackPen, 10, 23, 2000, 23); //code for the lighting line

            // g.DrawArc(orangePen, 20, 20, 50, 50, 30, 100);

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

            Pen blackPen = new Pen(Color.Black, 2);
            g.DrawLine(blackPen, 10, 23, 2000, 25); //code for the lighting line

            Random random = new Random();
            for (int z = 0; z < 10; z++)
            {
                for (int i = 0; i < 27; i++)
                {
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    g.FillEllipse(new SolidBrush(randomColor), 10 + i * 50, 25, 10, 20);
                }
                Thread.Sleep(1000);
            }

            Font drawFont = new Font("STENCIL", 32, FontStyle.Bold);
            SolidBrush purpleBrush = new SolidBrush(Color.Purple);

            // Animation for "Happy Navratri" text moving to the middle
            for (int i = 800; i >= 350; i -= 10)
            {
                g.Clear(Color.Yellow);

                g.DrawString("Happy Navratri", drawFont, purpleBrush, i, 200);
                Thread.Sleep(50);
            }
        }
    }

}

