
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
            this.kép = new System.Windows.Forms.PictureBox();
            this.képválasztó = new System.Windows.Forms.OpenFileDialog();
            this.képválasztógomb = new System.Windows.Forms.Button();
            this.előzmények = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.kép)).BeginInit();
            this.SuspendLayout();
            // 
            // kép
            // 
            this.kép.Location = new System.Drawing.Point(474, 45);
            this.kép.Name = "kép";
            this.kép.Size = new System.Drawing.Size(547, 469);
            this.kép.TabIndex = 0;
            this.kép.TabStop = false;
            // 
            // képválasztó
            // 
            this.képválasztó.FileName = "openFileDialog1";
            // 
            // képválasztógomb
            // 
            this.képválasztógomb.Location = new System.Drawing.Point(493, 555);
            this.képválasztógomb.Name = "képválasztógomb";
            this.képválasztógomb.Size = new System.Drawing.Size(129, 23);
            this.képválasztógomb.TabIndex = 1;
            this.képválasztógomb.Text = "Kép kiválasztása";
            this.képválasztógomb.UseVisualStyleBackColor = true;
            this.képválasztógomb.Click += new System.EventHandler(this.képválasztógomb_Click);
            // 
            // előzmények
            // 
            this.előzmények.FormattingEnabled = true;
            this.előzmények.Location = new System.Drawing.Point(26, 64);
            this.előzmények.Name = "előzmények";
            this.előzmények.Size = new System.Drawing.Size(423, 394);
            this.előzmények.TabIndex = 2;
            this.előzmények.SelectedIndexChanged += new System.EventHandler(this.előzmények_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 696);
            this.Controls.Add(this.előzmények);
            this.Controls.Add(this.képválasztógomb);
            this.Controls.Add(this.kép);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kép)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kép;
        private System.Windows.Forms.OpenFileDialog képválasztó;
        private System.Windows.Forms.Button képválasztógomb;
        private System.Windows.Forms.ListBox előzmények;
    }
}

