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
            
            g.Clear(Color.Black);

            SolidBrush drawBrush = new SolidBrush(Color.Purple);
            Font drawFont = new Font("STENCIL", 32, FontStyle.Bold);

            g.DrawString("Happy Navratri", drawFont, drawBrush, 450, 150);

            
        }
    }
}
