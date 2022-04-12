using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; //ekledik

namespace ButonOlusturmam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yuvarlakbutton ybuton = new yuvarlakbutton(); //butondan kalıtım aldığımız için geliyor
            ybuton.Size = new Size(200, 200); //butonumuzun boyutları
            ybuton.Location = new System.Drawing.Point(50, 50); //konumu
            ybuton.BackColor = Color.Yellow;
            ybuton.FlatAppearance.BorderSize = 0; //kenar boslugu
            ybuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat; //üzerine gelince sekli degismesin
            ybuton.FlatAppearance.BorderColor = Color.Red; //kenar rengi
            ybuton.Text = "BUTON1";
            ybuton.ForeColor = Color.DeepSkyBlue; //textin rengi
            this.Controls.Add(ybuton); //bütün kontrol
        }
    }
    public class yuvarlakbutton:Button // dock buton sabit ler
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);  //
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(Point.Empty, this.Size)); //2d kütüphanenin araçlarını ekledik
            this.Region = new Region(gp);  //yeni bir bolge olusturdu           
        }
 
    }
}
