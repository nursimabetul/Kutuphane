namespace Kutuphane
{
    partial class FrmKitap
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
            this.cmbYayinci = new System.Windows.Forms.ComboBox();
            this.txtSayfaSayısı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSil = new System.Windows.Forms.Button();
            this.cmdCikis = new System.Windows.Forms.Button();
            this.cmdKaydet = new System.Windows.Forms.Button();
            this.cmdYeni = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbRaf = new System.Windows.Forms.ComboBox();
            this.dtBasımTarihi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.chkOduncVerildi = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYayinci
            // 
            this.cmbYayinci.FormattingEnabled = true;
            this.cmbYayinci.Items.AddRange(new object[] {
            "Yönetici",
            "Operatör"});
            this.cmbYayinci.Location = new System.Drawing.Point(114, 392);
            this.cmbYayinci.Name = "cmbYayinci";
            this.cmbYayinci.Size = new System.Drawing.Size(259, 28);
            this.cmbYayinci.TabIndex = 28;
            // 
            // txtSayfaSayısı
            // 
            this.txtSayfaSayısı.Location = new System.Drawing.Point(502, 428);
            this.txtSayfaSayısı.Name = "txtSayfaSayısı";
            this.txtSayfaSayısı.Size = new System.Drawing.Size(259, 27);
            this.txtSayfaSayısı.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Yayıncı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(114, 359);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(259, 27);
            this.txtISBN.TabIndex = 24;
            this.txtISBN.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "ISBN No:";
            // 
            // txtKitapAdı
            // 
            this.txtKitapAdı.Location = new System.Drawing.Point(114, 326);
            this.txtKitapAdı.Name = "txtKitapAdı";
            this.txtKitapAdı.Size = new System.Drawing.Size(259, 27);
            this.txtKitapAdı.TabIndex = 27;
            this.txtKitapAdı.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kitap Adı:";
            // 
            // cmdSil
            // 
            this.cmdSil.Enabled = false;
            this.cmdSil.Location = new System.Drawing.Point(396, 538);
            this.cmdSil.Name = "cmdSil";
            this.cmdSil.Size = new System.Drawing.Size(177, 29);
            this.cmdSil.TabIndex = 0;
            this.cmdSil.Text = "Sil";
            this.cmdSil.UseVisualStyleBackColor = true;
            this.cmdSil.Click += new System.EventHandler(this.cmdSil_Click);
            // 
            // cmdCikis
            // 
            this.cmdCikis.Location = new System.Drawing.Point(584, 538);
            this.cmdCikis.Name = "cmdCikis";
            this.cmdCikis.Size = new System.Drawing.Size(177, 29);
            this.cmdCikis.TabIndex = 0;
            this.cmdCikis.Text = "Kapat";
            this.cmdCikis.UseVisualStyleBackColor = true;
            this.cmdCikis.Click += new System.EventHandler(this.cmdCikis_Click);
            // 
            // cmdKaydet
            // 
            this.cmdKaydet.Enabled = false;
            this.cmdKaydet.Location = new System.Drawing.Point(204, 538);
            this.cmdKaydet.Name = "cmdKaydet";
            this.cmdKaydet.Size = new System.Drawing.Size(177, 29);
            this.cmdKaydet.TabIndex = 0;
            this.cmdKaydet.Text = "Kaydet";
            this.cmdKaydet.UseVisualStyleBackColor = true;
            this.cmdKaydet.Click += new System.EventHandler(this.cmdKaydet_Click);
            // 
            // cmdYeni
            // 
            this.cmdYeni.Location = new System.Drawing.Point(12, 538);
            this.cmdYeni.Name = "cmdYeni";
            this.cmdYeni.Size = new System.Drawing.Size(177, 29);
            this.cmdYeni.TabIndex = 0;
            this.cmdYeni.Text = "Yeni";
            this.cmdYeni.UseVisualStyleBackColor = true;
            this.cmdYeni.Click += new System.EventHandler(this.cmdYeni_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.AllowUserToResizeColumns = false;
            this.dtGridView.AllowUserToResizeRows = false;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtGridView.Location = new System.Drawing.Point(12, 12);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(749, 301);
            this.dtGridView.TabIndex = 13;
            this.dtGridView.Click += new System.EventHandler(this.dtGridView_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Yazar:";
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Items.AddRange(new object[] {
            "Yönetici",
            "Operatör"});
            this.cmbYazar.Location = new System.Drawing.Point(114, 426);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(259, 28);
            this.cmbYazar.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tür:";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Yönetici",
            "Operatör"});
            this.cmbTur.Location = new System.Drawing.Point(114, 460);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(259, 28);
            this.cmbTur.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bölüm:";
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Items.AddRange(new object[] {
            "Yönetici",
            "Operatör"});
            this.cmbBolum.Location = new System.Drawing.Point(114, 494);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(259, 28);
            this.cmbBolum.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Yönetici",
            "Operatör"});
            this.cmbKategori.Location = new System.Drawing.Point(502, 326);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(259, 28);
            this.cmbKategori.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Yayın Dili:";
            // 
            // cmbDil
            // 
            this.cmbDil.FormattingEnabled = true;
            this.cmbDil.Items.AddRange(new object[] {
            "Yönetici",
            "Operatör"});
            this.cmbDil.Location = new System.Drawing.Point(502, 360);
            this.cmbDil.Name = "cmbDil";
            this.cmbDil.Size = new System.Drawing.Size(259, 28);
            this.cmbDil.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Raftaki Yeri:";
            // 
            // cmbRaf
            // 
            this.cmbRaf.FormattingEnabled = true;
            this.cmbRaf.Items.AddRange(new object[] {
            "Yönetici",
            "Operatör"});
            this.cmbRaf.Location = new System.Drawing.Point(502, 394);
            this.cmbRaf.Name = "cmbRaf";
            this.cmbRaf.Size = new System.Drawing.Size(259, 28);
            this.cmbRaf.TabIndex = 28;
            // 
            // dtBasımTarihi
            // 
            this.dtBasımTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBasımTarihi.Location = new System.Drawing.Point(502, 461);
            this.dtBasımTarihi.Name = "dtBasımTarihi";
            this.dtBasımTarihi.Size = new System.Drawing.Size(259, 27);
            this.dtBasımTarihi.TabIndex = 0;
            this.dtBasımTarihi.Value = new System.DateTime(2022, 12, 17, 5, 28, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Basım Tarihi:";
            // 
            // chkOduncVerildi
            // 
            this.chkOduncVerildi.AutoSize = true;
            this.chkOduncVerildi.Location = new System.Drawing.Point(511, 498);
            this.chkOduncVerildi.Name = "chkOduncVerildi";
            this.chkOduncVerildi.Size = new System.Drawing.Size(119, 24);
            this.chkOduncVerildi.TabIndex = 0;
            this.chkOduncVerildi.Text = "Ödünç verildi";
            this.chkOduncVerildi.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(400, 497);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Durumu:";
            // 
            // FrmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 588);
            this.Controls.Add(this.chkOduncVerildi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtBasımTarihi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbRaf);
            this.Controls.Add(this.cmbDil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbYayinci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSayfaSayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAdı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSil);
            this.Controls.Add(this.cmdCikis);
            this.Controls.Add(this.cmdKaydet);
            this.Controls.Add(this.cmdYeni);
            this.Controls.Add(this.dtGridView);
            this.Name = "FrmKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitap";
            this.Load += new System.EventHandler(this.FrmKitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbYayinci;
        private TextBox txtSayfaSayısı;
        private Label label4;
        private Label label3;
        private TextBox txtISBN;
        private Label label2;
        private TextBox txtKitapAdı;
        private Label label1;
        private Button cmdSil;
        private Button cmdCikis;
        private Button cmdKaydet;
        private Button cmdYeni;
        private DataGridView dtGridView;
        private Label label5;
        private ComboBox cmbYazar;
        private Label label6;
        private ComboBox cmbTur;
        private Label label7;
        private ComboBox cmbBolum;
        private Label label8;
        private ComboBox cmbKategori;
        private Label label9;
        private ComboBox cmbDil;
        private Label label10;
        private ComboBox cmbRaf;
        private DateTimePicker dtBasımTarihi;
        private Label label11;
        private CheckBox chkOduncVerildi;
        private Label label12;
    }
}