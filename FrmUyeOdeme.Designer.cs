namespace Kutuphane
{
    partial class FrmUyeOdeme
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
            this.dtOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbUyeAdi = new System.Windows.Forms.ComboBox();
            this.txtOdemeMiktari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSil = new System.Windows.Forms.Button();
            this.cmdCikis = new System.Windows.Forms.Button();
            this.cmdKaydet = new System.Windows.Forms.Button();
            this.cmdYeni = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOdemeTarihi
            // 
            this.dtOdemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOdemeTarihi.Location = new System.Drawing.Point(138, 376);
            this.dtOdemeTarihi.Name = "dtOdemeTarihi";
            this.dtOdemeTarihi.Size = new System.Drawing.Size(516, 27);
            this.dtOdemeTarihi.TabIndex = 24;
            this.dtOdemeTarihi.Value = new System.DateTime(2022, 12, 17, 5, 28, 0, 0);
            // 
            // cmbUyeAdi
            // 
            this.cmbUyeAdi.FormattingEnabled = true;
            this.cmbUyeAdi.Location = new System.Drawing.Point(138, 338);
            this.cmbUyeAdi.Name = "cmbUyeAdi";
            this.cmbUyeAdi.Size = new System.Drawing.Size(516, 28);
            this.cmbUyeAdi.TabIndex = 25;
            // 
            // txtOdemeMiktari
            // 
            this.txtOdemeMiktari.Location = new System.Drawing.Point(138, 409);
            this.txtOdemeMiktari.Name = "txtOdemeMiktari";
            this.txtOdemeMiktari.Size = new System.Drawing.Size(516, 27);
            this.txtOdemeMiktari.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ödeme Miktarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ödeme Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Adı Soyad:";
            // 
            // cmdSil
            // 
            this.cmdSil.Enabled = false;
            this.cmdSil.Location = new System.Drawing.Point(357, 448);
            this.cmdSil.Name = "cmdSil";
            this.cmdSil.Size = new System.Drawing.Size(140, 29);
            this.cmdSil.TabIndex = 31;
            this.cmdSil.Text = "Sil";
            this.cmdSil.UseVisualStyleBackColor = true;
            this.cmdSil.Click += new System.EventHandler(this.cmdSil_Click);
            // 
            // cmdCikis
            // 
            this.cmdCikis.Location = new System.Drawing.Point(514, 448);
            this.cmdCikis.Name = "cmdCikis";
            this.cmdCikis.Size = new System.Drawing.Size(140, 29);
            this.cmdCikis.TabIndex = 30;
            this.cmdCikis.Text = "Kapat";
            this.cmdCikis.UseVisualStyleBackColor = true;
            this.cmdCikis.Click += new System.EventHandler(this.cmdCikis_Click);
            // 
            // cmdKaydet
            // 
            this.cmdKaydet.Enabled = false;
            this.cmdKaydet.Location = new System.Drawing.Point(189, 448);
            this.cmdKaydet.Name = "cmdKaydet";
            this.cmdKaydet.Size = new System.Drawing.Size(140, 29);
            this.cmdKaydet.TabIndex = 29;
            this.cmdKaydet.Text = "Kaydet";
            this.cmdKaydet.UseVisualStyleBackColor = true;
            this.cmdKaydet.Click += new System.EventHandler(this.cmdKaydet_Click);
            // 
            // cmdYeni
            // 
            this.cmdYeni.Location = new System.Drawing.Point(28, 448);
            this.cmdYeni.Name = "cmdYeni";
            this.cmdYeni.Size = new System.Drawing.Size(140, 29);
            this.cmdYeni.TabIndex = 32;
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
            this.dtGridView.Location = new System.Drawing.Point(28, 21);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(626, 297);
            this.dtGridView.TabIndex = 34;
            this.dtGridView.Click += new System.EventHandler(this.dtGridView_Click);
            // 
            // FrmUyeOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 499);
            this.Controls.Add(this.dtOdemeTarihi);
            this.Controls.Add(this.cmbUyeAdi);
            this.Controls.Add(this.txtOdemeMiktari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSil);
            this.Controls.Add(this.cmdCikis);
            this.Controls.Add(this.cmdKaydet);
            this.Controls.Add(this.cmdYeni);
            this.Controls.Add(this.dtGridView);
            this.Name = "FrmUyeOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ödeme İşlemleri";
            this.Load += new System.EventHandler(this.FrmUyeOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtOdemeTarihi;
        private ComboBox cmbUyeAdi;
        private TextBox txtOdemeMiktari;
        private Label label5;
        private Label label7;
        private Label label4;
        private Button cmdSil;
        private Button cmdCikis;
        private Button cmdKaydet;
        private Button cmdYeni;
        private DataGridView dtGridView;
    }
}