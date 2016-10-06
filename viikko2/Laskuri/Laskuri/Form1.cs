using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        private void Laske_Click(object sender, EventArgs e)
        {
            
            if(this.ValidateChildren()){
                double matka = Double.Parse(numberTextBox1.Text);
                double aika = Double.Parse(numberTextBox2.Text);
                double vastaus = (matka / aika);
                vastaus = Math.Round(vastaus, 2);
                label2.Text = vastaus.ToString();
            
            }
            else{
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
