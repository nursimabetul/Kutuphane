namespace Kutuphane
{
    partial class FrmUye
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
            this.cmbUyeTuru = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUyeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSil = new System.Windows.Forms.Button();
            this.cmdCikis = new System.Windows.Forms.Button();
            this.cmdKaydet = new System.Windows.Forms.Button();
            this.cmdYeni = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtUyelikTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUyeTuru
            // 
            this.cmbUyeTuru.FormattingEnabled = true;
            this.cmbUyeTuru.Location = new System.Drawing.Point(125, 567);
            this.cmbUyeTuru.Name = "cmbUyeTuru";
            this.cmbUyeTuru.Size = new System.Drawing.Size(647, 28);
            this.cmbUyeTuru.TabIndex = 0;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(125, 410);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(647, 27);
            this.txtTelefon.TabIndex = 0;
            // 
            // txtTCKimlik
            // 
            this.txtTCKimlik.Location = new System.Drawing.Point(125, 374);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(647, 27);
            this.txtTCKimlik.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Üye Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "TC Kimlik No:";
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Location = new System.Drawing.Point(125, 339);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(647, 27);
            this.txtUyeAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Adı Soyadı:";
            // 
            // cmdSil
            // 
            this.cmdSil.Enabled = false;
            this.cmdSil.Location = new System.Drawing.Point(402, 610);
            this.cmdSil.Name = "cmdSil";
            this.cmdSil.Size = new System.Drawing.Size(177, 29);
            this.cmdSil.TabIndex = 0;
            this.cmdSil.Text = "Sil";
            this.cmdSil.UseVisualStyleBackColor = true;
            // 
            // cmdCikis
            // 
            this.cmdCikis.Location = new System.Drawing.Point(595, 610);
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
            this.cmdKaydet.Location = new System.Drawing.Point(210, 610);
            this.cmdKaydet.Name = "cmdKaydet";
            this.cmdKaydet.Size = new System.Drawing.Size(177, 29);
            this.cmdKaydet.TabIndex = 0;
            this.cmdKaydet.Text = "Kaydet";
            this.cmdKaydet.UseVisualStyleBackColor = true;
            this.cmdKaydet.Click += new System.EventHandler(this.cmdKaydet_Click);
            // 
            // cmdYeni
            // 
            this.cmdYeni.Location = new System.Drawing.Point(18, 610);
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
            this.dtGridView.Location = new System.Drawing.Point(23, 24);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(749, 297);
            this.dtGridView.TabIndex = 13;
            this.dtGridView.Click += new System.EventHandler(this.dtGridView_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Üyelik Tarihi:";
            // 
            // dtUyelikTarihi
            // 
            this.dtUyelikTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtUyelikTarihi.Location = new System.Drawing.Point(125, 445);
            this.dtUyelikTarihi.Name = "dtUyelikTarihi";
            this.dtUyelikTarihi.Size = new System.Drawing.Size(647, 27);
            this.dtUyelikTarihi.TabIndex = 0;
            this.dtUyelikTarihi.Value = new System.DateTime(2022, 12, 17, 5, 28, 0, 0);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(125, 478);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(647, 82);
            this.txtAdres.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 643);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Borç Durumu";
            // 
            // FrmUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtUyelikTarihi);
            this.Controls.Add(this.cmbUyeTuru);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUyeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSil);
            this.Controls.Add(this.cmdCikis);
            this.Controls.Add(this.cmdKaydet);
            this.Controls.Add(this.cmdYeni);
            this.Controls.Add(this.dtGridView);
            this.Name = "FrmUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmUye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbUyeTuru;
        private TextBox txtTelefon;
        private TextBox txtTCKimlik;
        private Label label4;
        private Label label3;
        private TextBox txtUyeAdi;
        private Label label1;
        private Button cmdSil;
        private Button cmdCikis;
        private Button cmdKaydet;
        private Button cmdYeni;
        private DataGridView dtGridView;
        private Label label5;
        private Label label7;
        private DateTimePicker dtUyelikTarihi;
        private TextBox txtAdres;
        private Label label8;
        private Label label2;
    }
}