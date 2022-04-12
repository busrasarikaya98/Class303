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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int b1;
        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode ekle = new TreeNode("MASAÜSTÜ");
            treeView1.Nodes.Add(ekle);
            ekle = new TreeNode("İNDİRİLENLER");
            treeView1.Nodes.Add(ekle);
            TreeNode child = new TreeNode("RESİMLER");
            TreeNode schild = new TreeNode("FAVORİLER");
            TreeNode schild1 = new TreeNode("SON ÇALINANLAR");
            TreeNode[] array2 = { schild, schild1 };
            TreeNode child1 = new TreeNode("MÜZİKLER",array2);
            TreeNode[] array = { child, child1};
            ekle = new TreeNode("BELGELER",array);
            treeView1.Nodes.Add(ekle);
            b1++;
            {
                if (b1 == 2)
                {
                    button1.close
                }
                    
            }
            
        }
    }
}
