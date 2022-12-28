namespace Kutuphane
{
    partial class FrmYazar
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
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSil = new System.Windows.Forms.Button();
            this.cmdCikis = new System.Windows.Forms.Button();
            this.cmdKaydet = new System.Windows.Forms.Button();
            this.cmdYeni = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(152, 452);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(547, 27);
            this.txtYazarAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yazar Adı Soyadı:";
            // 
            // cmdSil
            // 
            this.cmdSil.Enabled = false;
            this.cmdSil.Location = new System.Drawing.Point(372, 496);
            this.cmdSil.Name = "cmdSil";
            this.cmdSil.Size = new System.Drawing.Size(144, 29);
            this.cmdSil.TabIndex = 0;
            this.cmdSil.Text = "Sil";
            this.cmdSil.UseVisualStyleBackColor = true;
            this.cmdSil.Click += new System.EventHandler(this.cmdSil_Click);
            // 
            // cmdCikis
            // 
            this.cmdCikis.Location = new System.Drawing.Point(546, 496);
            this.cmdCikis.Name = "cmdCikis";
            this.cmdCikis.Size = new System.Drawing.Size(144, 29);
            this.cmdCikis.TabIndex = 0;
            this.cmdCikis.Text = "Kapat";
            this.cmdCikis.UseVisualStyleBackColor = true;
            this.cmdCikis.Click += new System.EventHandler(this.cmdCikis_Click);
            // 
            // cmdKaydet
            // 
            this.cmdKaydet.Enabled = false;
            this.cmdKaydet.Location = new System.Drawing.Point(196, 496);
            this.cmdKaydet.Name = "cmdKaydet";
            this.cmdKaydet.Size = new System.Drawing.Size(144, 29);
            this.cmdKaydet.TabIndex = 0;
            this.cmdKaydet.Text = "Kaydet";
            this.cmdKaydet.UseVisualStyleBackColor = true;
            this.cmdKaydet.Click += new System.EventHandler(this.cmdKaydet_Click);
            // 
            // cmdYeni
            // 
            this.cmdYeni.Location = new System.Drawing.Point(23, 496);
            this.cmdYeni.Name = "cmdYeni";
            this.cmdYeni.Size = new System.Drawing.Size(144, 29);
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
            this.dtGridView.Location = new System.Drawing.Point(23, 27);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(676, 400);
            this.dtGridView.TabIndex = 4;
            this.dtGridView.Click += new System.EventHandler(this.dtGridView_Click);
            // 
            // FrmYazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 549);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSil);
            this.Controls.Add(this.cmdCikis);
            this.Controls.Add(this.cmdKaydet);
            this.Controls.Add(this.cmdYeni);
            this.Controls.Add(this.dtGridView);
            this.Name = "FrmYazar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmYazar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtYazarAdi;
        private Label label1;
        private Button cmdSil;
        private Button cmdCikis;
        private Button cmdKaydet;
        private Button cmdYeni;
        private DataGridView dtGridView;
    }
}