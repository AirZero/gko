using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLaskuri
{
    public partial class Autolaskuri: UserControl
    {
        int pLaskuri = 0;
        

        // propertyn properties-listauksen kustomointia
        [Category("Laskuri"),
        Description("Autojen määrä"),
        DefaultValue(0),
        Browsable(true)] // jos on false ei näytetä design-tilassa
        public int automaara
        {
            get { return pLaskuri; }
            set { pLaskuri = value; }
        }

        public Autolaskuri()
        {
            InitializeComponent();
        }

        public delegate void UusiAuto(int luku);
        public UusiAuto kisuli;

        

        


        private void Laske_Click(object sender, EventArgs e)
        {
            automaara++;
            numberTextBox1.Text = pLaskuri.ToString();
            if (kisuli != null) kisuli(pLaskuri);
          //  Laske.Click += new System.EventHandler(kisuli);
            
            
        }



    }
}
