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

namespace haromszoges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            string hsz = listBox1.SelectedItem.ToString();

            string[] darabok = hsz.Split(',');

            int a, b, c;
            a = int.Parse(darabok[0]);
            b = int.Parse(darabok[1]);
            c = int.Parse(darabok[2]);

            if (a + b > c && a + c > b && b + c > a)
            {
                listBox2.Items.Add("Szerkeszthető háromszög");
            }
            else
            {
                listBox2.Items.Add("Nem szerkeszthető háromszög");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sorok = File.ReadAllLines("data.txt", Encoding.UTF8);
            foreach (var sor in sorok)
            {
                listBox1.Items.Add(sor);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
