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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] megyeváros;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            megyeváros = File.ReadAllLines("varosmegye.txt", Encoding.UTF8);

            foreach (var item in megyeváros)
            {
                string[] darabok = item.Split();
                if ( !megyék.Items.Contains(darabok[1])){
                    megyék.Items.Add(darabok[1]);
                }
            }
        }
        private void megyék_SelectedIndexChanged(object sender, EventArgs e)
        {
            városok.Items.Clear();
            string megye = megyék.SelectedItem.ToString();
            foreach (var item in megyeváros)
            {
                string[] darabok = item.Split();
                if (darabok[1] == megye)
                {
                    városok.Items.Add(darabok[0]);
                }
            }
        }
    }
}
