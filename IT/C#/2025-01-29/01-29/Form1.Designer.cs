
namespace _01_29
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
            this.marhaprice = new System.Windows.Forms.TextBox();
            this.disznoprice = new System.Windows.Forms.TextBox();
            this.csirkeprice = new System.Windows.Forms.TextBox();
            this.marharadio = new System.Windows.Forms.RadioButton();
            this.disznoradio = new System.Windows.Forms.RadioButton();
            this.csirkeradio = new System.Windows.Forms.RadioButton();
            this.alapár = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.marhaprice);
            this.groupBox1.Controls.Add(this.disznoprice);
            this.groupBox1.Controls.Add(this.csirkeprice);
            this.groupBox1.Controls.Add(this.marharadio);
            this.groupBox1.Controls.Add(this.disznoradio);
            this.groupBox1.Controls.Add(this.csirkeradio);
            this.groupBox1.Location = new System.Drawing.Point(42, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Felár";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // marhaprice
            // 
            this.marhaprice.Location = new System.Drawing.Point(109, 96);
            this.marhaprice.Name = "marhaprice";
            this.marhaprice.Size = new System.Drawing.Size(100, 20);
            this.marhaprice.TabIndex = 5;
            // 
            // disznoprice
            // 
            this.disznoprice.Location = new System.Drawing.Point(109, 63);
            this.disznoprice.Name = "disznoprice";
            this.disznoprice.Size = new System.Drawing.Size(100, 20);
            this.disznoprice.TabIndex = 4;
            // 
            // csirkeprice
            // 
            this.csirkeprice.Location = new System.Drawing.Point(109, 31);
            this.csirkeprice.Name = "csirkeprice";
            this.csirkeprice.Size = new System.Drawing.Size(100, 20);
            this.csirkeprice.TabIndex = 1;
            // 
            // marharadio
            // 
            this.marharadio.AutoSize = true;
            this.marharadio.Location = new System.Drawing.Point(17, 97);
            this.marharadio.Name = "marharadio";
            this.marharadio.Size = new System.Drawing.Size(55, 17);
            this.marharadio.TabIndex = 3;
            this.marharadio.TabStop = true;
            this.marharadio.Text = "Marha";
            this.marharadio.UseVisualStyleBackColor = true;
            // 
            // disznoradio
            // 
            this.disznoradio.AutoSize = true;
            this.disznoradio.Location = new System.Drawing.Point(17, 63);
            this.disznoradio.Name = "disznoradio";
            this.disznoradio.Size = new System.Drawing.Size(57, 17);
            this.disznoradio.TabIndex = 2;
            this.disznoradio.TabStop = true;
            this.disznoradio.Text = "Disznó";
            this.disznoradio.UseVisualStyleBackColor = true;
            // 
            // csirkeradio
            // 
            this.csirkeradio.AutoSize = true;
            this.csirkeradio.Location = new System.Drawing.Point(17, 31);
            this.csirkeradio.Name = "csirkeradio";
            this.csirkeradio.Size = new System.Drawing.Size(54, 17);
            this.csirkeradio.TabIndex = 1;
            this.csirkeradio.TabStop = true;
            this.csirkeradio.Text = "Csirke";
            this.csirkeradio.UseVisualStyleBackColor = true;
            // 
            // alapár
            // 
            this.alapár.Location = new System.Drawing.Point(86, 37);
            this.alapár.Name = "alapár";
            this.alapár.Size = new System.Drawing.Size(100, 20);
            this.alapár.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alapár";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Végösszeg";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(390, 326);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alapár);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rendelés űrlap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox marhaprice;
        private System.Windows.Forms.TextBox disznoprice;
        private System.Windows.Forms.TextBox csirkeprice;
        private System.Windows.Forms.RadioButton marharadio;
        private System.Windows.Forms.RadioButton disznoradio;
        private System.Windows.Forms.RadioButton csirkeradio;
        private System.Windows.Forms.TextBox alapár;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
    }
}

