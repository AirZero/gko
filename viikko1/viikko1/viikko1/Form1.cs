using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace viikko1
{
    public partial class Ohjelma : Form
    {

        public List<TextBox> kentat = new List<TextBox>();



        public Ohjelma()
        {
            InitializeComponent();
            // FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        protected override void OnValidating(CancelEventArgs e)
        {



            /*           try
                       {
                           Regex.Replace(XML, @"\s+", "");
                       }
                       */

            //    base.OnValidating(); 
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        
        private void buttonLisaaKentta_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxSyote.Text) == true) { }

            else
            {


                int x = 30 + (1 + kentat.Count) * 25;
                System.Windows.Forms.TextBox uusiboksi = new TextBox();
                uusiboksi.Location = new System.Drawing.Point(15, x);
                uusiboksi.Size = new System.Drawing.Size(100, 02);
                uusiboksi.TabIndex = 1;
                kentat.Add(uusiboksi);
                Controls.Add(uusiboksi);
                uusiboksi.Text = textBoxSyote.Text.Trim();
                uusiboksi.BackColor = System.Drawing.Color.Turquoise;
                flowLayoutPanel1.Controls.Add(uusiboksi);
                uusiboksi.Margin = new System.Windows.Forms.Padding(0);
                uusiboksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
              
                

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWin = new AboutBox1();
            aboutWin.Show();

        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printCtrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Order_Click(object sender, EventArgs e)
        {
            //Lajitellaan kentat-lista tekstien pituuden mukaan.
            for (int i = 0; i < kentat.Count; i++)
            {

                kentat.Sort(delegate(TextBox test1, TextBox test2)
                {
                    return test1.Text.Length.CompareTo(test2.Text.Length);
                });
            };

            //Tyhjennetään layout-paneelista vanhat epäjärjestyksessä olevat tekstilaatikot
            flowLayoutPanel1.Controls.Clear();

            //Ajetaan uudelleen järjestyksessä oleva listan sisältö layout-paneeliin.
            foreach (TextBox laatikko in kentat)
            {
                flowLayoutPanel1.Controls.Add(laatikko);
            }
        }


    

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.Controls.Remove(kentat.Last());
            kentat.Remove(kentat.Last());
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Ohjelma_Load(object sender, EventArgs e)
        {

        }
    }
}
