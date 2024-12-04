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

        private void kepvalasztogomb_Click(object sender, EventArgs e)
        {
            kepvalasztodialog.ShowDialog();
            kepdoboz.Load(kepvalasztodialog.FileName);
            elozmenyek.Items.Add(kepvalasztodialog.FileName);
        }

        private void elozmenyek_SelectedIndexChanged(object sender, EventArgs e)
        {
            kepdoboz.Load(elozmenyek.SelectedItem.ToString());
        }
    }
}
