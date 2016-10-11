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
        string sanat = "";
        string tulostettava = "0 asdsa asd asd asd asas d";
        List<string> tuloste = new List<string>();
        
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
            timer1.Interval = 500;
           // Invalidate();
         // Graphics s = this.CreateGraphics();
            //RenderText6();
            BackColor = Color.Black;
        }
        

        protected override void OnPaint(PaintEventArgs e)
        {
           
            
            using (Font font2 = new Font("Impact", 40, FontStyle.Bold, GraphicsUnit.Point))
            {


               
                Rectangle rect2 = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);//(1, 1, 44, 44);
                TextFormatFlags flags = TextFormatFlags.Top |TextFormatFlags.Left | TextFormatFlags.WordBreak;
               //  e.Graphics.DrawRectangle(Pens.Black, rect2);
                TextRenderer.DrawText(e.Graphics, sanat, font2, rect2, Color.White, flags);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            tuloste.AddRange (tulostettava.Split(' '));
            
            
            sanat = tuloste[0];
            tuloste.Add(tuloste[0]);
            tuloste.Remove(tuloste[0]);
            Invalidate();

        }

     
    }
}
