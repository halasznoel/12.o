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

namespace _02_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sorok = File.ReadAllLines("alakzatok.dat", Encoding.UTF8);
            foreach (var sor in sorok)
            {
                listBox1.Items.Add(sor);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            string hsz = listBox1.SelectedItem.ToString();

            string[] darabok = hsz.Split(' ');

            int a, b, c;
            a = int.Parse(darabok[0]);
            b = int.Parse(darabok[1]);
            c = int.Parse(darabok[2]);

            if(darabok.Length < 4)
            {
                listBox2.Items.Add("Háromszög");
                listBox2.Items.Add("Terület:");
                listBox2.Items.Add(a * b * c);
                listBox2.Items.Add("Kerület:");
                listBox2.Items.Add(a + b + c);
            }
            else
            {
                listBox2.Items.Add("Négyzet");
                listBox2.Items.Add("Terület:");
                listBox2.Items.Add(a * b * c);
                listBox2.Items.Add("Kerület:");
                listBox2.Items.Add(a + b + c);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
