namespace Kutuphane
{
    partial class FrmKullanici
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
            this.txtKullaniciAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSil = new System.Windows.Forms.Button();
            this.cmdCikis = new System.Windows.Forms.Button();
            this.cmdKaydet = new System.Windows.Forms.Button();
            this.cmdYeni = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKullaniciTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKullaniciDeneme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdiSoyadi
            // 
            this.txtKullaniciAdiSoyadi.Location = new System.Drawing.Point(124, 336);
            this.txtKullaniciAdiSoyadi.Name = "txtKullaniciAdiSoyadi";
            this.txtKullaniciAdiSoyadi.Size = new System.Drawing.Size(647, 27);
            this.txtKullaniciAdiSoyadi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adı Soyadı:";
            // 
            // cmdSil
            // 
            this.cmdSil.Enabled = false;
            this.cmdSil.Location = new System.Drawing.Point(401, 572);
            this.cmdSil.Name = "cmdSil";
            this.cmdSil.Size = new System.Drawing.Size(177, 29);
            this.cmdSil.TabIndex = 0;
            this.cmdSil.Text = "Sil";
            this.cmdSil.UseVisualStyleBackColor = true;
            this.cmdSil.Click += new System.EventHandler(this.cmdSil_Click);
            // 
            // cmdCikis
            // 
            this.cmdCikis.Location = new System.Drawing.Point(594, 572);
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
            this.cmdKaydet.Location = new System.Drawing.Point(209, 572);
            this.cmdKaydet.Name = "cmdKaydet";
            this.cmdKaydet.Size = new System.Drawing.Size(177, 29);
            this.cmdKaydet.TabIndex = 0;
            this.cmdKaydet.Text = "Kaydet";
            this.cmdKaydet.UseVisualStyleBackColor = true;
            this.cmdKaydet.Click += new System.EventHandler(this.cmdKaydet_Click);
            // 
            // cmdYeni
            // 
            this.cmdYeni.Location = new System.Drawing.Point(17, 572);
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
            this.dtGridView.Location = new System.Drawing.Point(22, 22);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(749, 282);
            this.dtGridView.TabIndex = 4;
            this.dtGridView.Click += new System.EventHandler(this.dtGridView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(124, 382);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(647, 27);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(124, 427);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(647, 27);
            this.txtKullaniciSifre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Türü:";
            // 
            // cmbKullaniciTuru
            // 
            this.cmbKullaniciTuru.FormattingEnabled = true;
            this.cmbKullaniciTuru.Items.AddRange(new object[] {
            "Yönetici",
            "Operatör"});
            this.cmbKullaniciTuru.Location = new System.Drawing.Point(124, 473);
            this.cmbKullaniciTuru.Name = "cmbKullaniciTuru";
            this.cmbKullaniciTuru.Size = new System.Drawing.Size(647, 28);
            this.cmbKullaniciTuru.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Durumu:";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(133, 521);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(62, 24);
            this.chkAktif.TabIndex = 0;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giriş Deneme Sayısı:";
            // 
            // txtKullaniciDeneme
            // 
            this.txtKullaniciDeneme.Location = new System.Drawing.Point(427, 523);
            this.txtKullaniciDeneme.Name = "txtKullaniciDeneme";
            this.txtKullaniciDeneme.Size = new System.Drawing.Size(344, 27);
            this.txtKullaniciDeneme.TabIndex = 0;
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.cmbKullaniciTuru);
            this.Controls.Add(this.txtKullaniciDeneme);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdiSoyadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSil);
            this.Controls.Add(this.cmdCikis);
            this.Controls.Add(this.cmdKaydet);
            this.Controls.Add(this.cmdYeni);
            this.Controls.Add(this.dtGridView);
            this.Name = "FrmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKullaniciAdiSoyadi;
        private Label label1;
        private Button cmdSil;
        private Button cmdCikis;
        private Button cmdKaydet;
        private Button cmdYeni;
        private DataGridView dtGridView;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private TextBox txtKullaniciSifre;
        private Label label4;
        private ComboBox cmbKullaniciTuru;
        private Label label5;
        private CheckBox chkAktif;
        private Label label6;
        private TextBox txtKullaniciDeneme;
    }
}