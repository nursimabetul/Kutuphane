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
    public partial class FrmUyeOdeme : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        public FrmUyeOdeme()
        {
            InitializeComponent();
        }

        private void FrmUyeOdeme_Load(object sender, EventArgs e)
        {

            LoadData(); // form açılırken kayıtları giride ekle
            cmbUyeAdi.DataSource = db.GetUye();
            cmbUyeAdi.ValueMember = "uye_id";
            cmbUyeAdi.DisplayMember = "uye_adi";

            DataGridViewColumn column;
            dtGridView.Columns["uyeodeme_id"].Visible = false;
            dtGridView.Columns["uyeodeme_uye_id"].Visible = false;

            column = dtGridView.Columns[0]; column.Width = 0;
            column = dtGridView.Columns[1]; column.Width = 0;
            column = dtGridView.Columns[2]; column.Width = 200;
            column = dtGridView.Columns[3]; column.Width = 150;
            column = dtGridView.Columns[4]; column.Width = 150;


        }
        void LoadData()
        {
            dtGridView.DataSource = db.GetUyeOdeme();
            if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
            dtGridView.Columns[0].HeaderText = "Ödeme No";
            dtGridView.Columns[1].HeaderText = "Üye No";
            dtGridView.Columns[2].HeaderText = "Adı Soyadı";
            dtGridView.Columns[3].HeaderText = "Tarih";
            dtGridView.Columns[4].HeaderText = "Miktar";


        }




        private void cmdKaydet_Click(object sender, EventArgs e)
        {
            if (cmdKaydet.Text == "Kaydet")
            {
                string uyeodemerlikTarihi = dtOdemeTarihi.Value.ToString().Substring(0, 10);

                bool isSuccess = db.AddUyeOdeme((int)cmbUyeAdi.SelectedValue, cmbUyeAdi.Text, uyeodemerlikTarihi, double.Parse(txtOdemeMiktari.Text));
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
                string uyeodemerlikTarihi = dtOdemeTarihi.Value.ToString().Substring(0, 10);

                int uyeodeme_id = (int)row.Cells["uyeodeme_id"].Value;
                bool isSuccess = db.UpdateUyeOdeme(uyeodeme_id, (int)cmbUyeAdi.SelectedValue, cmbUyeAdi.Text, uyeodemerlikTarihi, double.Parse(txtOdemeMiktari.Text));
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
            dtOdemeTarihi.Text = "";
            txtOdemeMiktari.Text = "";
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
                int uyeodeme_id = (int)row.Cells["uyeodeme_id"].Value;
                bool isSuccess = db.DeleteUyeOdeme(uyeodeme_id);
                if (isSuccess)
                {
                    MessageBox.Show("UyeOdeme kaydı silindi.");
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
                cmbUyeAdi.Text = row.Cells["uyeodeme_uye_adi"].Value.ToString();
                dtOdemeTarihi.Text = row.Cells["uyeodeme_tarihi"].Value.ToString();

                txtOdemeMiktari.Text = row.Cells["uyeodeme_miktari"].Value.ToString();
                cmdSil.Enabled = true;
                cmdKaydet.Text = "Düzelt";
                cmdKaydet.Enabled = true;
            }


        }


    }
}
