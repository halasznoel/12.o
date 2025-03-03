
namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bal
            // 
            this.bal.FormattingEnabled = true;
            this.bal.Location = new System.Drawing.Point(23, 46);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(180, 316);
            this.bal.TabIndex = 0;
            this.bal.SelectedIndexChanged += new System.EventHandler(this.bal_SelectedIndexChanged);
            // 
            // jobb
            // 
            this.jobb.FormattingEnabled = true;
            this.jobb.Location = new System.Drawing.Point(261, 46);
            this.jobb.Name = "jobb";
            this.jobb.Size = new System.Drawing.Size(180, 316);
            this.jobb.TabIndex = 1;
            this.jobb.SelectedIndexChanged += new System.EventHandler(this.jobb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Megyék";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Városok";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(478, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobb);
            this.Controls.Add(this.bal);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox bal;
        private System.Windows.Forms.ListBox jobb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

