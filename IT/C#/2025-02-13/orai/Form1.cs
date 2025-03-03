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

namespace orai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sorok = File.ReadAllLines("alakzatok.dat",Encoding.UTF8);
            foreach (var item in sorok)
            {
                bal.Items.Add(item);
            }
        }

        private void bal_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobb.Items.Clear();
            string data = bal.SelectedItem.ToString(); //data-ba kerül az a szöveg amire kattintunk

            string[] pieces = data.Split(' '); //szóköz alapján darabolunk
            float a; //lebegőpontos változók
            float b;
            float c;
            float d;
            string info;
            double T, K;

            if (pieces.Length == 3) //Háromszög ha 3 darab van
            {
                a = float.Parse(pieces[0]);
                b = float.Parse(pieces[1]);
                c = float.Parse(pieces[2]);

                if (a == b && b == c)
                    info = "Szabályos háromszög";
                else if (a == b || a == c || b == c)
                    info = "Szabályos háromszög";
                else
                    info = "Háromszög";
                K = a + b + c;
                float s = (a + b + c) / 2;
                T = Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                jobb.Items.Add(info);
                jobb.Items.Add($"T:{T} K:{K}");

            }
            else if(pieces.Length == 4) //Négyzet ha 4 darab van
            {
                a = float.Parse(pieces[0]);
                b = float.Parse(pieces[1]);
                c = float.Parse(pieces[2]);
                d = float.Parse(pieces[3]);
                K = a + b + c + d;
                if (a == b && b == c && c == d)
                {
                    info = "Négyzet";
                    T = a * a;
                }
                else
                {
                    info = "Téglalap";
                    if (a != b)
                        T = a * b;
                    else
                        T = a * c;
                }

                jobb.Items.Add(info);
                jobb.Items.Add($"T:{T} K:{K}");
            }
        }
    }
}
