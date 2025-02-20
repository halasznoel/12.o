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
        string[] megyeváros = File.ReadAllLines("varosmegye.txt", Encoding.UTF8);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in megyeváros)
            {
                string[] darabok = item.Split();
                if (!bal.Items.Contains(darabok[1]))
                {
                    bal.Items.Add(darabok[1]);
                }
            }
        }

        private void bal_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobb.Items.Clear();
            string megye = bal.SelectedItem.ToString();
            foreach (var item in megyeváros)
            {
                string[] darabok = item.Split();
                if (darabok[1] == megye)
                {
                    jobb.Items.Add(darabok[0]);
                }
            }

        }

        private void jobb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
