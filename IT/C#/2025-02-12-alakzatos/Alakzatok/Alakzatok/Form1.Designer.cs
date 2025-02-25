
namespace Alakzatok
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
            this.bal = new System.Windows.Forms.ListBox();
            this.jobb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ujalakzat = new System.Windows.Forms.TextBox();
            this.felvesz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bal
            // 
            this.bal.FormattingEnabled = true;
            this.bal.Location = new System.Drawing.Point(50, 33);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(257, 368);
            this.bal.TabIndex = 0;
            this.bal.SelectedIndexChanged += new System.EventHandler(this.bal_SelectedIndexChanged);
            // 
            // jobb
            // 
            this.jobb.FormattingEnabled = true;
            this.jobb.Location = new System.Drawing.Point(391, 33);
            this.jobb.Name = "jobb";
            this.jobb.Size = new System.Drawing.Size(257, 368);
            this.jobb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alakzat adatai";
            // 
            // ujalakzat
            // 
            this.ujalakzat.Location = new System.Drawing.Point(155, 477);
            this.ujalakzat.Name = "ujalakzat";
            this.ujalakzat.Size = new System.Drawing.Size(163, 20);
            this.ujalakzat.TabIndex = 3;
            // 
            // felvesz
            // 
            this.felvesz.Location = new System.Drawing.Point(374, 475);
            this.felvesz.Name = "felvesz";
            this.felvesz.Size = new System.Drawing.Size(75, 23);
            this.felvesz.TabIndex = 4;
            this.felvesz.TabStop = false;
            this.felvesz.Text = "Felvesz";
            this.felvesz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 564);
            this.Controls.Add(this.felvesz);
            this.Controls.Add(this.ujalakzat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobb);
            this.Controls.Add(this.bal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bal;
        private System.Windows.Forms.ListBox jobb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ujalakzat;
        private System.Windows.Forms.Button felvesz;
    }
}

