
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.négyzetszám = new System.Windows.Forms.RadioButton();
            this.osztókszáma = new System.Windows.Forms.RadioButton();
            this.páros = new System.Windows.Forms.RadioButton();
            this.tökéletes = new System.Windows.Forms.RadioButton();
            this.prím = new System.Windows.Forms.RadioButton();
            this.egész = new System.Windows.Forms.RadioButton();
            this.number = new System.Windows.Forms.TextBox();
            this.doit = new System.Windows.Forms.Button();
            this.eredmény = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.négyzetszám);
            this.groupBox1.Controls.Add(this.osztókszáma);
            this.groupBox1.Controls.Add(this.páros);
            this.groupBox1.Controls.Add(this.tökéletes);
            this.groupBox1.Controls.Add(this.prím);
            this.groupBox1.Controls.Add(this.egész);
            this.groupBox1.Location = new System.Drawing.Point(40, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mi legyen?";
            // 
            // négyzetszám
            // 
            this.négyzetszám.AutoSize = true;
            this.négyzetszám.Location = new System.Drawing.Point(29, 237);
            this.négyzetszám.Name = "négyzetszám";
            this.négyzetszám.Size = new System.Drawing.Size(88, 17);
            this.négyzetszám.TabIndex = 6;
            this.négyzetszám.TabStop = true;
            this.négyzetszám.Text = "Négyzetszám";
            this.négyzetszám.UseVisualStyleBackColor = true;
            // 
            // osztókszáma
            // 
            this.osztókszáma.AutoSize = true;
            this.osztókszáma.Location = new System.Drawing.Point(29, 117);
            this.osztókszáma.Name = "osztókszáma";
            this.osztókszáma.Size = new System.Drawing.Size(91, 17);
            this.osztókszáma.TabIndex = 5;
            this.osztókszáma.TabStop = true;
            this.osztókszáma.Text = "Osztók száma";
            this.osztókszáma.UseVisualStyleBackColor = true;
            // 
            // páros
            // 
            this.páros.AutoSize = true;
            this.páros.Location = new System.Drawing.Point(29, 81);
            this.páros.Name = "páros";
            this.páros.Size = new System.Drawing.Size(52, 17);
            this.páros.TabIndex = 4;
            this.páros.TabStop = true;
            this.páros.Text = "Páros";
            this.páros.UseVisualStyleBackColor = true;
            // 
            // tökéletes
            // 
            this.tökéletes.AutoSize = true;
            this.tökéletes.Location = new System.Drawing.Point(29, 194);
            this.tökéletes.Name = "tökéletes";
            this.tökéletes.Size = new System.Drawing.Size(72, 17);
            this.tökéletes.TabIndex = 2;
            this.tökéletes.TabStop = true;
            this.tökéletes.Text = "Tökéletes";
            this.tökéletes.UseVisualStyleBackColor = true;
            // 
            // prím
            // 
            this.prím.AutoSize = true;
            this.prím.Location = new System.Drawing.Point(29, 155);
            this.prím.Name = "prím";
            this.prím.Size = new System.Drawing.Size(47, 17);
            this.prím.TabIndex = 1;
            this.prím.TabStop = true;
            this.prím.Text = "Prím";
            this.prím.UseVisualStyleBackColor = true;
            // 
            // egész
            // 
            this.egész.AutoSize = true;
            this.egész.Location = new System.Drawing.Point(29, 45);
            this.egész.Name = "egész";
            this.egész.Size = new System.Drawing.Size(54, 17);
            this.egész.TabIndex = 0;
            this.egész.TabStop = true;
            this.egész.Text = "Egész";
            this.egész.UseVisualStyleBackColor = true;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(385, 85);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(155, 20);
            this.number.TabIndex = 1;
            // 
            // doit
            // 
            this.doit.Location = new System.Drawing.Point(385, 118);
            this.doit.Name = "doit";
            this.doit.Size = new System.Drawing.Size(75, 23);
            this.doit.TabIndex = 2;
            this.doit.Text = "Számolj";
            this.doit.UseVisualStyleBackColor = true;
            this.doit.Click += new System.EventHandler(this.doit_Click);
            // 
            // eredmény
            // 
            this.eredmény.Location = new System.Drawing.Point(385, 160);
            this.eredmény.Name = "eredmény";
            this.eredmény.Size = new System.Drawing.Size(155, 20);
            this.eredmény.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eredmény);
            this.Controls.Add(this.doit);
            this.Controls.Add(this.number);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton osztókszáma;
        private System.Windows.Forms.RadioButton páros;
        private System.Windows.Forms.RadioButton tökéletes;
        private System.Windows.Forms.RadioButton prím;
        private System.Windows.Forms.RadioButton egész;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button doit;
        private System.Windows.Forms.TextBox eredmény;
        private System.Windows.Forms.RadioButton négyzetszám;
    }
}

