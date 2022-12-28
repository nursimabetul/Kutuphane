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
    public partial class FrmKullanici : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        public FrmKullanici()
        {
            InitializeComponent();
        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
        
            LoadData(); // form açılırken kayıtları giride ekle

            cmbKullaniciTuru.DataSource = db.GetKullaniciTuru();
            cmbKullaniciTuru.Text="";


            cmbKullaniciTuru.ValueMember = "kullanicituru_id";
            cmbKullaniciTuru.DisplayMember = "kullanicituru_adi";




            DataGridViewColumn column;
            dtGridView.Columns["kullanici_id"].Visible = false;
            dtGridView.Columns["kullanici_sifre"].Visible = false;
            dtGridView.Columns["kullanici_turu_id"].Visible = false;
            dtGridView.Columns["kullanici_girisdeneme"].Visible = false; 
            column = dtGridView.Columns[0]; column.Width = 0;
            column = dtGridView.Columns[1]; column.Width = 200;
            column = dtGridView.Columns[2]; column.Width = 200;
            column = dtGridView.Columns[3]; column.Width = 0;
            column = dtGridView.Columns[4]; column.Width = 0;
            column = dtGridView.Columns[5]; column.Width = 150;
            column = dtGridView.Columns[6]; column.Width = 100;
            column = dtGridView.Columns[7]; column.Width = 0;




        }
        void LoadData()
        {
            dtGridView.DataSource = db.GetKullanici();
            if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
            dtGridView.Columns[0].HeaderText = "Kullanıcı No";
            dtGridView.Columns[1].HeaderText = "Adı Soyadı";
            dtGridView.Columns[2].HeaderText = "Kullanıcı Adı";
            dtGridView.Columns[3].HeaderText = "Şifre";
            dtGridView.Columns[4].HeaderText = "Kullanıcı Türü No";
            dtGridView.Columns[5].HeaderText = "Kullanıcı Türü";
            dtGridView.Columns[6].HeaderText = "Aktif ";
            dtGridView.Columns[7].HeaderText = "Giriş Deneme Sayısı";

        }


        private void cmdKaydet_Click(object sender, EventArgs e)
        {
            if (cmdKaydet.Text == "Kaydet")
            {
                bool isSuccess = db.AddKullanici(txtKullaniciAdiSoyadi.Text, txtKullaniciAdi.Text, txtKullaniciSifre.Text, cmbKullaniciTuru.Text, chkAktif.Checked, int.Parse(txtKullaniciDeneme.Text));
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
                int kullanici_id = (int)row.Cells["kullanici_id"].Value;
                bool isSuccess = db.UpdateKullanici(kullanici_id, txtKullaniciAdiSoyadi.Text, txtKullaniciAdi.Text, txtKullaniciSifre.Text, cmbKullaniciTuru.Text, chkAktif.Checked, int.Parse(txtKullaniciDeneme.Text));
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
            txtKullaniciAdiSoyadi.Text = "";
            txtKullaniciAdi.Text = "";
            txtKullaniciSifre.Text = "";
            cmbKullaniciTuru.Text = "";
            chkAktif.Checked = false ;
            txtKullaniciDeneme.Text = "";
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
                int kullanici_id = (int)row.Cells["kullanici_id"].Value;
                bool isSuccess = db.DeleteKullanici(kullanici_id);
                if (isSuccess)
                {
                    MessageBox.Show("Kullanici kaydı silindi.");
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
                txtKullaniciAdiSoyadi.Text = row.Cells["kullanici_adisoyadi"].Value.ToString();
                txtKullaniciAdi.Text = row.Cells["kullanici_adi"].Value.ToString();
                txtKullaniciSifre.Text = row.Cells["kullanici_sifre"].Value.ToString();
                cmbKullaniciTuru.Text = row.Cells["kullanici_turu"].Value.ToString();

                try
                {
                    chkAktif.Checked = (bool)row.Cells["kullanici_durumu"].Value;
                }
                catch
                {
                    chkAktif.Checked = false;
                }
                txtKullaniciDeneme.Text = row.Cells["kullanici_girisdeneme"].Value.ToString();
                cmdSil.Enabled = true;
                cmdKaydet.Text = "Düzelt";
                cmdKaydet.Enabled = true;
            }


        }

       
    }
}
