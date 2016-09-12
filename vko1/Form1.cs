using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viikko1
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

        private void textBoxSyote_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox uusiboksi = new System.Windows.Forms.TextBox();
            uusiboksi.Location = new System.Drawing.Point(110, 40);
            uusiboksi.Size = new System.Drawing.Size(100, 20);
            uusiboksi.TabIndex = 1;
        }
    }
}
