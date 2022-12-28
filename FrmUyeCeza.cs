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
    public partial class FrmUyeCeza : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        bool dataLoaded = false;
        public FrmUyeCeza()
        {
            InitializeComponent();
        }

        private void FrmUyeCeza_Load(object sender, EventArgs e)
        {
            dtGridView.DataSource = db.GetUyeTumCeza();
                ListeDuzenle();




        }

        private void cmbUyeAdi_Click(object sender, EventArgs e)
        {
            if (dataLoaded == false)
            {
                cmbUyeAdi.DataSource = db.GetUye();
                cmbUyeAdi.ValueMember = "uye_id";
                cmbUyeAdi.DisplayMember = "uye_adi";
                dataLoaded = true;

            }

        }

        

      private void ListeDuzenle()
        {
            DataGridViewColumn column;
            dtGridView.Columns["uyeceza_id"].Visible = false;
            dtGridView.Columns["oduncalma_id"].Visible = false;
            dtGridView.Columns["uye_id"].Visible = false;

            column = dtGridView.Columns[0]; column.Width = 0;
            column = dtGridView.Columns[1]; column.Width = 0;
            column = dtGridView.Columns[2]; column.Width = 0;
            column = dtGridView.Columns[3]; column.Width = 150;
            column = dtGridView.Columns[4]; column.Width = 150;
            column = dtGridView.Columns[5]; column.Width = 200;
            column = dtGridView.Columns[6]; column.Width = 150;
            column = dtGridView.Columns[7]; column.Width = 200;




            dtGridView.Columns[0].HeaderText = "uyeceza_id";
            dtGridView.Columns[1].HeaderText = "oduncalma_id";
            dtGridView.Columns[2].HeaderText = "uye_id";
            dtGridView.Columns[3].HeaderText = "İade Tarihi";
            dtGridView.Columns[4].HeaderText = "Adı Soyadı";
            dtGridView.Columns[5].HeaderText = "Kitap Adı";
            dtGridView.Columns[6].HeaderText = "Ceza Miktarı";
            dtGridView.Columns[7].HeaderText = "Teslim Alan Kullanıcı";

                /*

            uyeceza_id, 
			oduncalma_id, 
			uye_id, 
			oduncalma_iade_edildigitarih, 
			oduncalma_uye_adi, 
			oduncalma_kitap_adi, 
			uyeceza_miktari, 
			oduncalma_kallanici_adi*/


        }

        private void cmbUyeAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataLoaded)
            if (cmbUyeAdi.Text == "")
                dtGridView.DataSource = db.GetUyeTumCeza();
            else
                dtGridView.DataSource = db.GetSeciliUyeCeza((int)cmbUyeAdi.SelectedValue);
            ListeDuzenle();
        }
    }
}
