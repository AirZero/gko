namespace viikko1
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
            this.buttonLisaaKentta = new System.Windows.Forms.Button();
            this.textBoxSyote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLisaaKentta
            // 
            this.buttonLisaaKentta.Location = new System.Drawing.Point(197, 12);
            this.buttonLisaaKentta.Name = "buttonLisaaKentta";
            this.buttonLisaaKentta.Size = new System.Drawing.Size(75, 23);
            this.buttonLisaaKentta.TabIndex = 0;
            this.buttonLisaaKentta.Text = "&Lisää tekstikenttä";
            this.buttonLisaaKentta.UseVisualStyleBackColor = true;
            // 
            // textBoxSyote
            // 
            this.textBoxSyote.Location = new System.Drawing.Point(49, 12);
            this.textBoxSyote.Name = "textBoxSyote";
            this.textBoxSyote.Size = new System.Drawing.Size(100, 20);
            this.textBoxSyote.TabIndex = 1;
            this.textBoxSyote.TextChanged += new System.EventHandler(this.textBoxSyote_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxSyote);
            this.Controls.Add(this.buttonLisaaKentta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLisaaKentta;
        private System.Windows.Forms.TextBox textBoxSyote;
    }
}

