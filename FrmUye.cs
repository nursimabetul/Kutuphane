using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Kutuphane
{
    public partial class FrmUye : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        public FrmUye()
        {
            InitializeComponent();
        }

        private void FrmUye_Load(object sender, EventArgs e)
        {

            LoadData(); // form açılırken kayıtları giride ekle
            cmbUyeTuru.DataSource = db.GetUyeTuru();
            cmbUyeTuru.ValueMember = "uyeturu_id";
            cmbUyeTuru.DisplayMember = "uyeturu_adi";

            DataGridViewColumn column;
            dtGridView.Columns["uye_id"].Visible = false;
            dtGridView.Columns["uye_telefon"].Visible = false;
            dtGridView.Columns["uye_uyeliktarihi"].Visible = false;
            dtGridView.Columns["uye_adresi"].Visible = false;
            dtGridView.Columns["uyeturu_id"].Visible = false;
            column = dtGridView.Columns[0]; column.Width = 0;
            column = dtGridView.Columns[1]; column.Width = 200;
            column = dtGridView.Columns[2]; column.Width = 200;
            column = dtGridView.Columns[3]; column.Width = 0;
            column = dtGridView.Columns[4]; column.Width = 150;
            column = dtGridView.Columns[5]; column.Width = 100;
            column = dtGridView.Columns[6]; column.Width = 0;
            column = dtGridView.Columns[7]; column.Width = 200;




        }
        void LoadData()
        {
            dtGridView.DataSource = db.GetUye();
            if (dtGridView.RowCount == 1) cmdSil.Enabled = false;
            dtGridView.Columns[0].HeaderText = "Üye No";
            dtGridView.Columns[1].HeaderText = "Adı Soyadı";
            dtGridView.Columns[2].HeaderText = "TC Kimlik No";
            dtGridView.Columns[3].HeaderText = "Telefon";
            dtGridView.Columns[4].HeaderText = "Üyelik Tarihi";
            dtGridView.Columns[5].HeaderText = "Adresi ";
            dtGridView.Columns[6].HeaderText = "Üye Türü No";
            dtGridView.Columns[7].HeaderText = "Üye Türü";


        }




        private void cmdKaydet_Click(object sender, EventArgs e)
        {
            if (cmdKaydet.Text == "Kaydet")
            {
                string uyerlikTarihi = dtUyelikTarihi.Value.ToString().Substring(0, 10);

                bool isSuccess = db.AddUye(txtUyeAdi.Text, txtTCKimlik.Text, txtTelefon.Text, uyerlikTarihi, txtAdres.Text, (int)cmbUyeTuru.SelectedValue);
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
                int uye_id = (int)row.Cells["uye_id"].Value;
                bool isSuccess = db.UpdateUye(uye_id, txtUyeAdi.Text, txtTCKimlik.Text, txtTelefon.Text, dtUyelikTarihi.Text, txtAdres.Text, (int)cmbUyeTuru.SelectedValue);
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
            txtUyeAdi.Text = "";
            txtTCKimlik.Text = "";
            txtTelefon.Text = "";
            dtUyelikTarihi.Text = "";
            txtAdres.Text = "";
            cmbUyeTuru.Text = "";
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
                int uye_id = (int)row.Cells["uye_id"].Value;
                bool isSuccess = db.DeleteUye(uye_id);
                if (isSuccess)
                {
                    MessageBox.Show("Uye kaydı silindi.");
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
                txtUyeAdi.Text = row.Cells["uye_adi"].Value.ToString();
                txtTCKimlik.Text = row.Cells["uye_kimlikno"].Value.ToString();
                txtTelefon.Text = row.Cells["uye_telefon"].Value.ToString();
                dtUyelikTarihi.Text = row.Cells["uye_uyeliktarihi"].Value.ToString();
                txtAdres.Text = row.Cells["uye_adresi"].Value.ToString();
                cmbUyeTuru.Text = row.Cells["uyeturu_adi"].Value.ToString();
                cmdSil.Enabled = true;
                cmdKaydet.Text = "Düzelt";
                cmdKaydet.Enabled = true;



                try
                {

                    NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; Password=pass;Database=postgres;");
                    conn.Open();// PostgreSQL veritabanına bağlan
                    NpgsqlTransaction tran = conn.BeginTransaction();       // PostgreSQL'de bir işlem başlat
                    NpgsqlCommand command = new NpgsqlCommand("uye_borc_info_getir", conn);// kullanıcı getir fonksiyonunu tanımla 
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new NpgsqlParameter("@prm_uye_id", int.Parse(row.Cells["uye_id"].Value.ToString()))); // kullanıcı adı parametresini ekle.
                    NpgsqlDataReader dr = command.ExecuteReader();// Efonksiyonu çalıştır.
                    if (dr.Read() == false)
                        label2.Text = "Borç Durumu: borcu yok";
                    else
                            if (dr[0] == DBNull.Value)
                        label2.Text = "Borç Durumu: borcu yok";
                    else
                        label2.Text = "Borç Durumu: " + (decimal)dr[0] + "TL borcu var.";
                }
                catch (Exception ex) { label2.Text = ex.Message; }
            }






        }


    }
}
