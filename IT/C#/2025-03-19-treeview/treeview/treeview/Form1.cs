using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tv.Nodes.Add("növények");

            tv.Nodes[0].Nodes.Add("nyitvatermők");
            tv.Nodes[0].Nodes[0].Nodes.Add("fenyő");
            tv.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("erdei fenyő");
            tv.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("lucfenyő");

            tv.Nodes[0].Nodes.Add("zárvatermők");
            tv.Nodes[0].Nodes[1].Nodes.Add("orgona");
            tv.Nodes[0].Nodes[1].Nodes.Add("barack");
            tv.Nodes[0].Nodes[1].Nodes.Add("sóska");




            tv.Nodes.Add("állatok");

            tv.Nodes[1].Nodes.Add("emlősök");
            tv.Nodes[1].Nodes[0].Nodes.Add("macska");
            tv.Nodes[1].Nodes[0].Nodes.Add("kutya");
            tv.Nodes[1].Nodes[0].Nodes.Add("róka");

            tv.Nodes[1].Nodes.Add("madarak");
            tv.Nodes[1].Nodes[1].Nodes.Add("tyúk");
            tv.Nodes[1].Nodes[1].Nodes.Add("liba");
            tv.Nodes[1].Nodes[1].Nodes[1].Nodes.Add("okos liba");
            tv.Nodes[1].Nodes[1].Nodes[1].Nodes.Add("buta liba");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tv.SelectedNode.Remove();
        }
    }
}
