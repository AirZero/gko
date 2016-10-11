using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pollo
{
    public partial class Form1 : Form
    {


        Image pollokuva;
        float pollokokoX;
        float pollokokoY;
        int x = 0;
        bool totuus = true;

        public Form1()
        {
            //BackColor = ;
            pollokokoX = ClientSize.Width * 2;
            pollokokoY = ClientSize.Height * 2;

            pollokuva = Image.FromFile("owl.png");
            
           // Controls.SetChildIndex(, 0);
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 10;

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics test = e.Graphics;

            LinearGradientBrush agb =
        new LinearGradientBrush(new Point(0, 0),
                               new Point(0, ClientSize.Height),
                               Color.LightBlue,
                               Color.DarkGreen);
            e.Graphics.FillRectangle(agb, 0, 0, ClientSize.Width, ClientSize.Height);

            LinearGradientBrush lgb =
        new LinearGradientBrush(new Point(0, 0),
                               new Point(0, ClientSize.Height),
                               Color.DarkGreen,
                               Color.LightBlue);
            e.Graphics.FillRectangle(lgb, 0, ClientSize.Height/2, ClientSize.Width, ClientSize.Height);

            

            //Piirtää pöllön
            test.DrawImage(pollokuva, x, 0, pollokokoX, pollokokoY);
        }
       

        //Liikuttaa pöllöä edestakaisin.
        private void timer1_Tick(object sender, EventArgs e)
        {
     
            while (totuus == true)
            {
                x++;           
                
                Invalidate();
                if (x > 300) { totuus = false; }
                break;

            }
            
            while (totuus == false)
            {
                x--;
                
                Invalidate();
                if (x < 0) { totuus = true; }
                break;
            }
            
        }
    }
}
