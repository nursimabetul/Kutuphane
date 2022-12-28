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
    public partial class FrmOduncAlma : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        public FrmOduncAlma()
        {
            InitializeComponent();
        }

        private void FrmOduncAlma_Load(object sender, EventArgs e)
        {

            LoadData(); // form açılırken kayıtları giride ekle
            cmbUyeAdi.DataSource = db.GetUye();
            cmbUyeAdi.ValueMember = "uye_id";
            cmbUyeAdi.DisplayMember = "uye_adi";
            cmbKitapAdi.DataSource = db.GetKitap();
            cmbKitapAdi.ValueMember = "kitap_id";
            cmbKitapAdi.DisplayMember = "kitap_adi";
            cmbUyeAdi.Text = "";
            cmbKitapAdi.Text = "";
            DataGridViewColumn column;
            dtGridView.Columns["oduncalma_id"].Visible = false;
            dtGridView.Columns["oduncalma_id"].Visible = false;
            dtGridView.Columns["oduncalma_uye_id"].Visible = false;
            dtGridView.Columns["oduncalma_kitap_id"].Visible = false;
            dtGridView.Columns["oduncalma_kallanici_id"].Visible = false;
            dtGridView.Columns["oduncalma_kallanici_adi"].Visible = false;
            column = dtGridView.Columns[1]; column.Width = 100;
            column = dtGridView.Columns[2]; column.Width = 100;
            column = dtGridView.Columns[4]; column.Width = 150;
            column = dtGridView.Columns[6]; column.Width = 150;
            column = dtGridView.Columns[7]; column.Width = 100;
            column = dtGridView.Columns[8]; column.Width = 100;

        }
        void LoadData()
        {
            dtGridView.DataSource = db.GetOduncAlma();
            if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
            dtGridView.Columns[0].HeaderText = "Ödünç No";
            dtGridView.Columns[1].HeaderText = "Alma Tarihi";
            dtGridView.Columns[2].HeaderText = "İade Tarihi";
            dtGridView.Columns[3].HeaderText = "Üye No";
            dtGridView.Columns[4].HeaderText = "Adı Soyadı";
            dtGridView.Columns[5].HeaderText = "Kitap No";
            dtGridView.Columns[6].HeaderText = "Kitap Adı ";
            dtGridView.Columns[7].HeaderText = "Teslim Tarihi";
            dtGridView.Columns[8].HeaderText = "Teslim Durumu";
            dtGridView.Columns[9].HeaderText = "Kullanıcı ID";
            dtGridView.Columns[10].HeaderText = "Kullacı Adi";




        }




        private void cmdKaydet_Click(object sender, EventArgs e)
        {
            if (cmdKaydet.Text == "Kaydet")
            {
                string oduncalma_tarih = dtAlmaTarihi.Value.ToString().Substring(0, 10);
                string oduncalma_iadetarihi = dtIadeTarihi.Value.ToString().Substring(0, 10);
                string oduncalma_iade_edildigitarih = dtTeslimTarihi.Value.ToString().Substring(0, 10);

                bool isSuccess = db.AddOduncAlma(oduncalma_tarih, oduncalma_iadetarihi, (int)cmbUyeAdi.SelectedValue, cmbUyeAdi.Text, (int)cmbKitapAdi.SelectedValue, cmbKitapAdi.Text, oduncalma_iade_edildigitarih, chkAktif.Checked,KullaniciBilgileri.KullaniciID,KullaniciBilgileri.KullanıcıAdı);
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
                string oduncalma_tarih = dtAlmaTarihi.Value.ToString().Substring(0, 10);
                string oduncalma_iadetarihi = dtIadeTarihi.Value.ToString().Substring(0, 10);
                string oduncalma_iade_edildigitarih = dtTeslimTarihi.Value.ToString().Substring(0, 10);
                int oduncalma_id = (int)row.Cells["oduncalma_id"].Value;
                bool isSuccess = db.UpdateOduncAlma(oduncalma_id, oduncalma_tarih, oduncalma_iadetarihi, (int)cmbUyeAdi.SelectedValue, cmbUyeAdi.Text, (int)cmbKitapAdi.SelectedValue, cmbKitapAdi.Text, oduncalma_iade_edildigitarih, chkAktif.Checked, KullaniciBilgileri.KullaniciID, KullaniciBilgileri.KullanıcıAdı);
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
            cmbUyeAdi.Text = "";
            cmbKitapAdi.Text = "";
            chkAktif.Checked = false;
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
                int oduncalma_id = (int)row.Cells["oduncalma_id"].Value;
                bool isSuccess = db.DeleteOduncAlma(oduncalma_id);
                if (isSuccess)
                {
                    MessageBox.Show("OduncAlma kaydı silindi.");
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
                dtAlmaTarihi.Text = row.Cells["oduncalma_tarih"].Value.ToString();
                dtIadeTarihi.Text = row.Cells["oduncalma_iadetarihi"].Value.ToString();
               cmbUyeAdi.Text = row.Cells["oduncalma_uye_adi"].Value.ToString();
               cmbKitapAdi.Text = row.Cells["oduncalma_kitap_adi"].Value.ToString();
                dtTeslimTarihi.Text = row.Cells["oduncalma_iade_edildigitarih"].Value.ToString();
                try
                {
                    chkAktif.Checked = (bool)row.Cells["oduncalma_iade_edildimi"].Value;
                }
                catch
                {
                    chkAktif.Checked = false;
                }




                cmdSil.Enabled = true;
                cmdKaydet.Text = "Düzelt";
                cmdKaydet.Enabled = true;
            }


        }

      
    }
}
