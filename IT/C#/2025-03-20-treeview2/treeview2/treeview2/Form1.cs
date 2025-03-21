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

namespace treeview2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] rows = File.ReadAllLines("strukt.dat",Encoding.UTF8);
            for (int i = 1; i < rows.Length; i++)
            {
                string[] pieces = rows[i].Split('\t');
                if (pieces[0] == "0")
                {
                    tv.Nodes.Add(pieces[1], pieces[2]);
                }
                else
                {
                    TreeNode[] találatok = tv.Nodes.Find(pieces[0],true);
                    találatok[0].Nodes.Add(pieces[1], pieces[2]);
                }
            }
        }
    }
}
