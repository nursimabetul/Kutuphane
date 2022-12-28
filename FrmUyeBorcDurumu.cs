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
    public partial class FrmUyeBorcDurumu : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        bool dataLoaded = false;
        public FrmUyeBorcDurumu()
        {
            InitializeComponent();
        }

        private void FrmUyeBorcDurumu_Load(object sender, EventArgs e)
        {
            dtGridView.DataSource = db.GetTumBorcDurumu();
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
            dtGridView.Columns["uye_id"].Visible = false;

            column = dtGridView.Columns[0]; column.Width = 0;
            column = dtGridView.Columns[1]; column.Width = 200;
            column = dtGridView.Columns[2]; column.Width = 200;
            column = dtGridView.Columns[3]; column.Width = 150;
            column = dtGridView.Columns[4]; column.Width = 150;


            dtGridView.Columns[0].HeaderText = "uye_id";
            dtGridView.Columns[1].HeaderText = "Adı Soyadı";
            dtGridView.Columns[2].HeaderText = "Açıklama";
            dtGridView.Columns[3].HeaderText = "Tarihi";
            dtGridView.Columns[4].HeaderText = "Miktarı";

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
                    dtGridView.DataSource = db.GetTumBorcDurumu();
                else
                    dtGridView.DataSource = db.GetSeciliUyeBorcDurumu((int)cmbUyeAdi.SelectedValue);
            ListeDuzenle();
        }
    }
}
