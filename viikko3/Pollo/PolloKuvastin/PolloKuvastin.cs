using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolloKuvastin
{
    public partial class PolloKuvastin: UserControl
    {
        Image pollokuva;

        public PolloKuvastin()
        {
            pollokuva = Image.FromFile("owl.png");
            InitializeComponent();
            

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics test = e.Graphics;
            
           
            

            //Pen myPen = new Pen(Color.Black);
           // myPen.Width = 30;
            //test.DrawLine(myPen, 1, 100, 1000, 100);
            test.DrawImageUnscaled(pollokuva, new Point(0, 0));
            //dc.DrawImage(kuva, 0, 0, 30, 150);
            //  dc.DrawImage(kuva, 0, 0, kuva.Width, kuva.Height);

        }
    }

         
}
