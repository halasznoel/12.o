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

namespace dolgozatocska
{
    public partial class Form1 : Form
    {
        List<int> szamok = new List<int>();
        List<string> szoveg = new List<string>();
        public Form1()
        {
            InitializeComponent();
            string[] olvasas = File.ReadAllLines("adatok.dat"); //File beolvasás
            foreach (var item in olvasas) //Végig olvassuk a fájlt tartalmát a foreachel
            {
                string[] elemek = item.Split(' '); //Szétválasztjuk
                szamok.Add(int.Parse(elemek[0])); //A szám adatok.datból
                szoveg.Add(elemek[1]); //A számhoz tartozó szöveg
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int szam = int.Parse(textBox1.Text);

            try
            {
                for (int i = 0; i < szoveg.Count(); i++) //számozást állítunk fel
                {
                    if (szamok[i] == szam)
                    {
                        listBox1.Items.Add(szoveg[i]);
                    }
                }
            }
            catch { }
        }
    }
}
