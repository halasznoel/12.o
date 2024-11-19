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

        private void Program_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Na mi van!");
            float a_value = float.Parse(a.Text);
            float b_value = float.Parse(b.Text);
            int melyikmuv = muvelet.SelectedIndex;

            if(melyikmuv == -1)
                MessageBox.Show(muvelet.Items[melyikmuv].ToString());
            else
            {
                string muv = muvelet.Items[melyikmuv].ToString();
                //muv változóban * vagy / vagy - vagy + valamelyike lesz
                switch(muv)
                {
                    case "*":
                        result.Text = (a_value * b_value).ToString();
                        break;
                    case "/":
                        result.Text = (a_value / b_value).ToString();
                        break;
                    case "+":
                        result.Text = (a_value + b_value).ToString();
                        break;
                    case "-":
                        result.Text = (a_value - b_value).ToString();
                        break;
                }
            }
        }
    }
}
