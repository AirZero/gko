﻿namespace testipenkki
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
            this.autolaskuri3 = new AutoLaskuri.Autolaskuri();
            this.autolaskuri2 = new AutoLaskuri.Autolaskuri();
            this.autolaskuri1 = new AutoLaskuri.Autolaskuri();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autolaskuri3
            // 
            this.autolaskuri3.Location = new System.Drawing.Point(12, 71);
            this.autolaskuri3.Name = "autolaskuri3";
            this.autolaskuri3.Size = new System.Drawing.Size(107, 53);
            this.autolaskuri3.TabIndex = 2;
            // 
            // autolaskuri2
            // 
            this.autolaskuri2.Location = new System.Drawing.Point(125, 12);
            this.autolaskuri2.Name = "autolaskuri2";
            this.autolaskuri2.Size = new System.Drawing.Size(107, 53);
            this.autolaskuri2.TabIndex = 1;
            // 
            // autolaskuri1
            // 
            this.autolaskuri1.Location = new System.Drawing.Point(12, 12);
            this.autolaskuri1.Name = "autolaskuri1";
            this.autolaskuri1.Size = new System.Drawing.Size(107, 53);
            this.autolaskuri1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yhteensä";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autolaskuri3);
            this.Controls.Add(this.autolaskuri2);
            this.Controls.Add(this.autolaskuri1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoLaskuri.Autolaskuri autolaskuri1;
        private AutoLaskuri.Autolaskuri autolaskuri2;
        private AutoLaskuri.Autolaskuri autolaskuri3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

