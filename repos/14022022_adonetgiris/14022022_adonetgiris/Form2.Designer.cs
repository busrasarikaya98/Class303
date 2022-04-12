
namespace _14022022_adonetgiris
{
    partial class Urunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NudFiyat = new System.Windows.Forms.NumericUpDown();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSPekle = new System.Windows.Forms.Button();
            this.btnSPguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(116, 38);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "UrunAdi";
            // 
            // NudFiyat
            // 
            this.NudFiyat.Location = new System.Drawing.Point(295, 41);
            this.NudFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudFiyat.Name = "NudFiyat";
            this.NudFiyat.Size = new System.Drawing.Size(120, 22);
            this.NudFiyat.TabIndex = 3;
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(529, 39);
            this.nudStok.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(120, 22);
            this.nudStok.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(126, 106);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btn_kategori
            // 
            this.btn_kategori.Location = new System.Drawing.Point(567, 106);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(157, 23);
            this.btn_kategori.TabIndex = 5;
            this.btn_kategori.Text = "KATEGORİLER";
            this.btn_kategori.UseVisualStyleBackColor = true;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(336, 105);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(103, 24);
            this.btnguncelle.TabIndex = 6;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 28);
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // btnSPekle
            // 
            this.btnSPekle.Location = new System.Drawing.Point(95, 152);
            this.btnSPekle.Name = "btnSPekle";
            this.btnSPekle.Size = new System.Drawing.Size(141, 24);
            this.btnSPekle.TabIndex = 8;
            this.btnSPekle.Text = "SP ile EKLE";
            this.btnSPekle.UseVisualStyleBackColor = true;
            this.btnSPekle.Click += new System.EventHandler(this.btnSPekle_Click);
            // 
            // btnSPguncelle
            // 
            this.btnSPguncelle.Location = new System.Drawing.Point(295, 152);
            this.btnSPguncelle.Name = "btnSPguncelle";
            this.btnSPguncelle.Size = new System.Drawing.Size(175, 24);
            this.btnSPguncelle.TabIndex = 9;
            this.btnSPguncelle.Text = "SP ile GÜNCELLE";
            this.btnSPguncelle.UseVisualStyleBackColor = true;
            this.btnSPguncelle.Click += new System.EventHandler(this.btnSPguncelle_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 615);
            this.Controls.Add(this.btnSPguncelle);
            this.Controls.Add(this.btnSPekle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btn_kategori);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudStok);
            this.Controls.Add(this.NudFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudFiyat;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btn_kategori;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
        private System.Windows.Forms.Button btnSPekle;
        private System.Windows.Forms.Button btnSPguncelle;
    }
}