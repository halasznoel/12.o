using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doit_Click(object sender, EventArgs e)
        {
            double szam = double.Parse(number.Text.ToString());
            double szam_egeszresze = Math.Truncate(szam);

            if (egész.Checked)
            {
               
                if (szam == szam_egeszresze)
                    eredmény.Text = "Egész szám";
                else
                    eredmény.Text = "Nem egész szám";

            }
            else if (páros.Checked){
                if (szam == szam_egeszresze)
                    if (szam % 2 == 0)
                    {
                        eredmény.Text = "Páros";
                    }
                    else
                    {
                        eredmény.Text = "Páratlan";
                    }
                
                else
                    eredmény.Text = "Csak egész számra van értelme a párosságnak!";
            }
            else if (osztókszáma.Checked)
            {
                int osztók = 0;
                if (szam == szam_egeszresze)
                {
                    for (int i = 1; i <= szam; i++)
                    {
                        if (szam % i == 0)
                        {
                            osztók++;
                        }
                    }
                    eredmény.Text = osztók.ToString();
                } 
                else
                    eredmény.Text = "Csak egész számmal dolgozom!";
            }
            else if (prím.Checked)
            {
                int osztók = 0;
                if (szam == szam_egeszresze)
                {
                    for (int i = 1; i <= szam; i++)
                    {
                        if (szam % i == 0)
                        {
                            osztók++;
                        }
                    }
                    if (osztók == 2)
                    {
                        eredmény.Text = "Prím";
                    }
                    else
                    {
                        eredmény.Text = "Nem prím";
                    }
                }
                else
                    eredmény.Text = "Csak egész számmal dolgozom!";
            }
            else if (tökéletes.Checked)
            {
                if (szam == szam_egeszresze)
                {
                    int osztsum = 0;
                    for (int i = 1; i < szam; i++)
                    {
                        if (szam % i == 0)
                        {
                            osztsum += i;
                        }
                    }
                    if (szam == osztsum)
                    {
                        eredmény.Text = "Tökéletes szám";
                    }
                    else
                    {
                        eredmény.Text = "Nem tökéletes szám";
                    }
                }
                else
                    eredmény.Text = "Csak egész számmal dolgozom!";
            }
            else if (négyzetszám.Checked)
            {
                
                if (szam == szam_egeszresze)
                {
                    double gyök = Math.Sqrt(szam);
                    double gyök_egészrész = Math.Truncate(gyök);
                    if(gyök == gyök_egészrész)
                    {
                        eredmény.Text = "Négyzetszám";
                    }
                    else
                    {
                        eredmény.Text = "Nem négyzetszám";
                    }
                }
                else
                    eredmény.Text = "Csak egész számmal dolgozom!";
            }
        }
    }
}
