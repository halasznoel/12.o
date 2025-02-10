using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2025_02_10
{
    public partial class Form1 : Form
    {
        string[] sorok;
        int pos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Kitölt(int pos)
        {
            string[] pieces = sorok[pos].Split(';');
            string[] névpieces = pieces[0].Split(' ');
            vezeteknev.Text = névpieces[0];
            keresztnev.Text = névpieces[1];
            varos.Text = pieces[1];
            fizetes.Text = pieces[2];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sorok = File.ReadAllLines("data.txt",Encoding.UTF8);
            Kitölt(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void eleje_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                Kitölt(pos);
            }
        }

        private void vége_Click(object sender, EventArgs e)
        {
            if (pos < sorok.Count() - 1)
            {
                pos++;
                Kitölt(pos);
            }

        }
    }
}
