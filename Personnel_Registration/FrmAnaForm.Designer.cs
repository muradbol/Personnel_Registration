namespace Personnel_Registration
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMaas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Bekar = new System.Windows.Forms.RadioButton();
            this.Evli = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboSehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtİd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGrafik = new System.Windows.Forms.Button();
            this.Btnİstatistik = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_Veri_TabaniDataSet = new Personnel_Registration.Personel_Veri_TabaniDataSet();
            this.personelTableAdapter = new Personnel_Registration.Personel_Veri_TabaniDataSetTableAdapters.PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMaas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtMeslek);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Bekar);
            this.groupBox1.Controls.Add(this.Evli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboSehir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSoy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txtİd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(171, 171);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Size = new System.Drawing.Size(100, 26);
            this.TxtMaas.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Maaş : ";
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(171, 257);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(100, 26);
            this.TxtMeslek.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Meslek : ";
            // 
            // Bekar
            // 
            this.Bekar.AutoSize = true;
            this.Bekar.Location = new System.Drawing.Point(232, 213);
            this.Bekar.Name = "Bekar";
            this.Bekar.Size = new System.Drawing.Size(74, 24);
            this.Bekar.TabIndex = 6;
            this.Bekar.TabStop = true;
            this.Bekar.Text = "Bekar";
            this.Bekar.UseVisualStyleBackColor = true;
            this.Bekar.CheckedChanged += new System.EventHandler(this.Bekar_CheckedChanged);
            // 
            // Evli
            // 
            this.Evli.AutoSize = true;
            this.Evli.Location = new System.Drawing.Point(171, 213);
            this.Evli.Name = "Evli";
            this.Evli.Size = new System.Drawing.Size(55, 24);
            this.Evli.TabIndex = 5;
            this.Evli.TabStop = true;
            this.Evli.Text = "Evli";
            this.Evli.UseVisualStyleBackColor = true;
            this.Evli.CheckedChanged += new System.EventHandler(this.Evli_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Durum :";
            // 
            // ComboSehir
            // 
            this.ComboSehir.FormattingEnabled = true;
            this.ComboSehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.ComboSehir.Location = new System.Drawing.Point(171, 133);
            this.ComboSehir.Name = "ComboSehir";
            this.ComboSehir.Size = new System.Drawing.Size(100, 28);
            this.ComboSehir.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şehir :";
            // 
            // TxtSoy
            // 
            this.TxtSoy.Location = new System.Drawing.Point(171, 101);
            this.TxtSoy.Name = "TxtSoy";
            this.TxtSoy.Size = new System.Drawing.Size(100, 26);
            this.TxtSoy.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel SoyAd :";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(171, 68);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 26);
            this.TxtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel Ad :";
            // 
            // Txtİd
            // 
            this.Txtİd.Location = new System.Drawing.Point(171, 36);
            this.Txtİd.Name = "Txtİd";
            this.Txtİd.Size = new System.Drawing.Size(100, 26);
            this.Txtİd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel İd : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnGrafik);
            this.groupBox2.Controls.Add(this.Btnİstatistik);
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.BtnGüncelle);
            this.groupBox2.Controls.Add(this.BtnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 322);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(80, 177);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(92, 31);
            this.BtnSil.TabIndex = 12;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.Location = new System.Drawing.Point(80, 251);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(92, 31);
            this.BtnGrafik.TabIndex = 14;
            this.BtnGrafik.Text = "Grafikler";
            this.BtnGrafik.UseVisualStyleBackColor = true;
            this.BtnGrafik.Click += new System.EventHandler(this.BtnGrafik_Click);
            // 
            // Btnİstatistik
            // 
            this.Btnİstatistik.Location = new System.Drawing.Point(80, 214);
            this.Btnİstatistik.Name = "Btnİstatistik";
            this.Btnİstatistik.Size = new System.Drawing.Size(92, 31);
            this.Btnİstatistik.TabIndex = 13;
            this.Btnİstatistik.Text = "İstatistik";
            this.Btnİstatistik.UseVisualStyleBackColor = true;
            this.Btnİstatistik.Click += new System.EventHandler(this.Btnİstatistik_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(80, 140);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(92, 31);
            this.BtnTemizle.TabIndex = 11;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(80, 104);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(92, 31);
            this.BtnGüncelle.TabIndex = 10;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(80, 68);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(92, 31);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(80, 31);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(92, 31);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(122, 211);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 31);
            this.button8.TabIndex = 9;
            this.button8.Text = "Sil";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(122, 249);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 31);
            this.button9.TabIndex = 9;
            this.button9.Text = "İstatistik";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(122, 174);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 31);
            this.button10.TabIndex = 9;
            this.button10.Text = "Temizle";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(122, 134);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 31);
            this.button11.TabIndex = 9;
            this.button11.Text = "Temizle";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(122, 98);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(92, 31);
            this.button12.TabIndex = 9;
            this.button12.Text = "Güncelle";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(122, 62);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(92, 31);
            this.button13.TabIndex = 9;
            this.button13.Text = "Kaydet";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(122, 25);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(92, 31);
            this.button14.TabIndex = 9;
            this.button14.Text = "Listele";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(122, 285);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(92, 31);
            this.button15.TabIndex = 9;
            this.button15.Text = "Grafikler";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(915, 232);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayitlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perİdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // perİdDataGridViewTextBoxColumn
            // 
            this.perİdDataGridViewTextBoxColumn.DataPropertyName = "Perİd";
            this.perİdDataGridViewTextBoxColumn.HeaderText = "Perİd";
            this.perİdDataGridViewTextBoxColumn.Name = "perİdDataGridViewTextBoxColumn";
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyDataGridViewTextBoxColumn
            // 
            this.perSoyDataGridViewTextBoxColumn.DataPropertyName = "PerSoy";
            this.perSoyDataGridViewTextBoxColumn.HeaderText = "PerSoy";
            this.perSoyDataGridViewTextBoxColumn.Name = "perSoyDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaaasDataGridViewTextBoxColumn
            // 
            this.perMaaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaaas";
            this.perMaaasDataGridViewTextBoxColumn.HeaderText = "PerMaaas";
            this.perMaaasDataGridViewTextBoxColumn.Name = "perMaaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.personel_Veri_TabaniDataSet;
            // 
            // personel_Veri_TabaniDataSet
            // 
            this.personel_Veri_TabaniDataSet.DataSetName = "Personel_Veri_TabaniDataSet";
            this.personel_Veri_TabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(837, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Personnel_Registration.Properties.Resources.timely_dribbble;
            this.pictureBox1.Location = new System.Drawing.Point(779, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(929, 574);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboSehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtİd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMeslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Bekar;
        private System.Windows.Forms.RadioButton Evli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGrafik;
        private System.Windows.Forms.Button Btnİstatistik;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TxtMaas;
        private Personel_Veri_TabaniDataSet personel_Veri_TabaniDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private Personel_Veri_TabaniDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

