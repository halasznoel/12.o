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

namespace _01_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sorok = File.ReadAllLines("húsárak.txt", Encoding.UTF8);
            foreach (string sor in sorok)
            {
                string[] darabok = sor.Split(':');
                if (darabok[0] == "alapár")
                    alapár.Text = darabok[1];
                else if(darabok[0] == "csirke")
                    csirkeprice.Text = darabok[1];
                else if (darabok[0] == "disznó")
                    disznoprice.Text = darabok[1];
                else if (darabok[0] == "marha")
                    marhaprice.Text = darabok[1];
            }
        }

    }
}
