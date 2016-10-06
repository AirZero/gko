using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberTextBox
{
    public partial class NumberTextBox: TextBox
    {
        double min = 10;
        double max = 150;

        [Description("Minimi"),
        BrowsableAttribute(true),
        Category("arvo"),
        DefaultValue(0)]
        public double Min
        {
            get { return min; }
            set { min = value; }
        }

        [Description("Maksimi"),
        BrowsableAttribute(true),
        Category("arvo"),
        DefaultValue(15)]
        public double Max
        {
            get { return max; }
            set { max = value; }
        }

/*        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
            if ( min.GetType() != typeof(System.Int16) )
                throw new ArgumentException("value must be of type Int16.", "value");

        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
        }
  */      


        public NumberTextBox()
        {
            InitializeComponent();
        }

        private void NumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            double luku = Double.Parse(this.Text);
            try
            {
                if (luku > max || luku < min) e.Cancel = true;
            }
            catch
            {
                e.Cancel = true;
                
            }
            if (e.Cancel) { errorProvider1.SetError(this, "Luku liian suuri tai pieni"); };
        }

        private void NumberTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(this, "");
        }
            
        }

      
    }

