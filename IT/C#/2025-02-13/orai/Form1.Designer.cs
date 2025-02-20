
namespace orai
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
            this.label1 = new System.Windows.Forms.Label();
            this.felvesz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.jobb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bal
            // 
            this.bal.FormattingEnabled = true;
            this.bal.Location = new System.Drawing.Point(44, 100);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(258, 186);
            this.bal.TabIndex = 0;
            this.bal.SelectedIndexChanged += new System.EventHandler(this.bal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alakzat adatai";
            // 
            // felvesz
            // 
            this.felvesz.Location = new System.Drawing.Point(304, 360);
            this.felvesz.Name = "felvesz";
            this.felvesz.Size = new System.Drawing.Size(75, 23);
            this.felvesz.TabIndex = 2;
            this.felvesz.Text = "Felvesz";
            this.felvesz.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // jobb
            // 
            this.jobb.FormattingEnabled = true;
            this.jobb.Location = new System.Drawing.Point(376, 100);
            this.jobb.Name = "jobb";
            this.jobb.Size = new System.Drawing.Size(258, 186);
            this.jobb.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jobb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.felvesz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button felvesz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox jobb;
    }
}

