﻿
namespace _2025_02_10
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
            this.vezeteknev = new System.Windows.Forms.TextBox();
            this.keresztnev = new System.Windows.Forms.TextBox();
            this.varos = new System.Windows.Forms.TextBox();
            this.fizetes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eleje = new System.Windows.Forms.Button();
            this.vége = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vezeteknev
            // 
            this.vezeteknev.Location = new System.Drawing.Point(167, 54);
            this.vezeteknev.Name = "vezeteknev";
            this.vezeteknev.Size = new System.Drawing.Size(246, 20);
            this.vezeteknev.TabIndex = 0;
            // 
            // keresztnev
            // 
            this.keresztnev.Location = new System.Drawing.Point(167, 98);
            this.keresztnev.Name = "keresztnev";
            this.keresztnev.Size = new System.Drawing.Size(246, 20);
            this.keresztnev.TabIndex = 1;
            // 
            // varos
            // 
            this.varos.Location = new System.Drawing.Point(167, 140);
            this.varos.Name = "varos";
            this.varos.Size = new System.Drawing.Size(246, 20);
            this.varos.TabIndex = 2;
            // 
            // fizetes
            // 
            this.fizetes.Location = new System.Drawing.Point(167, 179);
            this.fizetes.Name = "fizetes";
            this.fizetes.Size = new System.Drawing.Size(246, 20);
            this.fizetes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vezetéknév";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keresztnév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Város";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fizetés";
            // 
            // eleje
            // 
            this.eleje.Location = new System.Drawing.Point(194, 233);
            this.eleje.Name = "eleje";
            this.eleje.Size = new System.Drawing.Size(75, 23);
            this.eleje.TabIndex = 8;
            this.eleje.Text = "Eleje felé";
            this.eleje.UseVisualStyleBackColor = true;
            this.eleje.Click += new System.EventHandler(this.eleje_Click);
            // 
            // vége
            // 
            this.vége.Location = new System.Drawing.Point(305, 233);
            this.vége.Name = "vége";
            this.vége.Size = new System.Drawing.Size(75, 23);
            this.vége.TabIndex = 9;
            this.vége.Text = "Vége felé";
            this.vége.UseVisualStyleBackColor = true;
            this.vége.Click += new System.EventHandler(this.vége_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vége);
            this.Controls.Add(this.eleje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fizetes);
            this.Controls.Add(this.varos);
            this.Controls.Add(this.keresztnev);
            this.Controls.Add(this.vezeteknev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vezeteknev;
        private System.Windows.Forms.TextBox keresztnev;
        private System.Windows.Forms.TextBox varos;
        private System.Windows.Forms.TextBox fizetes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button eleje;
        private System.Windows.Forms.Button vége;
    }
}

