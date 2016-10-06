namespace Laskuri
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
            this.Laske = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberTextBox2 = new NumberTextBox.NumberTextBox();
            this.numberTextBox1 = new NumberTextBox.NumberTextBox();
            this.SuspendLayout();
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(198, 218);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(75, 23);
            this.Laske.TabIndex = 1;
            this.Laske.Text = "Laske";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nopeus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ajetut kilometrit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Käytetty aika";
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Location = new System.Drawing.Point(117, 56);
            this.numberTextBox2.Max = 150D;
            this.numberTextBox2.Min = 10D;
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(126, 20);
            this.numberTextBox2.TabIndex = 2;
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.Location = new System.Drawing.Point(117, 30);
            this.numberTextBox1.Max = 150D;
            this.numberTextBox1.Min = 10D;
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(126, 20);
            this.numberTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.Laske);
            this.Controls.Add(this.numberTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberTextBox.NumberTextBox numberTextBox1;
        private NumberTextBox.NumberTextBox numberTextBox2;
        private System.Windows.Forms.Button Laske;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

