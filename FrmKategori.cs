using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class FrmKategori : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        public FrmKategori()
        {
            InitializeComponent();
        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            LoadData(); // form açılırken kayıtları giride ekle
            DataGridViewColumn column;
            column = dtGridView.Columns[0];
            column.Width = 120;
            column = dtGridView.Columns[1];
            column.Width = 300;
            dtGridView.Columns["kategori_id"].Visible = false;

        }
        void LoadData()
        {
            dtGridView.DataSource = db.GetKategori();
            if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
            dtGridView.Columns[0].HeaderText = "Kategori No";
            dtGridView.Columns[1].HeaderText = "Kategori Adı";

        }


        private void cmdKaydet_Click(object sender, EventArgs e)
        {
            if (cmdKaydet.Text == "Kaydet")
            {
                bool isSuccess = db.AddKategori(txtKategoriAdi.Text);
                if (isSuccess)
                {
                    MessageBox.Show("Yeni kayıt yapıldı.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Kayıt hatası oluştu.");
                }

            }
            else
            {
                var row = dtGridView.SelectedRows[0];
                int kategori_id = (int)row.Cells["kategori_id"].Value;
                bool isSuccess = db.UpdateKategori(kategori_id, txtKategoriAdi.Text);
                if (isSuccess)
                {
                    MessageBox.Show("Kayıt güncellendi.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Güncelleme hatası oluştu.");
                }

            }
            LoadData();
            TextTemizle();
            cmdKaydet.Enabled = false;

            cmdSil.Enabled = false;
            dtGridView.Enabled = true;
            cmdYeni.Text = "Yeni";
            cmdKaydet.Enabled = false;
        }

        private void cmdYeni_Click(object sender, EventArgs e)
        {
            if (cmdYeni.Text == "Yeni")
            {
                cmdKaydet.Enabled = true;
                cmdKaydet.Text = "Kaydet";
                cmdSil.Enabled = false;
                dtGridView.Enabled = false;
                cmdYeni.Text = "İptal";
            }



            else
            {
                //Yeni İptal
                dtGridView.Enabled = true;
                cmdYeni.Text = "Yeni";
                cmdKaydet.Enabled = false;
            }
                TextTemizle();


        }
        private void TextTemizle()
        {
            txtKategoriAdi.Text = "";
        }
        private void cmdCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSil_Click(object sender, EventArgs e)
        {
            if (dtGridView.SelectedRows.Count == 1)
            {
                var row = dtGridView.SelectedRows[0];
                int kategori_id = (int)row.Cells["kategori_id"].Value;
                bool isSuccess = db.DeleteKategori(kategori_id);
                if (isSuccess)
                {
                    MessageBox.Show("Kategori kaydı silindi.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Silme hatası oluştu.");
                }

                LoadData();
                TextTemizle();
                cmdKaydet.Enabled = false;

                cmdSil.Enabled = false;
                dtGridView.Enabled = true;
                cmdYeni.Text = "Yeni";
                cmdKaydet.Enabled = false;

            }
        }

     

        private void dtGridView_Click(object sender, EventArgs e)
        {
            if (dtGridView.SelectedRows.Count == 0) return; // seçilen row yoksa 

                if (dtGridView.SelectedRows.Count == 1) // row seçilmişse
            {
                var row = dtGridView.SelectedRows[0];
                txtKategoriAdi.Text = row.Cells["kategori_adi"].Value.ToString();
                cmdSil.Enabled = true;
                cmdKaydet.Text = "Düzelt";
                cmdKaydet.Enabled = true;
            }


        }
    }
}
