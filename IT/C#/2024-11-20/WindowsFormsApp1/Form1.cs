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
        List<string> towns = new List<string> { "Butapest", "Kardoskút", "Sopron", "Veszprém" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //towns_combo.Items.Add(a város)
            foreach (var item in towns)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
