
namespace help
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button felvesz;
            this.utolso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.osszes = new System.Windows.Forms.TextBox();
            this.nev = new System.Windows.Forms.TextBox();
            felvesz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // felvesz
            // 
            felvesz.Location = new System.Drawing.Point(139, 269);
            felvesz.Name = "felvesz";
            felvesz.Size = new System.Drawing.Size(75, 23);
            felvesz.TabIndex = 0;
            felvesz.Text = "Felvesz";
            felvesz.UseVisualStyleBackColor = true;
            felvesz.Click += new System.EventHandler(this.felvesz_Click);
            // 
            // utolso
            // 
            this.utolso.Location = new System.Drawing.Point(318, 269);
            this.utolso.Name = "utolso";
            this.utolso.Size = new System.Drawing.Size(122, 23);
            this.utolso.TabIndex = 1;
            this.utolso.Text = "Utolsó törlése";
            this.utolso.UseVisualStyleBackColor = true;
            this.utolso.Click += new System.EventHandler(this.utolso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Összes név:";
            // 
            // osszes
            // 
            this.osszes.Location = new System.Drawing.Point(131, 88);
            this.osszes.Name = "osszes";
            this.osszes.Size = new System.Drawing.Size(32, 23);
            this.osszes.TabIndex = 4;
            this.osszes.TextChanged += new System.EventHandler(this.osszes_TextChanged);
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(131, 204);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 23);
            this.nev.TabIndex = 5;
            this.nev.TextChanged += new System.EventHandler(this.nev_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.osszes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.utolso);
            this.Controls.Add(felvesz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button utolso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox osszes;
        private System.Windows.Forms.TextBox nev;
    }
}

