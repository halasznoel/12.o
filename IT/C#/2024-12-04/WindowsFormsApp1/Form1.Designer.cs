
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
            this.kepvalasztogomb = new System.Windows.Forms.Button();
            this.kepdoboz = new System.Windows.Forms.PictureBox();
            this.kepvalasztodialog = new System.Windows.Forms.OpenFileDialog();
            this.elozmenyek = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.kepdoboz)).BeginInit();
            this.SuspendLayout();
            // 
            // kepvalasztogomb
            // 
            this.kepvalasztogomb.Location = new System.Drawing.Point(552, 326);
            this.kepvalasztogomb.Name = "kepvalasztogomb";
            this.kepvalasztogomb.Size = new System.Drawing.Size(75, 23);
            this.kepvalasztogomb.TabIndex = 0;
            this.kepvalasztogomb.Text = "Kép kiválasztása";
            this.kepvalasztogomb.UseVisualStyleBackColor = true;
            this.kepvalasztogomb.Click += new System.EventHandler(this.kepvalasztogomb_Click);
            // 
            // kepdoboz
            // 
            this.kepdoboz.Location = new System.Drawing.Point(433, 31);
            this.kepdoboz.Name = "kepdoboz";
            this.kepdoboz.Size = new System.Drawing.Size(318, 260);
            this.kepdoboz.TabIndex = 1;
            this.kepdoboz.TabStop = false;
            // 
            // kepvalasztodialog
            // 
            this.kepvalasztodialog.FileName = "kepvalasztodialog";
            // 
            // elozmenyek
            // 
            this.elozmenyek.FormattingEnabled = true;
            this.elozmenyek.Location = new System.Drawing.Point(46, 35);
            this.elozmenyek.Name = "elozmenyek";
            this.elozmenyek.Size = new System.Drawing.Size(330, 251);
            this.elozmenyek.TabIndex = 2;
            this.elozmenyek.SelectedIndexChanged += new System.EventHandler(this.elozmenyek_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elozmenyek);
            this.Controls.Add(this.kepdoboz);
            this.Controls.Add(this.kepvalasztogomb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kepdoboz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kepvalasztogomb;
        private System.Windows.Forms.PictureBox kepdoboz;
        private System.Windows.Forms.OpenFileDialog kepvalasztodialog;
        private System.Windows.Forms.ListBox elozmenyek;
    }
}

