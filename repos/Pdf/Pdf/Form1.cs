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

namespace Pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfac = new OpenFileDialog();
            pdfac.Title = "PDF AÇ";
            pdfac.Filter = "Pdf Dosyaları(*.pdf)|*pdf";
            if (pdfac.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = pdfac.FileName;
                axAcroPDF1.LoadFile(pdfac.FileName);
            }
        }
    }
}
