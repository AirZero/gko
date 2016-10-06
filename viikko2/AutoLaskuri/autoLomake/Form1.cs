using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoLomake
{
    public partial class Form1 : Form
    {
        Image kuva;
        int x = 0;
        int y = 0;

        public Form1()
        {
            kuva = Image.FromFile("car.png");
            InitializeComponent();

            
        }


        protected override void OnPaint(PaintEventArgs e)
        {
       //     Invalidate();
            y = y++;
            Graphics dc = e.Graphics;

        
           // int[,] sijainti = new int[4, 2];
            Pen myPen = new Pen(Color.Black);
            myPen.Width = 30;
            dc.DrawLine(myPen, 1, 100, 1000, 100);
            dc.DrawImageUnscaled(kuva, new Point(0, 0) );
            //dc.DrawImage(kuva, 0, 0, 30, 150);
          //  dc.DrawImage(kuva, 0, 0, kuva.Width, kuva.Height);

            using (Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
            {

                
                 string text2 = "Moi maailma!";
                 Rectangle rect2 = new Rectangle(150, 10, 130, 140);
                 TextFormatFlags flags = TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                // e.Graphics.DrawRectangle(Pens.Black, rect2);
                TextRenderer.DrawText(e.Graphics, text2, font2, rect2, Color.Blue, flags);
            }
        }

       

    }
}
