namespace Pollo
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.polloTulostin1 = new PolloTulostin.PolloTulostin();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // polloTulostin1
            // 
            this.polloTulostin1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.polloTulostin1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.polloTulostin1.BackColor = System.Drawing.Color.Black;
            this.polloTulostin1.Location = new System.Drawing.Point(-1, 416);
            this.polloTulostin1.Name = "polloTulostin1";
            this.polloTulostin1.Size = new System.Drawing.Size(577, 64);
            this.polloTulostin1.TabIndex = 1;
            this.polloTulostin1.teksti = "moi hei jee";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(575, 480);
            this.Controls.Add(this.polloTulostin1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PolloTulostin.PolloTulostin polloTulostin1;
        private System.Windows.Forms.Timer timer1;
    }
}

