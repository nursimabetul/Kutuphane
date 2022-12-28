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
    public partial class FrmKitap : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        public FrmKitap()
        {
            InitializeComponent();
        }

        private void FrmKitap_Load(object sender, EventArgs e)
        {

            LoadData(); // form açılırken kayıtları giride ekle
            cmbYayinci.DataSource = db.GetYayinci();
            cmbYazar.DataSource = db.GetYazar();
            cmbTur.DataSource = db.GetTur();
            cmbBolum.DataSource = db.GetBolum();
            cmbKategori.DataSource = db.GetKategori();
            cmbDil.DataSource = db.GetDil();
            cmbRaf.DataSource = db.GetRaf();

            cmbYayinci.ValueMember = "yayinci_id";
            cmbYayinci.DisplayMember = "yayinci_adi";
            cmbYayinci.Text = "";
            cmbYazar.ValueMember = "yazar_id";
            cmbYazar.DisplayMember = "yazar_adi";
            cmbYazar.Text = "";
            cmbTur.ValueMember = "tur_id";
            cmbTur.DisplayMember = "tur_adi";
            cmbTur.Text = "";
            cmbBolum.ValueMember = "bolum_id";
            cmbBolum.DisplayMember = "bolum_adi";
            cmbBolum.Text = "";
            cmbKategori.ValueMember = "kategori_id";
            cmbKategori.DisplayMember = "kategori_adi";
            cmbKategori.Text = "";
            cmbDil.ValueMember = "dil_id";
            cmbDil.DisplayMember = "dil_adi";
            cmbDil.Text = "";
            cmbRaf.ValueMember = "raf_id";
            cmbRaf.DisplayMember = "raf_adi";
            cmbRaf.Text = "";             

            DataGridViewColumn column;
            dtGridView.Columns["kitap_id"].Visible = false;
            dtGridView.Columns["yayinci_id"].Visible = false;
            dtGridView.Columns["yazar_id"].Visible = false;
            dtGridView.Columns["tur_id"].Visible = false;
            dtGridView.Columns["tur_adi"].Visible = false;
            dtGridView.Columns["bolum_id"].Visible = false;
            dtGridView.Columns["bolum_adi"].Visible = false;
            dtGridView.Columns["kategori_id"].Visible = false;
            dtGridView.Columns["kategori_adi"].Visible = false;
            dtGridView.Columns["dil_id"].Visible = false;
            dtGridView.Columns["dil_adi"].Visible = false;
            dtGridView.Columns["raf_id"].Visible = false;
            dtGridView.Columns["raf_adi"].Visible = false;
            dtGridView.Columns["kitap_sayfasayisi"].Visible = false;
            dtGridView.Columns["kitap_basimtarihi"].Visible = false;
            dtGridView.Columns["kitap_odunclaindi"].Visible = false;

            column = dtGridView.Columns[0]; column.Width = 0;
            column = dtGridView.Columns[1]; column.Width = 200;
            column = dtGridView.Columns[2]; column.Width = 100;
            column = dtGridView.Columns[3]; column.Width = 0;
            column = dtGridView.Columns[4]; column.Width = 150;
            column = dtGridView.Columns[5]; column.Width = 100;
            column = dtGridView.Columns[6]; column.Width = 200;
            column = dtGridView.Columns[7]; column.Width = 200;


        }
        void LoadData()
        {
            dtGridView.DataSource = db.GetKitap();
            if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
            dtGridView.Columns[0].HeaderText = "Kitap No";
            dtGridView.Columns[1].HeaderText = "Kitap Adı";
            dtGridView.Columns[2].HeaderText = "ISBN";
            dtGridView.Columns[3].HeaderText = "yayinci_id";
            dtGridView.Columns[4].HeaderText = "Yayıncı Adı";
            dtGridView.Columns[6].HeaderText = "Yazar Adı";



        }




        private void cmdKaydet_Click(object sender, EventArgs e)
        {
            if (cmdKaydet.Text == "Kaydet")
            {
                string kitapBasımTarihi = dtBasımTarihi.Value.ToString().Substring(0, 10);

                bool isSuccess = db.AddKitap(txtISBN.Text, txtKitapAdı.Text, (int)cmbYayinci.SelectedValue, (int)cmbYazar.SelectedValue, (int)cmbTur.SelectedValue, (int)cmbBolum.SelectedValue, (int)cmbKategori.SelectedValue, (int)cmbDil.SelectedValue, (int)cmbRaf.SelectedValue, int.Parse(txtSayfaSayısı.Text), kitapBasımTarihi, chkOduncVerildi.Checked);
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
                int kitap_id = (int)row.Cells["kitap_id"].Value;
                string kitapBasımTarihi = dtBasımTarihi.Value.ToString().Substring(0, 10);

                bool isSuccess = db.UpdateKitap(kitap_id, txtISBN.Text, txtKitapAdı.Text, (int)cmbYayinci.SelectedValue, (int)cmbYazar.SelectedValue, (int)cmbTur.SelectedValue, (int)cmbBolum.SelectedValue, (int)cmbKategori.SelectedValue, (int)cmbDil.SelectedValue, (int)cmbRaf.SelectedValue,int.Parse( txtSayfaSayısı.Text), kitapBasımTarihi, chkOduncVerildi.Checked);
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
            txtKitapAdı.Text = "";
            txtISBN.Text = "";
             cmbYayinci.Text = "";
            cmbYazar.Text = "";
            cmbTur.Text = "";
            cmbBolum.Text = "";
            cmbKategori.Text = "";
            cmbDil.Text = "";
            cmbRaf.Text = "";
            txtSayfaSayısı.Text = "";
            dtBasımTarihi.Text = "";
            chkOduncVerildi.Checked = false;
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
                int kitap_id = (int)row.Cells["kitap_id"].Value;
                bool isSuccess = db.DeleteKitap(kitap_id);

                if (isSuccess)
                {
                    MessageBox.Show("Kitap kaydı silindi.");
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
                txtKitapAdı.Text = row.Cells["kitap_adi"].Value.ToString();
                txtISBN.Text = row.Cells["kitap_isbn"].Value.ToString();
                cmbYayinci.Text = row.Cells["yayinci_adi"].Value.ToString();
                cmbYazar.Text = row.Cells["yazar_adi"].Value.ToString();
                cmbTur.Text = row.Cells["tur_adi"].Value.ToString();
                cmbBolum.Text = row.Cells["bolum_adi"].Value.ToString();
                cmbKategori.Text = row.Cells["kategori_adi"].Value.ToString();
                cmbDil.Text = row.Cells["dil_adi"].Value.ToString();
                cmbRaf.Text = row.Cells["raf_adi"].Value.ToString();
                txtSayfaSayısı.Text = row.Cells["kitap_sayfasayisi"].Value.ToString();
                dtBasımTarihi.Text = row.Cells["kitap_basimtarihi"].Value.ToString();

                try
                {
                    chkOduncVerildi.Checked = (bool)row.Cells["kitap_odunclaindi"].Value;
                }
                catch
                {
                    chkOduncVerildi.Checked = false;
                }
                cmdSil.Enabled = true;
                cmdKaydet.Text = "Düzelt";
                cmdKaydet.Enabled = true;
            }


        }

        
    }
}
