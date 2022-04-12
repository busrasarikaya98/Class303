using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace _14022022_adonetgiris
{
    public partial class resimekleme : Form
    {
        public resimekleme()
        {
            InitializeComponent();
        }
        string resimPath;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "RESİM AÇ";
            openFileDialog1.Filter = "Jpeg Dosyası(*.jpg)|*jpg.|Gif Dosyası(*.gif)|Png Dosyası(*.png)|Tif Dosyası(*.tif)|*.tif";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }
        }
    }
}
