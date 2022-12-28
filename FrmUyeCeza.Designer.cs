namespace Kutuphane
{
    partial class FrmUyeCeza
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
            this.cmbUyeAdi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUyeAdi
            // 
            this.cmbUyeAdi.FormattingEnabled = true;
            this.cmbUyeAdi.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbUyeAdi.Location = new System.Drawing.Point(139, 12);
            this.cmbUyeAdi.Name = "cmbUyeAdi";
            this.cmbUyeAdi.Size = new System.Drawing.Size(899, 28);
            this.cmbUyeAdi.TabIndex = 58;
            this.cmbUyeAdi.Text = "Tüm Cezalar (Üye seçiniz.)";
            this.cmbUyeAdi.SelectedIndexChanged += new System.EventHandler(this.cmbUyeAdi_SelectedIndexChanged);
            this.cmbUyeAdi.Click += new System.EventHandler(this.cmbUyeAdi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Adı Soyad:";
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.AllowUserToResizeColumns = false;
            this.dtGridView.AllowUserToResizeRows = false;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtGridView.Location = new System.Drawing.Point(26, 46);
            this.dtGridView.MultiSelect = false;
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(1012, 486);
            this.dtGridView.TabIndex = 53;
            // 
            // FrmUyeCeza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 553);
            this.Controls.Add(this.cmbUyeAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGridView);
            this.Name = "FrmUyeCeza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUyeCeza";
            this.Load += new System.EventHandler(this.FrmUyeCeza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbUyeAdi;
        private Label label4;
        private DataGridView dtGridView;
    }
}