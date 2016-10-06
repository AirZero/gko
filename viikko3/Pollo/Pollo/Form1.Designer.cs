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
            this.polloTulostin1 = new PolloTulostin.PolloTulostin();
            this.polloKuvastin1 = new PolloKuvastin.PolloKuvastin();
            this.SuspendLayout();
            // 
            // polloTulostin1
            // 
            this.polloTulostin1.Location = new System.Drawing.Point(12, 229);
            this.polloTulostin1.Name = "polloTulostin1";
            this.polloTulostin1.Size = new System.Drawing.Size(180, 21);
            this.polloTulostin1.TabIndex = 1;
            this.polloTulostin1.teksti = "Jee jee jee jee";
            // 
            // polloKuvastin1
            // 
            this.polloKuvastin1.Location = new System.Drawing.Point(71, 50);
            this.polloKuvastin1.Name = "polloKuvastin1";
            this.polloKuvastin1.Size = new System.Drawing.Size(150, 150);
            this.polloKuvastin1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.polloKuvastin1);
            this.Controls.Add(this.polloTulostin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PolloTulostin.PolloTulostin polloTulostin1;
        private PolloKuvastin.PolloKuvastin polloKuvastin1;
    }
}

