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

namespace help
{
    public partial class Form1 : Form
    {
        List<string> nevek = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void osszes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nev_TextChanged(object sender, EventArgs e)
        {

        }

        private void felvesz_Click(object sender, EventArgs e)
        {
            nevek.Add(nev.Text.ToString());
            nevek.Count();
        }

        private void utolso_Click(object sender, EventArgs e)
        {
            nevek.RemoveAt();
        }
    }
}
