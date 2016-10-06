namespace AutoLaskuri
{
    partial class Autolaskuri
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberTextBox1 = new NumberTextBox.NumberTextBox();
            this.Laske = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.Enabled = false;
            this.numberTextBox1.Location = new System.Drawing.Point(3, 3);
            this.numberTextBox1.Max = 150D;
            this.numberTextBox1.Min = 10D;
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox1.TabIndex = 0;
            // 
            // Laske
            // 
            this.Laske.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Laske.Location = new System.Drawing.Point(28, 29);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(75, 23);
            this.Laske.TabIndex = 1;
            this.Laske.Text = "Laske";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // Autolaskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Laske);
            this.Controls.Add(this.numberTextBox1);
            this.Name = "Autolaskuri";
            this.Size = new System.Drawing.Size(106, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberTextBox.NumberTextBox numberTextBox1;
        private System.Windows.Forms.Button Laske;
    }
}
