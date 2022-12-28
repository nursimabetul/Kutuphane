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
    public partial class FrmYayinci : Form
    {
        
            DatabaseKaynak db = new DatabaseKaynak();
            public FrmYayinci()
            {
                InitializeComponent();
            }

            private void FrmYayinci_Load(object sender, EventArgs e)
            {
                LoadData(); // form açılırken kayıtları giride ekle
                DataGridViewColumn column;
                column = dtGridView.Columns[0];
                column.Width = 0;
                column = dtGridView.Columns[1];
                column.Width = 420;
                dtGridView.Columns["yayinci_id"].Visible = false;

        }
        void LoadData()
            {
                dtGridView.DataSource = db.GetYayinci();
                if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
                dtGridView.Columns[0].HeaderText = "Yayıncı No";
                dtGridView.Columns[1].HeaderText = "Yayıncı Adı";

            }


            private void cmdKaydet_Click(object sender, EventArgs e)
            {
                if (cmdKaydet.Text == "Kaydet")
                {
                    bool isSuccess = db.AddYayinci(txtYayinciAdi.Text);
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
                    int yayinci_id = (int)row.Cells["yayinci_id"].Value;
                    bool isSuccess = db.UpdateYayinci(yayinci_id, txtYayinciAdi.Text);
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
                txtYayinciAdi.Text = "";
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
                    int yayinci_id = (int)row.Cells["yayinci_id"].Value;
                    bool isSuccess = db.DeleteYayinci(yayinci_id);
                    if (isSuccess)
                    {
                        MessageBox.Show("Yayıncı kaydı silindi.");
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
                    txtYayinciAdi.Text = row.Cells["yayinci_adi"].Value.ToString();
                    cmdSil.Enabled = true;
                    cmdKaydet.Text = "Düzelt";
                    cmdKaydet.Enabled = true;
                }


            }
    }
    }
