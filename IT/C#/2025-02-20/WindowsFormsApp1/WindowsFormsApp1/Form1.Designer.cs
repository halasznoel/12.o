
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
            this.megyék = new System.Windows.Forms.ListBox();
            this.városok = new System.Windows.Forms.ListBox();
            this.sdf = new System.Windows.Forms.Label();
            this.asdffd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // megyék
            // 
            this.megyék.FormattingEnabled = true;
            this.megyék.Location = new System.Drawing.Point(56, 50);
            this.megyék.Name = "megyék";
            this.megyék.Size = new System.Drawing.Size(176, 342);
            this.megyék.TabIndex = 0;
            this.megyék.SelectedIndexChanged += new System.EventHandler(this.megyék_SelectedIndexChanged);
            // 
            // városok
            // 
            this.városok.FormattingEnabled = true;
            this.városok.Location = new System.Drawing.Point(339, 50);
            this.városok.Name = "városok";
            this.városok.Size = new System.Drawing.Size(208, 342);
            this.városok.TabIndex = 1;
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Location = new System.Drawing.Point(53, 23);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(45, 13);
            this.sdf.TabIndex = 2;
            this.sdf.Text = "Megyék";
            // 
            // asdffd
            // 
            this.asdffd.AutoSize = true;
            this.asdffd.Location = new System.Drawing.Point(336, 23);
            this.asdffd.Name = "asdffd";
            this.asdffd.Size = new System.Drawing.Size(46, 13);
            this.asdffd.TabIndex = 3;
            this.asdffd.Text = "Városok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.asdffd);
            this.Controls.Add(this.sdf);
            this.Controls.Add(this.városok);
            this.Controls.Add(this.megyék);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox megyék;
        private System.Windows.Forms.ListBox városok;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.Label asdffd;
    }
}

