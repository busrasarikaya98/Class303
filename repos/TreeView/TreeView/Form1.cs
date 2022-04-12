using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode ekle = new TreeNode("Windows"); //form kısmında degilde burada da yazabilirz
            treeView2.Nodes.Add(ekle);
            ekle = new TreeNode("Linux");
            treeView2.Nodes.Add(ekle);
            TreeNode child = new TreeNode("C#");
            TreeNode child1 = new TreeNode("Visual Basic");
            TreeNode child2 = new TreeNode("ASP .NET");
            TreeNode[] array = new TreeNode[] { child, child1, child2 }; //dizi olusturduk
            ekle = new TreeNode("Programlama Dilleri", array); //array ile dizideki elemanları yazdırdık
            treeView2.Nodes.Add(ekle); //
        }
    }
}
