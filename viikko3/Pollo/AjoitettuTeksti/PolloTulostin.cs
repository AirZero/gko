using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolloTulostin
{
    public partial class PolloTulostin: UserControl
    {
        char sanat = 'a';
        string tulostettava = "0 asdsa asd asd asd asas d";
        List<char> tuloste = new List<char>();
        int textX = 600;
        int[] textY;
        int muuttuja = 0;
        
        [Category("Tekstitulostin"),
           Description("Tulostettava teksti"),
           DefaultValue(0),
           Browsable(true)] // jos on false ei näytetä design-tilassa
           public string teksti
        {
            get { return tulostettava; }
            set { tulostettava = value; }
        }
        /*

        private void piirturi(string text1, PaintEventArgs e)
        {
        
            text1 = "Use StringFormat and Rectangle objects to" 
        + " center text in a rectangle.";
        using (Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
        {
             Rectangle rect1 = new Rectangle(10, 10, 130, 140);

             // Create a StringFormat object with the each line of text, and the block
             // of text centered on the page.
             StringFormat stringFormat = new StringFormat();
             stringFormat.Alignment = StringAlignment.Center;
             stringFormat.LineAlignment = StringAlignment.Center;

             // Draw the text and the surrounding rectangle.
             e.Graphics.DrawString(text1, font1, Brushes.Blue, rect1, stringFormat);
             e.Graphics.DrawRectangle(Pens.Black, rect1);
        }
        }

        */
        public PolloTulostin()
        {
            InitializeComponent();
           // piirturi(this, "jee");
          //
            timer1.Enabled = true;
            timer1.Interval = 10;
           // Invalidate();
         // Graphics s = this.CreateGraphics();
            //RenderText6();
            BackColor = Color.Black;
            
                
         
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            
            using (Font font2 = new Font("Impact", 40, FontStyle.Bold, GraphicsUnit.Point))
            {
                string kirjain = sanat.ToString();
        
                

                
                Point rect3 = new Point(textX, textY[muuttuja]);
                TextFormatFlags flags = TextFormatFlags.Top | TextFormatFlags.Left | TextFormatFlags.WordBreak;
                TextRenderer.DrawText(e.Graphics, kirjain, font2, rect3, Color.White, flags);

          //          textY = (int)(50*(Math.Sin(2* (textX) / 10)));
         //           Console.WriteLine(textY);
       //             Point rect2 = new Point(textX, textY);
           //         TextFormatFlags flags = TextFormatFlags.Top | TextFormatFlags.Left | TextFormatFlags.WordBreak;
        //            TextRenderer.DrawText(e.Graphics, kirjain, font2, rect2, Color.White, flags);
                int i = 0; 
                    for (i = 0; i < 100; i++)
                    {
                       
                        
                       // textX--;
                       
                    }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
          //iffillä kirjainten välistys
         //   if(muuttuja%5 == 0){
                textX--;

                textY[muuttuja] = (int)(50 * (Math.Sin(2 * (textX) / 10)));
                tuloste.AddRange(tulostettava.ToCharArray());
                sanat = tuloste[muuttuja];
                
           //     tuloste.Add(tuloste[muuttuja]);
            //    tuloste.Remove(tuloste[muuttuja]);
                Invalidate();
     //       }
          muuttuja++;

            
            if (muuttuja == tuloste.Count)
            {
                muuttuja = 0;
                Invalidate();
            }

            

        }

     
    }
}
