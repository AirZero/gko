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


namespace Techtech
{
    partial class Techtech1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics test = e.Graphics;

            for (int i = 0; i < 10; i++)
            {
                LinearGradientBrush agb =
            new LinearGradientBrush(new Point(i, 0),
                                   new Point(0, ClientSize.Height),
                                   Color.LightBlue,
                                   Color.DarkGreen);
                e.Graphics.FillRectangle(agb, 0, i, ClientSize.Width, 100);

                LinearGradientBrush lgb =
            new LinearGradientBrush(new Point(i * 10, 0),
                                   new Point(0, ClientSize.Height),
                                   Color.DarkGreen,
                                   Color.LightBlue);
                e.Graphics.FillRectangle(lgb, 0, i, ClientSize.Width, 100);
            }
            Invalidate();
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion
    }
}
