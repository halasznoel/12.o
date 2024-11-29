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

        private void képválasztógomb_Click(object sender, EventArgs e)
        {
            képválasztó.ShowDialog();
            kép.Load(képválasztó.FileName);
            előzmények.Items.Add(képválasztó.FileName);
        }

        private void előzmények_SelectedIndexChanged(object sender, EventArgs e)
        {
            kép.Load(előzmények.SelectedItem.ToString());
        }
    }
}
