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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resimPath;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";
            openFileDialog1.Filter = "Jpeg Dosyası(*.jpg)|*.jpg|Gif Dosyası(*.gif)|Png Dosyası(*.png)";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //resmimizi filestream metoduyla okuma moduna açıyoruz
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            //sql connection ve kayıt işlemi
            SqlConnection bag = new SqlConnection(@"Data Source = DESKTOP-M1LC3HT; Initial Catalog = HEPSIBIZDE; Integrated Security = True");
            SqlCommand kmt = new SqlCommand("insert into Resim(Resim)values(@image)", bag);
            kmt.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
            try
            {
                bag.Open();
                kmt.ExecuteNonQuery();
                MessageBox.Show("VERİTABANINA KAYIT YAPILDI!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
    ;       }
            finally
            {
                bag.Close();
            }
        }
    }
}
