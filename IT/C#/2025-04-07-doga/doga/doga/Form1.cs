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

namespace doga
{
    public partial class Form1 : Form
    {
        string currentfilename;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string fname = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(fname);
                currentfilename = fname;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            };
        }

        private void mentésMáskéntToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.ShowDialog();
            string place = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(place, false, Encoding.UTF8);
            sw.Write(textBox1.Text);
            sw.Close();
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter SW = new StreamWriter(currentfilename, false, Encoding.UTF8);
            SW.Write(textBox1.Text);
            SW.Close();
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
