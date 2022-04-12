
namespace MenuStrip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vForVendettaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeGuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parasiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theIrishmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimKurguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thePrestigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puanlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(186, 327);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(313, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 100);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(481, 126);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(119, 100);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "FİLM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "PUAN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.dramToolStripMenuItem,
            this.bilimKurguToolStripMenuItem,
            this.puanlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vForVendettaToolStripMenuItem,
            this.freeGuyToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.aksiyonToolStripMenuItem.Text = "Aksiyon";
            // 
            // vForVendettaToolStripMenuItem
            // 
            this.vForVendettaToolStripMenuItem.Name = "vForVendettaToolStripMenuItem";
            this.vForVendettaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vForVendettaToolStripMenuItem.Text = "V for Vendetta";
            this.vForVendettaToolStripMenuItem.Click += new System.EventHandler(this.vForVendettaToolStripMenuItem_Click);
            // 
            // freeGuyToolStripMenuItem
            // 
            this.freeGuyToolStripMenuItem.Name = "freeGuyToolStripMenuItem";
            this.freeGuyToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.freeGuyToolStripMenuItem.Text = "Free Guy";
            // 
            // dramToolStripMenuItem
            // 
            this.dramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parasiteToolStripMenuItem,
            this.theIrishmanToolStripMenuItem});
            this.dramToolStripMenuItem.Name = "dramToolStripMenuItem";
            this.dramToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.dramToolStripMenuItem.Text = "Dram";
            // 
            // parasiteToolStripMenuItem
            // 
            this.parasiteToolStripMenuItem.Name = "parasiteToolStripMenuItem";
            this.parasiteToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.parasiteToolStripMenuItem.Text = "Parasite";
            // 
            // theIrishmanToolStripMenuItem
            // 
            this.theIrishmanToolStripMenuItem.Name = "theIrishmanToolStripMenuItem";
            this.theIrishmanToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.theIrishmanToolStripMenuItem.Text = "The Irishman";
            // 
            // bilimKurguToolStripMenuItem
            // 
            this.bilimKurguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınceptionToolStripMenuItem,
            this.thePrestigeToolStripMenuItem});
            this.bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            this.bilimKurguToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.bilimKurguToolStripMenuItem.Text = "Bilim kurgu";
            // 
            // ınceptionToolStripMenuItem
            // 
            this.ınceptionToolStripMenuItem.Name = "ınceptionToolStripMenuItem";
            this.ınceptionToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.ınceptionToolStripMenuItem.Text = "Inception";
            // 
            // thePrestigeToolStripMenuItem
            // 
            this.thePrestigeToolStripMenuItem.Name = "thePrestigeToolStripMenuItem";
            this.thePrestigeToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.thePrestigeToolStripMenuItem.Text = "The Prestige";
            // 
            // puanlamaToolStripMenuItem
            // 
            this.puanlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripComboBox2});
            this.puanlamaToolStripMenuItem.Name = "puanlamaToolStripMenuItem";
            this.puanlamaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.puanlamaToolStripMenuItem.Text = "Puanlama";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vForVendettaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeGuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parasiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theIrishmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimKurguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thePrestigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puanlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
    }
}

