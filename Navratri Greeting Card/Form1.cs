using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            g.Clear(Color.White);

            SolidBrush purpleBrush = new SolidBrush(Color.Purple);
            SolidBrush pintBrush = new SolidBrush(Color.Pink);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

            Font drawFont = new Font("STENCIL", 32, FontStyle.Bold);

            Pen blackPen = new Pen(Color.Black, 4);
            Pen orangePen = new Pen(Color.Orange, 10);
            Pen PurplePen = new Pen(Color.Purple, 10);
            Pen YellowPen = new Pen(Color.Yellow, 10);

            //g.DrawRectangle(drawPen1, 75, 75 , 4, 100);

            g.DrawLine(blackPen, 150, 150, 250, 250);
            g.DrawLine(blackPen, 10, 10, 2000, 10);

            g.DrawArc(orangePen, 20, 20, 50, 50, 30, 100);
           
            g.DrawString("Happy Navratri", drawFont, purpleBrush, 450, 150);

            










            //Random randGen = new Random(1 - 3);
            //for (int i = 0; i < 3; i++)
            //{
            //    randGen.Next(1 - 3);
            //    {
                    
            //    }
            //}
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
