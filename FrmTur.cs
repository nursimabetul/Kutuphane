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
    public partial class FrmTur : Form
    {

        DatabaseKaynak db = new DatabaseKaynak();
        public FrmTur()
        {
            InitializeComponent();
        }

        private void FrmTur_Load(object sender, EventArgs e)
        {
            LoadData(); // form açılırken kayıtları giride ekle
            DataGridViewColumn column;
            column = dtGridView.Columns[0];
            column.Width = 0;
            column = dtGridView.Columns[1];
            column.Width = 320;
            dtGridView.Columns["tur_id"].Visible = false;

        }
        void LoadData()
        {
            dtGridView.DataSource = db.GetTur();
            if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
            dtGridView.Columns[0].HeaderText = "Tur No";
            dtGridView.Columns[1].HeaderText = "Tur Adı";

        }


        private void cmdKaydet_Click(object sender, EventArgs e)
        {
            if (cmdKaydet.Text == "Kaydet")
            {
                bool isSuccess = db.AddTur(txtTurAdi.Text);
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
                int tur_id = (int)row.Cells["tur_id"].Value;
                bool isSuccess = db.UpdateTur(tur_id, txtTurAdi.Text);
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
            txtTurAdi.Text = "";
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
                int tur_id = (int)row.Cells["tur_id"].Value;
                bool isSuccess = db.DeleteTur(tur_id);
                if (isSuccess)
                {
                    MessageBox.Show("Tur kaydı silindi.");
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
                txtTurAdi.Text = row.Cells["tur_adi"].Value.ToString();
                cmdSil.Enabled = true;
                cmdKaydet.Text = "Düzelt";
                cmdKaydet.Enabled = true;
            }


        }
    }
}
