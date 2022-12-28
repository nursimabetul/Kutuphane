using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class DatabaseKaynak :  Database
    {
        #region Kategori

        public DataTable GetKategori()
        {
            return GetTable("SELECT * FROM " + GetTableName("kategori"));
        }

        public bool AddKategori(string kategori_adi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("kategori") + $"(kategori_adi) VALUES ('{kategori_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateKategori(int kategori_id, string kategori_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("kategori") + $" SET kategori_adi='{kategori_adi}' WHERE kategori_id={kategori_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteKategori(int kategori_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("kategori") + $" WHERE kategori_id={kategori_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Bolum

        public DataTable GetBolum()
        {
            return GetTable("SELECT * FROM " + GetTableName("bolum"));
        }

        public bool AddBolum(string bolum_adi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("bolum") + $"(bolum_adi) VALUES ('{bolum_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateBolum(int bolum_id, string bolum_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("bolum") + $" SET bolum_adi='{bolum_adi}' WHERE bolum_id={bolum_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteBolum(int bolum_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("bolum") + $" WHERE bolum_id={bolum_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Kitap Dili

        public DataTable GetDil()
        {
            return GetTable("SELECT * FROM " + GetTableName("dil"));
        }

        public bool AddDil(string dil_adi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("dil") + $"(dil_adi) VALUES ('{dil_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateDil(int dil_id, string dil_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("dil") + $" SET dil_adi='{dil_adi}' WHERE dil_id={dil_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteDil(int dil_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("dil") + $" WHERE dil_id={dil_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Kitap Turu

        public DataTable GetTur()
        {
            return GetTable("SELECT * FROM " + GetTableName("tur"));
        }

        public bool AddTur(string tur_adi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("tur") + $"(tur_adi) VALUES ('{tur_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateTur(int tur_id, string tur_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("tur") + $" SET tur_adi='{tur_adi}' WHERE tur_id={tur_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteTur(int tur_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("tur") + $" WHERE tur_id={tur_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Yazar

        public DataTable GetYazar()
        {
            return GetTable("SELECT * FROM " + GetTableName("yazar"));
        }

        public bool AddYazar(string yazar_adi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("yazar") + $"(yazar_adi) VALUES ('{yazar_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateYazar(int yazar_id, string yazar_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("yazar") + $" SET yazar_adi='{yazar_adi}' WHERE yazar_id={yazar_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteYazar(int yazar_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("yazar") + $" WHERE yazar_id={yazar_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Raf

        public DataTable GetRaf()
        {
            return GetTable("SELECT * FROM " + GetTableName("raf"));
        }

        public bool AddRaf(string raf_adi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("raf") + $"(raf_adi) VALUES ('{raf_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateRaf(int raf_id, string raf_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("raf") + $" SET raf_adi='{raf_adi}' WHERE raf_id={raf_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteRaf(int raf_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("raf") + $" WHERE raf_id={raf_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Yayinci

        public DataTable GetYayinci()
        {
            return GetTable("SELECT * FROM " + GetTableName("yayinci"));
        }

        public bool AddYayinci(string yayinci_adi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("yayinci") + $"(yayinci_adi) VALUES ('{yayinci_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateYayinci(int yayinci_id, string yayinci_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("yayinci") + $" SET yayinci_adi='{yayinci_adi}' WHERE yayinci_id={yayinci_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteYayinci(int yayinci_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("yayinci") + $" WHERE yayinci_id={yayinci_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region UyeTuru

        public DataTable GetUyeTuru()
        {
            return GetTable("SELECT * FROM " + GetTableName("uyeturu"));
        }

        public bool AddUyeTuru(string uyeturu_adi, int uyeturu_maks_kitap, double uyeturu_gun_ceza)
        {
            string insertQuery = "INSERT INTO " + GetTableName("uyeturu") + $"(uyeturu_adi , uyeturu_maks_kitap, uyeturu_gun_ceza) VALUES ('{uyeturu_adi}', {uyeturu_maks_kitap} , {uyeturu_gun_ceza})";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateUyeTuru(int uyeturu_id, string uyeturu_adi, int uyeturu_maks_kitap, double uyeturu_gun_ceza)
        {
            string updateQuery = "UPDATE " + GetTableName("uyeturu") + $" SET uyeturu_adi = '{uyeturu_adi}', uyeturu_maks_kitap = {uyeturu_maks_kitap} , uyeturu_gun_ceza = {uyeturu_gun_ceza}  WHERE uyeturu_id={uyeturu_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteUyeTuru(int uyeturu_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("uyeturu") + $" WHERE uyeturu_id={uyeturu_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Uye

        public DataTable GetUye()
        {
            return GetTable("SELECT * FROM " + GetTableName("uye_info"));
        }

        public bool AddUye(string uye_adi, string uye_kimlikno, string uye_telefon, string uye_uyeliktarihi, string uye_adresi, int uyeturu_id)
        {
            string insertQuery = "INSERT INTO " + GetTableName("uye") + $"(uye_adi, uye_kimlikno, uye_telefon, uye_uyeliktarihi, uye_adresi, uyeturu_id) VALUES ('{uye_adi}','{uye_kimlikno}','{uye_telefon}','{uye_uyeliktarihi}','{uye_adresi}',{uyeturu_id})";
            return ExecuteQuery(insertQuery);
        }


        public bool UpdateUye(int uye_id, string uye_adi, string uye_kimlikno, string uye_telefon, string uye_uyeliktarihi, string uye_adresi, int uyeturu_id)
        {
            string updateQuery = "UPDATE " + GetTableName("uye") + $" SET uye_adi = '{uye_adi}',  uye_kimlikno = '{uye_kimlikno}', uye_telefon = '{uye_telefon}', uye_uyeliktarihi = '{uye_uyeliktarihi}', uye_adresi = '{uye_adresi}', uyeturu_id = {uyeturu_id}  WHERE uye_id={uye_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteUye(int uye_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("uye") + $" WHERE uye_id={uye_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region UyeOdeme

        public DataTable GetUyeOdeme()
        {
            return GetTable("SELECT * FROM " + GetTableName("uyeodeme"));
        }

        public bool AddUyeOdeme(int uyeodeme_uye_id, string uyeodeme_uye_adi,  string uyeodeme_tarihi, double uyeodeme_miktari)
        {
            string insertQuery = "INSERT INTO " + GetTableName("uyeodeme") + $"(uyeodeme_uye_id, uyeodeme_uye_adi, uyeodeme_tarihi, uyeodeme_miktari) VALUES ({uyeodeme_uye_id},'{uyeodeme_uye_adi}','{uyeodeme_tarihi}',{uyeodeme_miktari})";
            return ExecuteQuery(insertQuery);
        }


        

        public bool UpdateUyeOdeme(int uyeodeme_id, int uyeodeme_uye_id, string uyeodeme_uye_adi, string uyeodeme_tarihi, double uyeodeme_miktari)
        {
            string updateQuery = "UPDATE " + GetTableName("uyeodeme") + $" SET uyeodeme_uye_id = {uyeodeme_uye_id}, uyeodeme_uye_adi = '{uyeodeme_uye_adi}', uyeodeme_tarihi = '{uyeodeme_tarihi}',   uyeodeme_miktari = {uyeodeme_miktari}  WHERE uyeodeme_id={uyeodeme_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteUyeOdeme(int uyeodeme_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("uyeodeme") + $" WHERE uyeodeme_id={uyeodeme_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Kullanici

        public DataTable GetKullanici()
        {
            return GetTable("SELECT * FROM " + GetTableName("kullanici"));
        }

 




        public bool AddKullanici(string kullanici_adisoyadi, string kullanici_adi, string kullanici_sifre, string kullanici_turu, bool kullanici_durumu, int kullanici_girisdeneme)
        {
            string insertQuery = "INSERT INTO " + GetTableName("kullanici") + $"(kullanici_adisoyadi, kullanici_adi, kullanici_sifre, kullanici_turu, kullanici_durumu, kullanici_girisdeneme) VALUES ('{kullanici_adisoyadi}','{kullanici_adi}','{kullanici_sifre}','{kullanici_turu}',{kullanici_durumu},{kullanici_girisdeneme})";
            return ExecuteQuery(insertQuery);
        }
       

        public bool UpdateKullanici(int kullanici_id, string kullanici_adisoyadi, string kullanici_adi, string kullanici_sifre, string kullanici_turu, bool kullanici_durumu, int kullanici_girisdeneme)
        {
            string updateQuery = "UPDATE " + GetTableName("kullanici") + $" SET kullanici_adisoyadi = '{kullanici_adisoyadi}',  kullanici_adi = '{kullanici_adi}', kullanici_sifre = '{kullanici_sifre}', kullanici_turu = '{kullanici_turu}', kullanici_durumu = {kullanici_durumu}, kullanici_girisdeneme = {kullanici_girisdeneme}  WHERE kullanici_id={kullanici_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteKullanici(int kullanici_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("kullanici") + $" WHERE kullanici_id={kullanici_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region KullaniciTuru

        public DataTable GetKullaniciTuru()
        {
            return GetTable("SELECT * FROM " + GetTableName("kullanicituru"));
        }

        public bool AddKullaniciTuru(string kullanicituru_adi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("kullanicituru") + $"(kullanicituru_adi) VALUES ('{kullanicituru_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateKullaniciTuru(int kullanicituru_id, string kullanicituru_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("kullanicituru") + $" SET kullanicituru_adi='{kullanicituru_adi}' WHERE kullanicituru_id={kullanicituru_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteKullaniciTuru(int kullanicituru_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("kullanicituru") + $" WHERE kullanicituru_id={kullanicituru_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region Kitap

        public DataTable GetKitap()
        {
            return GetTable("SELECT * FROM " + GetTableName("kitap_info"));
        }

        public bool AddKitap(string kitap_isbn, string kitap_adi, int yayinci_id,  int yazar_id, int tur_id, int bolum_id, int kategori_id, int dil_id, int raf_id, int kitap_sayfasayisi, string kitap_basimtarihi, bool kitap_odunclaindi)
        {
            string insertQuery = "INSERT INTO " + GetTableName("kitap") + $"(kitap_isbn, kitap_adi, yayinci_id, yazar_id, tur_id, bolum_id, kategori_id, dil_id, raf_id, kitap_sayfasayisi, kitap_basimtarihi, kitap_odunclaindi) VALUES ('{kitap_isbn}','{kitap_adi}',{yayinci_id},{yazar_id},{tur_id},{bolum_id},{kategori_id},{dil_id},{raf_id},{kitap_sayfasayisi},'{kitap_basimtarihi}',{kitap_odunclaindi})";
            return ExecuteQuery(insertQuery);
        }


        public bool UpdateKitap(int kitap_id, string kitap_isbn, string kitap_adi, int yayinci_id, int yazar_id, int tur_id, int bolum_id, int kategori_id, int dil_id, int raf_id, int kitap_sayfasayisi, string kitap_basimtarihi, bool kitap_odunclaindi)
        {
            string updateQuery = "UPDATE " + GetTableName("kitap") + $" SET kitap_isbn = '{kitap_isbn}',  kitap_adi = '{kitap_adi}',yayinci_id = {yayinci_id}, yazar_id = {yazar_id},tur_id = {tur_id},bolum_id = {bolum_id},kategori_id = {kategori_id},dil_id = {dil_id},raf_id = {raf_id}, kitap_sayfasayisi = {kitap_sayfasayisi},kitap_basimtarihi = '{kitap_basimtarihi}', kitap_odunclaindi = {kitap_odunclaindi}  WHERE kitap_id={kitap_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteKitap(int kitap_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("kitap") + $" WHERE kitap_id={kitap_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion

        #region OduncAlma

        public DataTable GetOduncAlma()
        {
            return GetTable("SELECT * FROM " + GetTableName("oduncalma"));
        }

        public bool AddOduncAlma(string oduncalma_tarih, string oduncalma_iadetarihi, int oduncalma_uye_id, string oduncalma_uye_adi, int oduncalma_kitap_id, string oduncalma_kitap_adi, string oduncalma_iade_edildigitarih, bool oduncalma_iade_edildimi, int oduncalma_kallanici_id, string oduncalma_kallanici_adi)

        {
            string insertQuery = "INSERT INTO " + GetTableName("oduncalma") + $"(oduncalma_tarih, oduncalma_iadetarihi, oduncalma_uye_id, oduncalma_uye_adi, oduncalma_kitap_id, oduncalma_kitap_adi, oduncalma_iade_edildigitarih, oduncalma_iade_edildimi, oduncalma_kallanici_id, oduncalma_kallanici_adi) VALUES ('{oduncalma_tarih}','{oduncalma_iadetarihi}',{oduncalma_uye_id},'{oduncalma_uye_adi}',{oduncalma_kitap_id},'{oduncalma_kitap_adi}','{oduncalma_iade_edildigitarih}',{oduncalma_iade_edildimi},{oduncalma_kallanici_id},'{oduncalma_kallanici_adi}')";
            return ExecuteQuery(insertQuery);
        }

        public bool UpdateOduncAlma(int oduncalma_id, string oduncalma_tarih, string oduncalma_iadetarihi, int oduncalma_uye_id, string oduncalma_uye_adi, int oduncalma_kitap_id, string oduncalma_kitap_adi, string oduncalma_iade_edildigitarih, bool oduncalma_iade_edildimi, int oduncalma_kallanici_id, string oduncalma_kallanici_adi)
        {
            string updateQuery = "UPDATE " + GetTableName("oduncalma") + $" SET oduncalma_tarih = '{oduncalma_tarih}',oduncalma_iadetarihi = '{oduncalma_iadetarihi}', oduncalma_uye_id = {oduncalma_uye_id}, oduncalma_uye_adi = '{oduncalma_uye_adi}', oduncalma_kitap_id = {oduncalma_kitap_id} , oduncalma_kitap_adi = '{oduncalma_kitap_adi}', oduncalma_iade_edildigitarih = '{oduncalma_iade_edildigitarih}', oduncalma_iade_edildimi = {oduncalma_iade_edildimi},  oduncalma_kallanici_id = {oduncalma_kallanici_id}, oduncalma_kallanici_adi = '{oduncalma_kallanici_adi}' WHERE oduncalma_id={oduncalma_id}";
            return ExecuteQuery(updateQuery);
        }

        public bool DeleteOduncAlma(int oduncalma_id)
        {
            string deleteQuery = "DELETE FROM " + GetTableName("oduncalma") + $" WHERE oduncalma_id={oduncalma_id}";
            return ExecuteQuery(deleteQuery);
        }

        #endregion


        #region UyeCeza

        public DataTable GetUyeTumCeza()
        {
            return GetTable("SELECT * FROM " + GetTableName("uyeceza_info"));
        }



        public DataTable GetSeciliUyeCeza(int uye_id)
        {
            return GetTable("SELECT * FROM " + GetTableName("uyeceza_info") + $" WHERE uye_id={uye_id}");
        }

        #endregion

        #region BorcDurumu

        public DataTable GetTumBorcDurumu()
        {
            return GetTable("SELECT * FROM " + GetTableName("uye_borc_info"));
        }

        public DataTable GetSeciliUyeBorcDurumu(int uye_id)
        {
            return GetTable("SELECT * FROM " + GetTableName("uye_borc_info") + $" WHERE uye_id={uye_id}");
        }

        #endregion


        #region Yardımcı Methodlar

        private string GetTableName(string tableName)
        {
            return @"public.""" + tableName + @"""";
        }

        #endregion
    }
}
