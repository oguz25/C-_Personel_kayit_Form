namespace _27_Personel_kayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_yeniKisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ad_soyad = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Txt_aranan = new System.Windows.Forms.TextBox();
            this.comboBox_meslek = new System.Windows.Forms.ComboBox();
            this.comboBox_Calislian_birim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_ekle = new System.Windows.Forms.Button();
            this.Btn_sil = new System.Windows.Forms.Button();
            this.Btn_bul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_sonrakini = new System.Windows.Forms.Button();
            this.Btn_degistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.Btn_araya_ekle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_yeniKisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Calislian_birim);
            this.groupBox1.Controls.Add(this.comboBox_meslek);
            this.groupBox1.Controls.Add(this.Txt_ad_soyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_araya_ekle);
            this.groupBox2.Controls.Add(this.Btn_degistir);
            this.groupBox2.Controls.Add(this.Btn_sonrakini);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Btn_bul);
            this.groupBox2.Controls.Add(this.Btn_sil);
            this.groupBox2.Controls.Add(this.Btn_ekle);
            this.groupBox2.Controls.Add(this.Txt_aranan);
            this.groupBox2.Location = new System.Drawing.Point(411, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // Btn_yeniKisi
            // 
            this.Btn_yeniKisi.Location = new System.Drawing.Point(112, 167);
            this.Btn_yeniKisi.Name = "Btn_yeniKisi";
            this.Btn_yeniKisi.Size = new System.Drawing.Size(121, 32);
            this.Btn_yeniKisi.TabIndex = 2;
            this.Btn_yeniKisi.Text = "Yeni Kişi";
            this.Btn_yeniKisi.UseVisualStyleBackColor = true;
            this.Btn_yeniKisi.Click += new System.EventHandler(this.Btn_yeniKisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adı Soyadı";
            // 
            // Txt_ad_soyad
            // 
            this.Txt_ad_soyad.Location = new System.Drawing.Point(112, 34);
            this.Txt_ad_soyad.Name = "Txt_ad_soyad";
            this.Txt_ad_soyad.Size = new System.Drawing.Size(121, 22);
            this.Txt_ad_soyad.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 180);
            this.listBox1.TabIndex = 4;
            // 
            // Txt_aranan
            // 
            this.Txt_aranan.Location = new System.Drawing.Point(191, 75);
            this.Txt_aranan.Name = "Txt_aranan";
            this.Txt_aranan.Size = new System.Drawing.Size(121, 22);
            this.Txt_aranan.TabIndex = 4;
            // 
            // comboBox_meslek
            // 
            this.comboBox_meslek.FormattingEnabled = true;
            this.comboBox_meslek.Location = new System.Drawing.Point(112, 73);
            this.comboBox_meslek.Name = "comboBox_meslek";
            this.comboBox_meslek.Size = new System.Drawing.Size(121, 24);
            this.comboBox_meslek.TabIndex = 5;
            // 
            // comboBox_Calislian_birim
            // 
            this.comboBox_Calislian_birim.FormattingEnabled = true;
            this.comboBox_Calislian_birim.Location = new System.Drawing.Point(112, 118);
            this.comboBox_Calislian_birim.Name = "comboBox_Calislian_birim";
            this.comboBox_Calislian_birim.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Calislian_birim.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mesleği";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Çalıştığı Birim\r\n";
            // 
            // Btn_ekle
            // 
            this.Btn_ekle.Location = new System.Drawing.Point(18, 28);
            this.Btn_ekle.Name = "Btn_ekle";
            this.Btn_ekle.Size = new System.Drawing.Size(121, 28);
            this.Btn_ekle.TabIndex = 9;
            this.Btn_ekle.Text = "Ekle";
            this.Btn_ekle.UseVisualStyleBackColor = true;
            this.Btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // Btn_sil
            // 
            this.Btn_sil.Location = new System.Drawing.Point(191, 28);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(121, 28);
            this.Btn_sil.TabIndex = 10;
            this.Btn_sil.Text = "Sil";
            this.Btn_sil.UseVisualStyleBackColor = true;
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Btn_bul
            // 
            this.Btn_bul.Location = new System.Drawing.Point(18, 121);
            this.Btn_bul.Name = "Btn_bul";
            this.Btn_bul.Size = new System.Drawing.Size(121, 30);
            this.Btn_bul.TabIndex = 11;
            this.Btn_bul.Text = "Bul";
            this.Btn_bul.UseVisualStyleBackColor = true;
            this.Btn_bul.Click += new System.EventHandler(this.Btn_bul_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aranan";
            // 
            // Btn_sonrakini
            // 
            this.Btn_sonrakini.Location = new System.Drawing.Point(191, 121);
            this.Btn_sonrakini.Name = "Btn_sonrakini";
            this.Btn_sonrakini.Size = new System.Drawing.Size(121, 30);
            this.Btn_sonrakini.TabIndex = 12;
            this.Btn_sonrakini.Text = "Sonrakini";
            this.Btn_sonrakini.UseVisualStyleBackColor = true;
            this.Btn_sonrakini.Click += new System.EventHandler(this.Btn_sonrakini_Click);
            // 
            // Btn_degistir
            // 
            this.Btn_degistir.Location = new System.Drawing.Point(18, 180);
            this.Btn_degistir.Name = "Btn_degistir";
            this.Btn_degistir.Size = new System.Drawing.Size(121, 29);
            this.Btn_degistir.TabIndex = 13;
            this.Btn_degistir.Text = "Değiştir";
            this.Btn_degistir.UseVisualStyleBackColor = true;
            this.Btn_degistir.Click += new System.EventHandler(this.Btn_degistir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Personel Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sıra No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(289, 255);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(220, 180);
            this.listBox2.TabIndex = 13;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(541, 255);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(217, 180);
            this.listBox3.TabIndex = 14;
            // 
            // Btn_araya_ekle
            // 
            this.Btn_araya_ekle.Location = new System.Drawing.Point(191, 179);
            this.Btn_araya_ekle.Name = "Btn_araya_ekle";
            this.Btn_araya_ekle.Size = new System.Drawing.Size(121, 30);
            this.Btn_araya_ekle.TabIndex = 14;
            this.Btn_araya_ekle.Text = "Araya Ekle";
            this.Btn_araya_ekle.UseVisualStyleBackColor = true;
            this.Btn_araya_ekle.Click += new System.EventHandler(this.Btn_araya_ekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_yeniKisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Calislian_birim;
        private System.Windows.Forms.ComboBox comboBox_meslek;
        private System.Windows.Forms.TextBox Txt_ad_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_araya_ekle;
        private System.Windows.Forms.Button Btn_degistir;
        private System.Windows.Forms.Button Btn_sonrakini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_bul;
        private System.Windows.Forms.Button Btn_sil;
        private System.Windows.Forms.Button Btn_ekle;
        private System.Windows.Forms.TextBox Txt_aranan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

