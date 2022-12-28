namespace Kutuphane
{
    partial class FrmOduncAlma
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
            this.cmdSil = new System.Windows.Forms.Button();
            this.cmdCikis = new System.Windows.Forms.Button();
            this.cmdKaydet = new System.Windows.Forms.Button();
            this.cmdYeni = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.dtIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbUyeAdi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtAlmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKitapAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSil
            // 
            this.cmdSil.Enabled = false;
            this.cmdSil.Location = new System.Drawing.Point(406, 537);
            this.cmdSil.Name = "cmdSil";
            this.cmdSil.Size = new System.Drawing.Size(177, 29);
            this.cmdSil.TabIndex = 37;
            this.cmdSil.Text = "Sil";
            this.cmdSil.UseVisualStyleBackColor = true;
            this.cmdSil.Click += new System.EventHandler(this.cmdSil_Click);
            // 
            // cmdCikis
            // 
            this.cmdCikis.Location = new System.Drawing.Point(594, 537);
            this.cmdCikis.Name = "cmdCikis";
            this.cmdCikis.Size = new System.Drawing.Size(177, 29);
            this.cmdCikis.TabIndex = 36;
            this.cmdCikis.Text = "Kapat";
            this.cmdCikis.UseVisualStyleBackColor = true;
            this.cmdCikis.Click += new System.EventHandler(this.cmdCikis_Click);
            // 
            // cmdKaydet
            // 
            this.cmdKaydet.Enabled = false;
            this.cmdKaydet.Location = new System.Drawing.Point(214, 537);
            this.cmdKaydet.Name = "cmdKaydet";
            this.cmdKaydet.Size = new System.Drawing.Size(177, 29);
            this.cmdKaydet.TabIndex = 34;
            this.cmdKaydet.Text = "Kaydet";
            this.cmdKaydet.UseVisualStyleBackColor = true;
            this.cmdKaydet.Click += new System.EventHandler(this.cmdKaydet_Click);
            // 
            // cmdYeni
            // 
            this.cmdYeni.Location = new System.Drawing.Point(22, 537);
            this.cmdYeni.Name = "cmdYeni";
            this.cmdYeni.Size = new System.Drawing.Size(177, 29);
            this.cmdYeni.TabIndex = 39;
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
            this.dtGridView.Location = new System.Drawing.Point(22, 12);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(749, 301);
            this.dtGridView.TabIndex = 40;
            this.dtGridView.Click += new System.EventHandler(this.dtGridView_Click);
            // 
            // dtIadeTarihi
            // 
            this.dtIadeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIadeTarihi.Location = new System.Drawing.Point(135, 368);
            this.dtIadeTarihi.Name = "dtIadeTarihi";
            this.dtIadeTarihi.Size = new System.Drawing.Size(636, 27);
            this.dtIadeTarihi.TabIndex = 41;
            this.dtIadeTarihi.Value = new System.DateTime(2022, 12, 17, 5, 28, 0, 0);
            // 
            // cmbUyeAdi
            // 
            this.cmbUyeAdi.FormattingEnabled = true;
            this.cmbUyeAdi.Location = new System.Drawing.Point(135, 401);
            this.cmbUyeAdi.Name = "cmbUyeAdi";
            this.cmbUyeAdi.Size = new System.Drawing.Size(636, 28);
            this.cmbUyeAdi.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "İade Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Adı Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Alma Tarihi:";
            // 
            // dtAlmaTarihi
            // 
            this.dtAlmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAlmaTarihi.Location = new System.Drawing.Point(135, 335);
            this.dtAlmaTarihi.Name = "dtAlmaTarihi";
            this.dtAlmaTarihi.Size = new System.Drawing.Size(636, 27);
            this.dtAlmaTarihi.TabIndex = 41;
            this.dtAlmaTarihi.Value = new System.DateTime(2022, 12, 17, 5, 28, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Kitap Adı:";
            // 
            // cmbKitapAdi
            // 
            this.cmbKitapAdi.FormattingEnabled = true;
            this.cmbKitapAdi.Location = new System.Drawing.Point(135, 435);
            this.cmbKitapAdi.Name = "cmbKitapAdi";
            this.cmbKitapAdi.Size = new System.Drawing.Size(636, 28);
            this.cmbKitapAdi.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Teslim Tarihi:";
            // 
            // dtTeslimTarihi
            // 
            this.dtTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTeslimTarihi.Location = new System.Drawing.Point(135, 469);
            this.dtTeslimTarihi.Name = "dtTeslimTarihi";
            this.dtTeslimTarihi.Size = new System.Drawing.Size(636, 27);
            this.dtTeslimTarihi.TabIndex = 41;
            this.dtTeslimTarihi.Value = new System.DateTime(2022, 12, 17, 5, 28, 0, 0);
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(137, 507);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(115, 24);
            this.chkAktif.TabIndex = 47;
            this.chkAktif.Text = "Teslim edildi";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Durumu:";
            // 
            // FrmOduncAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 577);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtAlmaTarihi);
            this.Controls.Add(this.dtTeslimTarihi);
            this.Controls.Add(this.dtIadeTarihi);
            this.Controls.Add(this.cmbKitapAdi);
            this.Controls.Add(this.cmbUyeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSil);
            this.Controls.Add(this.cmdCikis);
            this.Controls.Add(this.cmdKaydet);
            this.Controls.Add(this.cmdYeni);
            this.Controls.Add(this.dtGridView);
            this.Name = "FrmOduncAlma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOdunc";
            this.Load += new System.EventHandler(this.FrmOduncAlma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button cmdSil;
        private Button cmdCikis;
        private Button cmdKaydet;
        private Button cmdYeni;
        private DataGridView dtGridView;
        private DateTimePicker dtIadeTarihi;
        private ComboBox cmbUyeAdi;
        private Label label7;
        private Label label4;
        private Label label1;
        private DateTimePicker dtAlmaTarihi;
        private Label label2;
        private ComboBox cmbKitapAdi;
        private Label label3;
        private DateTimePicker dtTeslimTarihi;
        private CheckBox chkAktif;
        private Label label5;
    }
}