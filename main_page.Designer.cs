namespace hospital_automation
{
    partial class main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_page));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label7 = new Label();
            hasta_bilgi = new Button();
            kurum_adi = new TextBox();
            soyadi = new TextBox();
            hasta_adi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            git = new Button();
            bul = new Button();
            onceki_islem = new TextBox();
            sevk_tarihi = new DateTimePicker();
            dosya_no = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label8 = new Label();
            comboBox_klinik = new ComboBox();
            groupBox4 = new GroupBox();
            textBox_sira = new TextBox();
            label9 = new Label();
            groupBox5 = new GroupBox();
            label10 = new Label();
            comboBox_islem = new ComboBox();
            groupBox6 = new GroupBox();
            label11 = new Label();
            comboBox_kod = new ComboBox();
            groupBox7 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label12 = new Label();
            groupBox8 = new GroupBox();
            textBox_fiyat = new TextBox();
            label13 = new Label();
            button_ekle = new Button();
            groupBox9 = new GroupBox();
            button_exit = new Button();
            button_baski = new Button();
            button_yazdir = new Button();
            button_taburcu = new Button();
            button_sil = new Button();
            button_yeni = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 277);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(938, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yapılan Tahlil ve İşlemler";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(938, 287);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Polinklinik";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Sıra NO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Saat";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Yapılan İşlem";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Dr. Kodu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Miktar";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Fiyat";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(hasta_bilgi);
            groupBox2.Controls.Add(kurum_adi);
            groupBox2.Controls.Add(soyadi);
            groupBox2.Controls.Add(hasta_adi);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(git);
            groupBox2.Controls.Add(bul);
            groupBox2.Controls.Add(onceki_islem);
            groupBox2.Controls.Add(sevk_tarihi);
            groupBox2.Controls.Add(dosya_no);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 29);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(938, 141);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(708, 43);
            label7.Name = "label7";
            label7.Size = new Size(224, 20);
            label7.TabIndex = 15;
            label7.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // hasta_bilgi
            // 
            hasta_bilgi.Location = new Point(707, 75);
            hasta_bilgi.Margin = new Padding(3, 4, 3, 4);
            hasta_bilgi.Name = "hasta_bilgi";
            hasta_bilgi.Size = new Size(207, 58);
            hasta_bilgi.TabIndex = 14;
            hasta_bilgi.Text = "Hasta Bilgileri";
            hasta_bilgi.UseVisualStyleBackColor = true;
            hasta_bilgi.Click += hasta_bilgi_Click;
            // 
            // kurum_adi
            // 
            kurum_adi.Location = new Point(419, 101);
            kurum_adi.Margin = new Padding(3, 4, 3, 4);
            kurum_adi.Name = "kurum_adi";
            kurum_adi.Size = new Size(181, 27);
            kurum_adi.TabIndex = 13;
            // 
            // soyadi
            // 
            soyadi.Location = new Point(419, 69);
            soyadi.Margin = new Padding(3, 4, 3, 4);
            soyadi.Name = "soyadi";
            soyadi.Size = new Size(181, 27);
            soyadi.TabIndex = 12;
            // 
            // hasta_adi
            // 
            hasta_adi.Location = new Point(419, 36);
            hasta_adi.Margin = new Padding(3, 4, 3, 4);
            hasta_adi.Name = "hasta_adi";
            hasta_adi.Size = new Size(181, 27);
            hasta_adi.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 104);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 10;
            label6.Text = "Kurum Adı: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 69);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 39);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 8;
            label4.Text = "Hasta Adı:";
            // 
            // git
            // 
            git.Location = new Point(220, 100);
            git.Margin = new Padding(3, 4, 3, 4);
            git.Name = "git";
            git.Size = new Size(59, 29);
            git.TabIndex = 7;
            git.Text = "GİT";
            git.UseVisualStyleBackColor = true;
            // 
            // bul
            // 
            bul.Location = new Point(221, 35);
            bul.Margin = new Padding(3, 4, 3, 4);
            bul.Name = "bul";
            bul.Size = new Size(59, 29);
            bul.TabIndex = 6;
            bul.Text = "BUL";
            bul.UseVisualStyleBackColor = true;
            bul.Click += bul_Click;
            // 
            // onceki_islem
            // 
            onceki_islem.Location = new Point(114, 100);
            onceki_islem.Margin = new Padding(3, 4, 3, 4);
            onceki_islem.Name = "onceki_islem";
            onceki_islem.Size = new Size(100, 27);
            onceki_islem.TabIndex = 5;
            // 
            // sevk_tarihi
            // 
            sevk_tarihi.Location = new Point(115, 69);
            sevk_tarihi.Margin = new Padding(3, 4, 3, 4);
            sevk_tarihi.Name = "sevk_tarihi";
            sevk_tarihi.Size = new Size(165, 27);
            sevk_tarihi.TabIndex = 4;
            // 
            // dosya_no
            // 
            dosya_no.Location = new Point(115, 35);
            dosya_no.Margin = new Padding(3, 4, 3, 4);
            dosya_no.Name = "dosya_no";
            dosya_no.Size = new Size(100, 27);
            dosya_no.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 100);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Önceki İşlemler: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 69);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Sevk Tarihi: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Dosya NO:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(comboBox_klinik);
            groupBox3.Location = new Point(12, 183);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(178, 81);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 20);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 1;
            label8.Text = "Poliklinik";
            // 
            // comboBox_klinik
            // 
            comboBox_klinik.FormattingEnabled = true;
            comboBox_klinik.Location = new Point(6, 44);
            comboBox_klinik.Margin = new Padding(3, 4, 3, 4);
            comboBox_klinik.Name = "comboBox_klinik";
            comboBox_klinik.Size = new Size(164, 28);
            comboBox_klinik.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(textBox_sira);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(196, 183);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(113, 81);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // textBox_sira
            // 
            textBox_sira.Location = new Point(6, 44);
            textBox_sira.Margin = new Padding(3, 4, 3, 4);
            textBox_sira.Name = "textBox_sira";
            textBox_sira.Size = new Size(100, 27);
            textBox_sira.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 20);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 1;
            label9.Text = "Sıra NO";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ActiveCaption;
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(comboBox_islem);
            groupBox5.Location = new Point(315, 183);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(175, 81);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 20);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 1;
            label10.Text = "Yapılan İşlem";
            // 
            // comboBox_islem
            // 
            comboBox_islem.FormattingEnabled = true;
            comboBox_islem.Items.AddRange(new object[] { "Muayne", "Pansuman", "Ameliyat", "MR", "EEG", "EKG" });
            comboBox_islem.Location = new Point(6, 44);
            comboBox_islem.Margin = new Padding(3, 4, 3, 4);
            comboBox_islem.Name = "comboBox_islem";
            comboBox_islem.Size = new Size(163, 28);
            comboBox_islem.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ActiveCaption;
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(comboBox_kod);
            groupBox6.Location = new Point(496, 183);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(101, 81);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 20);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 1;
            label11.Text = "Dr. Kodu";
            // 
            // comboBox_kod
            // 
            comboBox_kod.FormattingEnabled = true;
            comboBox_kod.Location = new Point(6, 44);
            comboBox_kod.Margin = new Padding(3, 4, 3, 4);
            comboBox_kod.Name = "comboBox_kod";
            comboBox_kod.Size = new Size(89, 28);
            comboBox_kod.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.ActiveCaption;
            groupBox7.Controls.Add(numericUpDown1);
            groupBox7.Controls.Add(label12);
            groupBox7.Location = new Point(603, 182);
            groupBox7.Margin = new Padding(3, 4, 3, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 4, 3, 4);
            groupBox7.Size = new Size(97, 81);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 48);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(85, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 20);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 1;
            label12.Text = "Miktar";
            // 
            // groupBox8
            // 
            groupBox8.BackColor = SystemColors.ActiveCaption;
            groupBox8.Controls.Add(textBox_fiyat);
            groupBox8.Controls.Add(label13);
            groupBox8.Location = new Point(706, 183);
            groupBox8.Margin = new Padding(3, 4, 3, 4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 4, 3, 4);
            groupBox8.Size = new Size(113, 81);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            // 
            // textBox_fiyat
            // 
            textBox_fiyat.Location = new Point(6, 46);
            textBox_fiyat.Margin = new Padding(3, 4, 3, 4);
            textBox_fiyat.Name = "textBox_fiyat";
            textBox_fiyat.Size = new Size(101, 27);
            textBox_fiyat.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 20);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 1;
            label13.Text = "Birim Fiyat";
            // 
            // button_ekle
            // 
            button_ekle.Location = new Point(831, 192);
            button_ekle.Margin = new Padding(3, 4, 3, 4);
            button_ekle.Name = "button_ekle";
            button_ekle.Size = new Size(119, 71);
            button_ekle.TabIndex = 8;
            button_ekle.Text = "EKLE";
            button_ekle.UseVisualStyleBackColor = true;
            button_ekle.Click += button_ekle_Click;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = SystemColors.ActiveCaption;
            groupBox9.Controls.Add(button_exit);
            groupBox9.Controls.Add(button_baski);
            groupBox9.Controls.Add(button_yazdir);
            groupBox9.Controls.Add(button_taburcu);
            groupBox9.Controls.Add(button_sil);
            groupBox9.Controls.Add(button_yeni);
            groupBox9.Location = new Point(12, 599);
            groupBox9.Margin = new Padding(3, 4, 3, 4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(3, 4, 3, 4);
            groupBox9.Size = new Size(938, 86);
            groupBox9.TabIndex = 9;
            groupBox9.TabStop = false;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(843, 26);
            button_exit.Margin = new Padding(3, 4, 3, 4);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(89, 52);
            button_exit.TabIndex = 5;
            button_exit.Text = "ÇIKIŞ";
            button_exit.UseVisualStyleBackColor = true;
            // 
            // button_baski
            // 
            button_baski.Location = new Point(502, 26);
            button_baski.Margin = new Padding(3, 4, 3, 4);
            button_baski.Name = "button_baski";
            button_baski.Size = new Size(89, 52);
            button_baski.TabIndex = 4;
            button_baski.Text = "BASKI ÖNİZLEME";
            button_baski.UseVisualStyleBackColor = true;
            button_baski.Click += button_baski_Click;
            // 
            // button_yazdir
            // 
            button_yazdir.Location = new Point(410, 26);
            button_yazdir.Margin = new Padding(3, 4, 3, 4);
            button_yazdir.Name = "button_yazdir";
            button_yazdir.Size = new Size(89, 52);
            button_yazdir.TabIndex = 3;
            button_yazdir.Text = "YAZDIR";
            button_yazdir.UseVisualStyleBackColor = true;
            button_yazdir.Click += button_yazdir_Click;
            // 
            // button_taburcu
            // 
            button_taburcu.Location = new Point(191, 26);
            button_taburcu.Margin = new Padding(3, 4, 3, 4);
            button_taburcu.Name = "button_taburcu";
            button_taburcu.Size = new Size(89, 52);
            button_taburcu.TabIndex = 2;
            button_taburcu.Text = "TABURCU";
            button_taburcu.UseVisualStyleBackColor = true;
            // 
            // button_sil
            // 
            button_sil.Location = new Point(91, 26);
            button_sil.Margin = new Padding(3, 4, 3, 4);
            button_sil.Name = "button_sil";
            button_sil.Size = new Size(79, 52);
            button_sil.TabIndex = 1;
            button_sil.Text = "SEÇ-SİL";
            button_sil.UseVisualStyleBackColor = true;
            button_sil.Click += button_sil_Click;
            // 
            // button_yeni
            // 
            button_yeni.Location = new Point(6, 26);
            button_yeni.Margin = new Padding(3, 4, 3, 4);
            button_yeni.Name = "button_yeni";
            button_yeni.Size = new Size(79, 52);
            button_yeni.TabIndex = 0;
            button_yeni.Text = "YENİ";
            button_yeni.UseVisualStyleBackColor = true;
            button_yeni.Click += button_yeni_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(958, 27);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(127, 24);
            toolStripButton1.Text = "Poliklinik Tanıtma";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(113, 24);
            toolStripButton2.Text = "Rapor İşlemleri";
            // 
            // main_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(958, 698);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox9);
            Controls.Add(button_ekle);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "main_page";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker sevk_tarihi;
        private System.Windows.Forms.TextBox dosya_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button git;
        private System.Windows.Forms.Button bul;
        private System.Windows.Forms.TextBox onceki_islem;
        private System.Windows.Forms.Button hasta_bilgi;
        private System.Windows.Forms.TextBox kurum_adi;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.TextBox hasta_adi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_klinik;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_sira;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_islem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_kod;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_fiyat;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_baski;
        private System.Windows.Forms.Button button_yazdir;
        private System.Windows.Forms.Button button_taburcu;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_yeni;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}