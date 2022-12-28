using System;
using Npgsql;

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
    public partial class FrmGiris : Form
    {
        DatabaseKaynak db = new DatabaseKaynak();
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {



            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; Password=pass;Database=postgres;");
            conn.Open();// PostgreSQL veritabanına bağlan
            NpgsqlTransaction tran = conn.BeginTransaction();       // PostgreSQL'de bir işlem başlat
            NpgsqlCommand command = new NpgsqlCommand("kullanici_getir", conn);// kullanıcı getir fonksiyonunu tanımla 
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new NpgsqlParameter("@prm_kullanici_ad", txtKullaniciAdi.Text)); // kullanıcı adı parametresini ekle.
            NpgsqlDataReader dr = command.ExecuteReader();// Efonksiyonu çalıştır.

            //dr[3] kullanıcı sifre
            //dr[5] kullanıcı aktif
            //dr[6] kullanıcı deneme sayısı
            // Output rows 
            if (dr.Read() == false)
                MessageBox.Show("Kullanıcı Tanımlı değil");
            else
            {
                int denemesayisi = (int)dr[6];
                if ((bool)dr[5] == false) // 
                {
                    MessageBox.Show("Kullanıcı aktif  değil.");
                }
                else
                  if (txtSifre.Text == dr[3].ToString())
                {// kullanıcı adı doğru
                    // kullanıcının daha önceden hatalı girişi varsa sıfırla
                    NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; Password=pass;Database=postgres;");
                    NpgsqlCommand cmd = new NpgsqlCommand(" call kullanici_hataligirissifirla(:prm_kullanici_ad)", con);// Define a command to call show_cities() procedure
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@prm_kullanici_ad", txtKullaniciAdi.Text));
                    con.Open();
                    int eff = cmd.ExecuteNonQuery();

                    KullaniciBilgileri.KullaniciID = (int)dr[0];
                    KullaniciBilgileri.KullanıcıAdı = dr[1].ToString();

                    FrmMain frm = new FrmMain();
                    frm.Show(this);
                    this.Hide();
                    this.ShowInTaskbar = false;
                }
                else
                {
                    MessageBox.Show("Şifre yanlış");
                    if (denemesayisi == 1)
                        MessageBox.Show("Son denemeniz .");

                    if (denemesayisi < 3) // hatalı şifre deneme sayısı deneme sayısı 3 ten küçükse 
                    {

                        NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; Password=pass;Database=postgres;");
                        NpgsqlCommand cmd = new NpgsqlCommand(" call kullanici_hataligiris(:prm_kullanici_ad)", con);// Define a command to call show_cities() procedure
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new NpgsqlParameter("@prm_kullanici_ad", txtKullaniciAdi.Text));
                        con.Open();
                        int eff = cmd.ExecuteNonQuery();
                        if (denemesayisi == 2) MessageBox.Show("Kullanıcı hesabınız pasif oldu.");
                    }



                }

            }

            //tran.Commit();
            conn.Close();

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            //btnGiris.PerformClick();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
