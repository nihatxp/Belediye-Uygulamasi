using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Belediye_Uygulamasi
{
    internal class DB
    {
        readonly string server;
        readonly int port;
        readonly string uid;
        readonly string password;
        readonly string database;
        string sql;
        MySqlCommand cmd;
        private MySqlConnection conn;

        public DB(string server, int port, string uid, string password, string database)
        {
            this.server = server;
            this.port = port;
            this.uid = uid;
            this.password = password;
            this.database = database;
        }

        public void Connect()
        {
            string sql = "server=" + server + ";port=" + port + ";uid=" + uid + ";pwd=" + password + ";database=" + database + ";";
            conn = new MySqlConnection(sql);
            Open();
            Close();
        }

        private void Open()
        {
            conn.Open();
        }

        private void Close()
        {
            conn.Close();
        }

        public void BasvuruEkle(string isTurk, string TCPASS, string ad, string soyad, string dtarih, string telefon, string eposta, string mesaj)
        {
            Open();
            sql = "INSERT INTO `cozum_masasi_basvurusu` (`basvuru_id`, `turk_mu`, `kimlik`, `ad`, `soyad`, `dogum_tarihi`, `telefon`, `eposta`, `mesaj`) VALUES (NULL, '" + isTurk + "', '" + TCPASS + "', '" + ad + "', '" + soyad + "', '" + dtarih + "', '" + telefon + "', '" + eposta + "', '" + mesaj + "');";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public string SonBasvuruyuCek()
        {
            Open();
            sql = "SELECT basvuru_id FROM cozum_masasi_basvurusu WHERE basvuru_id = (SELECT MAX(basvuru_id) FROM cozum_masasi_basvurusu)";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            try
            {
                return rdr[0].ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                rdr.Close();
                Close();
            }
        }

        public string[] BasvuruCek(string TC, string Basvuru_No)
        {
            string sql = "SELECT * FROM `cozum_masasi_basvurusu` WHERE kimlik='" + TC + "' and basvuru_id='" + Basvuru_No + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] BasvuruCek(string TC)
        {
            string sql = "SELECT * FROM `cozum_masasi_basvurusu` WHERE kimlik='" + TC + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] BasvuruCek(int id)
        {
            string sql = "SELECT * FROM `cozum_masasi_basvurusu` WHERE basvuru_id='" + id + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[][] BirKisininTumBasvurulariniCek(string TC)
        {
            string sql = "SELECT * FROM `cozum_masasi_basvurusu` WHERE kimlik='" + TC + "'";
            string[][] result = rdrToArray2D(sql);
            return result;
        }


        public string BirKisininKacBasvurusuVar(string TC)
        {
            string sql = "SELECT COUNT(kimlik) FROM cozum_masasi_basvurusu WHERE kimlik = '" + TC + "'";
            string[] result = rdrToArray(sql);
            return result[0];
        }

        public string[] BasvuruCevapDurumu(string TC, string Basvuru_No)
        {
            string sql = "SELECT cevap_mesaj FROM `cozum_masasi_basvurusu` WHERE kimlik='" + TC + "' and basvuru_id='" + Basvuru_No + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[][] MesajlariCek()
        {
            string sql = "select * from cozum_masasi_basvurusu where ad in (Select max(ad) FROM cozum_masasi_basvurusu group by kimlik)";//kimlige gore tekrarsiz veri cek
            string[][] result = rdrToArray2D(sql);
            return result;
        }

        public void MesajSil(string id)
        {
            Open();
            string sql = "DELETE FROM cozum_masasi_basvurusu WHERE `cozum_masasi_basvurusu`.`basvuru_id` = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void OtobusSil(string No)
        {
            Open();
            string sql = " DELETE FROM `otobus_bilgileri` WHERE `otobus_bilgileri`.`No` = '" + No + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void Cevapla(string id, string yeniMesaj)
        {
            Open();
            string sql = "UPDATE `cozum_masasi_basvurusu` SET `cevap_mesaj` = '" + yeniMesaj + "' WHERE `cozum_masasi_basvurusu`.`basvuru_id` = " + id + "";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public string[] vergiSorgula(string TC)
        {
            string sql = "SELECT * FROM users_table where TC = " + TC;
            string[] result = rdrToArray(sql);
            return result;
        }


        public void VergiGuncelle(string TC, int YeniDeger, int odemeMiktari)
        {
            Open();
            sql = "UPDATE `users_table` SET `borc_miktari` = '" + YeniDeger + "', `son_odeme` = '" + DateTime.Now.ToString() + "', `son_odeme_miktari` = '" + odemeMiktari + "' WHERE `users_table`.`TC` = '" + TC + "';";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void OtobusEkle(string No, string Tam_Ad, string gidis, string donus)
        {
            Open();
            sql = "INSERT INTO `otobus_bilgileri` (`No`, `isim`, `gidis`, `donus`) VALUES('" + No + "', '" + Tam_Ad + "', '" + gidis + "', '" + donus + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public string[][] OtobusIsimleriniCek()
        {
            string sql = "SELECT No,isim FROM otobus_bilgileri;";
            string[][] result = rdrToArray2D(sql);
            return result;
        }

        public string[][] OtobusBilgileri()
        {
            string sql = "SELECT * FROM otobus_bilgileri;";
            string[][] result = rdrToArray2D(sql);
            return result;
        }

        public string[] OtobusGidisDonusleriniCek(string No)
        {
            string sql = "SELECT gidis,donus FROM otobus_bilgileri where No='" + No + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] getAdminPass(string username)
        {
            string sql = "SELECT password FROM admins_table where username='" + username + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] getKullaniciPass(string username)
        {
            string sql = "SELECT password FROM users_table where username='" + username + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[][] KullaniciBilgileri()
        {
            string sql = "SELECT * FROM users_table;";
            string[][] result = rdrToArray2D(sql);//Birden Fazla Kayit Donecek ise;
            return result;
        }

        public string[] getKullaniciTC(string username)
        {
            string sql = "SELECT TC FROM users_table where username='" + username + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] getKullanici(string TC)
        {
            string sql = "SELECT * FROM users_table where TC='" + TC + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public void KullaniciEkle(string TC, string tam_ad, string username, string password, string vergi_no, string cep)
        {
            Open();
            sql = "INSERT INTO `users_table`(`TC`, `tam_ad`, `username`, `password`, `vergi_no`, `cep`, `borc_miktari`, `son_odeme`, `son_odeme_miktari`) VALUES('" + TC + "', '" + tam_ad + "', '" + username + "', '" + password + "', '" + vergi_no + "', '" + cep + "', '0', '', '0')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void KullaniciEkle(string TC, string tam_ad, string username, string password)
        {
            Open();
            sql = "INSERT INTO `users_table`(`TC`, `tam_ad`, `username`, `password`, `vergi_no`, `cep`, `borc_miktari`, `son_odeme`, `son_odeme_miktari`) VALUES('" + TC + "', '" + tam_ad + "', '" + username + "', '" + password + "', '', '', '0', '', '0')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void KullaniciGuncelle(string id, string TC, string tam_ad, string newUname, string newPass)
        {
            Open();
            sql = "UPDATE `users_table` SET `TC` = '" + TC + "', tam_ad = '" + tam_ad + "', `username` = '" + newUname + "', `password` = '" + newPass + "' WHERE `id` = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void KullaniciVergiGuncelle(string id, string vergi_no, string borc_miktari)
        {
            Open();
            sql = "UPDATE `users_table` SET `vergi_no` = '" + vergi_no + "', borc_miktari = '" + borc_miktari + "' WHERE `id` = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public string[] KullaniciAdiVarMi(string username)
        {
            string sql = "SELECT COUNT(username) FROM users_table where username = '" + username + "'";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] TCVarMi(string TC)
        {
            string sql = "SELECT COUNT(TC) FROM users_table where TC = '" + TC + "'";
            string[] result = rdrToArray(sql);
            return result;
        }


        public void KullaniciSil(string id)
        {
            Open();
            sql = "DELETE FROM users_table WHERE `users_table`.`id` = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void TumKullanicilariSil()
        {
            Open();
            sql = "DELETE FROM users_table";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public string[][] SokakHayvanlari()
        {
            string sql = "SELECT * FROM `sokak-hayvanlari`";
            string[][] result = rdrToArray2D(sql);
            return result;
        }

        public void SokakHayvaniSahiplendir(string KullaniciTC, string SokakHayvaniID)
        {
            Open();
            sql = "UPDATE `sokak-hayvanlari` SET `sahip_tc`='" + KullaniciTC + "' WHERE id=" + SokakHayvaniID;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void SokakHayvaniSil(string id)
        {
            Open();
            sql = "DELETE FROM `sokak-hayvanlari` where id=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void SokakHayvaniEkle(string kupeNo, string isim, string yas, string foto_url)
        {
            Open();
            sql = "INSERT INTO `sokak-hayvanlari`(`kupe_no`, `isim`, `yas`, `foto_url`) VALUES ('"+kupeNo+"','"+isim+"','"+yas+"','"+foto_url+"')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public string[][] KameralariCek()
        {
            sql = "SELECT * FROM `kameralar`";
            string[][] result = rdrToArray2D(sql);
            return result;
        }

        public string[] KameraGetir(string id)
        {
            sql = "SELECT * FROM `kameralar` where id="+id;
            string[] result = rdrToArray(sql);
            return result;
        }

        public void KameraSil(string id)
        {
            Open();
            sql = "DELETE FROM `kameralar` WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void KameraEkle(string ad, string url)
        {
            Open();
            sql = "INSERT INTO `kameralar`(`kamera_adi`, `kamera_url`) VALUES ('"+ad+"','"+url+"')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public string[] KameraSay()
        {
            sql = "SELECT count(*) FROM `sokak-hayvanlari`";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] SokakHayvanlariSay()
        {
            sql = "SELECT count(*) FROM `kameralar`";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] MesajSay()
        {
            sql = "SELECT count(*) FROM `cozum_masasi_basvurusu`";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] CevaplanmayanMesajSay()
        {
            sql = "SELECT count(*) FROM `cozum_masasi_basvurusu` where cevap_mesaj != ''";
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] OtobusSay()
        {
            sql = "SELECT count(*) FROM `otobus_bilgileri`;";
            string[] result = rdrToArray(sql);
            return result;
        }


        


        private string[] rdrToArray(string sql)
        {
            string[] result = null;
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result[i] = reader.GetString(i);
                    }
                }
                reader.Close();
                Close();
            }
            catch (Exception ex)
            {
                Close();
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private string[][] rdrToArray2D(string sql)
        {
            string[][] result = new string[0][];

            try
            {
                Open();
                MySqlCommand commandDatabase = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                int nrRanduri = 0;

                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nrRanduri++;
                    }
                }
                reader.Close();

                if (nrRanduri > 0)
                {
                    reader = commandDatabase.ExecuteReader();
                    result = new string[nrRanduri][];
                    for (int i = 0; i < nrRanduri; i++)
                    {
                        result[i] = new string[reader.FieldCount];
                    }
                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            for (int j = 0; j < reader.FieldCount; j++)
                            {
                                result[i][j] = reader.GetString(j);
                            }
                            i++;
                        }
                    }
                }
                Close();

            }
            catch (Exception ex)
            {
                Close();
                MessageBox.Show(ex.Message);
            }

            return result;
        }




    }
}
