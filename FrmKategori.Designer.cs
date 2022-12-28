namespace Kutuphane
{
    partial class FrmKategori
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
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.cmdYeni = new System.Windows.Forms.Button();
            this.cmdKaydet = new System.Windows.Forms.Button();
            this.cmdCikis = new System.Windows.Forms.Button();
            this.cmdSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.AllowUserToResizeColumns = false;
            this.dtGridView.AllowUserToResizeRows = false;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtGridView.Location = new System.Drawing.Point(12, 25);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(565, 282);
            this.dtGridView.TabIndex = 0;
            this.dtGridView.Click += new System.EventHandler(this.dtGridView_Click);
            // 
            // cmdYeni
            // 
            this.cmdYeni.Location = new System.Drawing.Point(12, 373);
            this.cmdYeni.Name = "cmdYeni";
            this.cmdYeni.Size = new System.Drawing.Size(125, 29);
            this.cmdYeni.TabIndex = 0;
            this.cmdYeni.Text = "Yeni";
            this.cmdYeni.UseVisualStyleBackColor = true;
            this.cmdYeni.Click += new System.EventHandler(this.cmdYeni_Click);
            // 
            // cmdKaydet
            // 
            this.cmdKaydet.Enabled = false;
            this.cmdKaydet.Location = new System.Drawing.Point(162, 373);
            this.cmdKaydet.Name = "cmdKaydet";
            this.cmdKaydet.Size = new System.Drawing.Size(125, 29);
            this.cmdKaydet.TabIndex = 0;
            this.cmdKaydet.Text = "Kaydet";
            this.cmdKaydet.UseVisualStyleBackColor = true;
            this.cmdKaydet.Click += new System.EventHandler(this.cmdKaydet_Click);
            // 
            // cmdCikis
            // 
            this.cmdCikis.Location = new System.Drawing.Point(452, 373);
            this.cmdCikis.Name = "cmdCikis";
            this.cmdCikis.Size = new System.Drawing.Size(125, 29);
            this.cmdCikis.TabIndex = 0;
            this.cmdCikis.Text = "Kapat";
            this.cmdCikis.UseVisualStyleBackColor = true;
            this.cmdCikis.Click += new System.EventHandler(this.cmdCikis_Click);
            // 
            // cmdSil
            // 
            this.cmdSil.Enabled = false;
            this.cmdSil.Location = new System.Drawing.Point(306, 373);
            this.cmdSil.Name = "cmdSil";
            this.cmdSil.Size = new System.Drawing.Size(125, 29);
            this.cmdSil.TabIndex = 0;
            this.cmdSil.Text = "Sil";
            this.cmdSil.UseVisualStyleBackColor = true;
            this.cmdSil.Click += new System.EventHandler(this.cmdSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı:";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(126, 327);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(451, 27);
            this.txtKategoriAdi.TabIndex = 0;
            // 
            // FrmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 418);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSil);
            this.Controls.Add(this.cmdCikis);
            this.Controls.Add(this.cmdKaydet);
            this.Controls.Add(this.cmdYeni);
            this.Controls.Add(this.dtGridView);
            this.Name = "FrmKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Kategori Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtGridView;
        private Button cmdYeni;
        private Button cmdKaydet;
        private Button cmdCikis;
        private Button cmdSil;
        private Label label1;
        private TextBox txtKategoriAdi;
    }
}