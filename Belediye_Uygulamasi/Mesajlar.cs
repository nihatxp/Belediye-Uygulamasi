using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belediye_Uygulamasi
{
    public partial class Mesajlar : UserControl
    {
        public Mesajlar()
        {
            InitializeComponent();
        }

        private void Mesajlar_Load(object sender, EventArgs e)
        {
            Render();
        }

        private void Render()
        {
            guna2ComboBox1.Items.Clear();

            string[][] veri = GlobalDegiskenler.DB.MesajlariCek();

            int kayitSayi = veri.Length;
            label1.Text = veri.Length.ToString();
            string[] kimlik = new string[kayitSayi];
            string[] ad = new string[kayitSayi];

            for (int i = 0; i < kayitSayi; i++)
            {
                kimlik[i] = veri[i][2];
                ad[i] = veri[i][3];
                Kullanici kullanici = new Kullanici
                {
                    TC = kimlik[i],
                    Isim = ad[i]
                };
                addKullanici(kullanici);
            }
        }

        public void addKullanici(Kullanici kullanici)
        {
            guna2ComboBox1.Items.Add(kullanici);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerileriYazdir();
        }

        private void VerileriYazdir()
        {
            string TC = guna2ComboBox1.SelectedItem.ToString();
            int basvuruSayi = int.Parse(GlobalDegiskenler.DB.BirKisininKacBasvurusuVar(TC.Substring(0, TC.IndexOf("--"))));

            if (basvuruSayi > 1)
            {
                guna2ComboBox2.Enabled = true;
                guna2ComboBox2.Items.Clear();
                if (guna2ComboBox2.SelectedIndex == -1)
                {
                    guna2Button1.Enabled = false;
                    guna2Button2.Enabled = false;
                    guna2ComboBox2.Select();
                }
                else
                {
                    guna2Button1.Enabled = true;
                    guna2Button2.Enabled = true;
                }
                string[][] veri = GlobalDegiskenler.DB.BirKisininTumBasvurulariniCek(TC.Substring(0, TC.IndexOf("--")));
                int kayitSayi = veri.Length;
                label22.Text = kayitSayi.ToString();
                label22.Visible = true;
                label23.Visible = true;

                string[] id = new string[kayitSayi];

                for (int i = 0; i < kayitSayi; i++)
                {
                    id[i] = veri[i][0];
                    guna2ComboBox2.Items.Add(id[i]);
                }
                ekraniTemizle();
            }

            else
            {
                label22.Visible = false;
                label23.Visible = false;
                guna2ComboBox2.Enabled = false;
                try
                {
                    
                    string[] data = GlobalDegiskenler.DB.BasvuruCek(TC.Substring(0, TC.IndexOf("--")));

                    label12.Text = " : " + data[0].ToString();
                    label13.Text = " : " + data[1].ToString();
                    if (data[1].ToString() == "False")
                    {
                        label4.Text = "Pasaport No";
                    }
                    else
                    {
                        label4.Text = "TC No";
                    }
                    label14.Text = " :  " + data[2].ToString();
                    label15.Text = " : " + data[3].ToString();
                    label16.Text = " : " + data[4].ToString();
                    label17.Text = " : " + data[5].ToString().Substring(0, data[5].ToString().Length - 8);
                    label18.Text = " : " + data[6].ToString();
                    label19.Text = " : " + data[7].ToString();
                    richTextBox1.Text = data[8].ToString();
                    guna2Button1.Enabled = true;
                    guna2Button2.Enabled = true;

                    if (data[9].Length > 0)
                    {
                        label20.Text = "Yanıtlandı";
                        label20.ForeColor = Color.Green;
                        richTextBox2.Text = data[9];
                        guna2Button2.Text = "Güncelle";
                    }
                    else
                    {
                        guna2Button2.Text = "Gönder";
                        label20.Text = "Yanıtlanmadı";
                        label20.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
        private void ekraniTemizle()
        {
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            label20.Text = "";
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.DB.Cevapla(label12.Text.Substring(3, label12.Text.Length - 3), richTextBox2.Text);
            MessageBox.Show("Mesajiniz Gonderildi", label12.Text + richTextBox2.Text);
            guna2ComboBox1_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ekraniTemizle();
            try
            {
                if (guna2ComboBox2.SelectedIndex != -1)
                {
                    guna2Button1.Enabled = true;
                    guna2Button2.Enabled = true;

                    int id = int.Parse(guna2ComboBox2.SelectedItem.ToString());
                    string[] data = GlobalDegiskenler.DB.BasvuruCek(id);
                    label12.Text = " : " + data[0].ToString();
                    label13.Text = " : " + data[1].ToString();
                    if (data[1].ToString() == "False")
                    {
                        label4.Text = "Pasaport No";
                    }
                    else
                    {
                        label4.Text = "TC No";
                    }
                    label14.Text = " :  " + data[2].ToString();
                    label15.Text = " : " + data[3].ToString();
                    label16.Text = " : " + data[4].ToString();
                    label17.Text = " : " + data[5].ToString().Substring(0, data[5].ToString().Length - 8);
                    label18.Text = " : " + data[6].ToString();
                    label19.Text = " : " + data[7].ToString();
                    richTextBox1.Text = " : " + data[8].ToString();

                    if (data[9].Length > 0)
                    {
                        label20.Text = "Yanıtlandı";
                        label20.ForeColor = Color.Green;
                        richTextBox2.Text = data[9];
                        guna2Button2.Text = "Güncelle";
                    }
                    else
                    {
                        guna2Button2.Text = "Gönder";
                        label20.Text = "Yanıtlanmadı";
                        label20.ForeColor = Color.Red;
                    }
                }
                else
                {
                    guna2Button1.Enabled = false;
                    guna2Button2.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj Kaydini Silerseniz Kullanici, Basvurusuna Erisemeyecektir");
            GlobalDegiskenler.DB.MesajSil(label12.Text.Substring(3, label12.Text.Length - 3));
            MessageBox.Show("Silindi");
            Render();
            ekraniTemizle();
            guna2Button1.Enabled = false;
            guna2Button2.Enabled = false;
            guna2ComboBox2.Items.Clear();
            guna2ComboBox2.Enabled = false;
        }
    }
}
