
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésMáskéntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beszúrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rajzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.beszúrásToolStripMenuItem,
            this.rajzToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.megnyitásToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.mentésMáskéntToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            // 
            // mentésMáskéntToolStripMenuItem
            // 
            this.mentésMáskéntToolStripMenuItem.Name = "mentésMáskéntToolStripMenuItem";
            this.mentésMáskéntToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentésMáskéntToolStripMenuItem.Text = "Mentés másként";
            this.mentésMáskéntToolStripMenuItem.Click += new System.EventHandler(this.mentésMáskéntToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // beszúrásToolStripMenuItem
            // 
            this.beszúrásToolStripMenuItem.Name = "beszúrásToolStripMenuItem";
            this.beszúrásToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.beszúrásToolStripMenuItem.Text = "Beszúrás";
            // 
            // rajzToolStripMenuItem
            // 
            this.rajzToolStripMenuItem.Name = "rajzToolStripMenuItem";
            this.rajzToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.rajzToolStripMenuItem.Text = "Rajz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 290);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsFormsApp1.Properties.Resources.ikon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésMáskéntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beszúrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rajzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

