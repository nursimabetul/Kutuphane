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

    public partial class FrmUyeTuru : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        public FrmUyeTuru()
        {
            InitializeComponent();
        }

        private void FrmUyeTuru_Load(object sender, EventArgs e)
        {
            LoadData(); // form açılırken kayıtları giride ekle
            DataGridViewColumn column;
            column = dtGridView.Columns[0]; column.Width = 0;
            column = dtGridView.Columns[1]; column.Width = 240;
            column = dtGridView.Columns[2]; column.Width = 150;
            column = dtGridView.Columns[3]; column.Width = 150;
            dtGridView.Columns["uyeturu_id"].Visible = false;

        }
        void LoadData()
        {
            dtGridView.DataSource = db.GetUyeTuru();
            if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
            dtGridView.Columns[0].HeaderText = "Üye Türü No";
            dtGridView.Columns[1].HeaderText = "Üye Türü";
            dtGridView.Columns[2].HeaderText = "Maksimum Kitap";
            dtGridView.Columns[3].HeaderText = "Günlük Ceza";
        }


        private void cmdKaydet_Click(object sender, EventArgs e)
        {
            if (cmdKaydet.Text == "Kaydet")
            {
                bool isSuccess = db.AddUyeTuru(txtUyeTuruAdi.Text, int.Parse(txtMaksimumKitap.Text), double.Parse(txtGunlukCeza.Text));
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
                int uyeturu_id = (int)row.Cells["uyeturu_id"].Value;
                bool isSuccess = db.UpdateUyeTuru(uyeturu_id, txtUyeTuruAdi.Text, int.Parse(txtMaksimumKitap.Text), double.Parse(txtGunlukCeza.Text));
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
            txtUyeTuruAdi.Text = "";
            txtMaksimumKitap.Text = "";
            txtGunlukCeza.Text = "";

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
                int uyeturu_id = (int)row.Cells["uyeturu_id"].Value;
                bool isSuccess = db.DeleteUyeTuru(uyeturu_id);
                if (isSuccess)
                {
                    MessageBox.Show("Üye Türü kaydı silindi.");
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
                txtUyeTuruAdi.Text = row.Cells["uyeturu_adi"].Value.ToString();
                txtMaksimumKitap.Text = row.Cells["uyeturu_maks_kitap"].Value.ToString();
                txtGunlukCeza.Text = row.Cells["uyeturu_gun_ceza"].Value.ToString();
                cmdSil.Enabled = true;
                cmdKaydet.Text = "Düzelt";
                cmdKaydet.Enabled = true;
            }


        }
    }
}
