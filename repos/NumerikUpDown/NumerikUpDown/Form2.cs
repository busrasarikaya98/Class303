using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerikUpDown
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       private void button1_Click(object sender, EventArgs e)
       {
            Bitmap photo = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gr = Graphics.FromImage(photo);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(photo.Width, photo.Height));
            pictureBox1.Image = photo;
       }
    }
}
