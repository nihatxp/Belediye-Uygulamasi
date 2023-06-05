using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Belediye_Uygulamasi
{
    public partial class Kullanicilar : UserControl
    {
        AdminPaneli panel;
        public Kullanicilar(AdminPaneli panel)
        {
            this.panel = panel;
            InitializeComponent();

        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            listView1_Resize(new object(), new EventArgs());
            listboxGuncelle();
            textbPassword_TextChanged(new object(), new EventArgs());
            Render();
            this.FindForm().AcceptButton = guna2Button3;
            textBTC.BorderColor = Color.FromArgb(17, 17, 20);
        }

        private void listboxGuncelle()
        {
            listView1.Columns.Add("ID", panel.panel2Width / 5 - 2);
            listView1.Columns.Add("TC", panel.panel2Width / 5 - 2);
            listView1.Columns.Add("Tam Ad", panel.panel2Width / 5 - 1);
            listView1.Columns.Add("Kullanici Adi", panel.panel2Width / 5 - 1);
            listView1.Columns.Add("Parola", panel.panel2Width / 5 - 1);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (textbUsername.Text != "" && textbPassword.Text != "" && textBTamAd.Text != "" && textBTC.Text != "")
            {
                if (KullaniciEkle)
                {
                    GlobalDegiskenler.DB.KullaniciEkle(textBTC.Text, textBTamAd.Text, textbUsername.Text, textbPassword.Text);
                }
                else
                {
                    GlobalDegiskenler.DB.KullaniciGuncelle(listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0])].SubItems[0].Text, textBTC.Text, textBTamAd.Text, textbUsername.Text, textbPassword.Text);
                }
                Render();
                setButtonKullaniciEkle();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                setButtonKullaniciGuncelle();
                int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                textBTC.Text = listView1.Items[i].SubItems[1].Text;
                textBTamAd.Text = listView1.Items[i].SubItems[2].Text;
                textbUsername.Text = listView1.Items[i].SubItems[3].Text;
                textbPassword.Text = listView1.Items[i].SubItems[4].Text;

                guna2Button5.Enabled = true;
            }
            else
            {
                setButtonKullaniciEkle();
            }
            textbTC_TextChanged(new object(), new EventArgs());

        }

        private void Render()
        {
            listView1.Items.Clear();
            textbPassword.Text = "";
            textbUsername.Text = "";
            textBTC.Text = "";
            textBTamAd.Text = "";
            guna2Button5.Enabled = false;
            setButtonKullaniciEkle();

            string[][] veri = GlobalDegiskenler.DB.KullaniciBilgileri();

            int kayitSayi = veri.Length;
            label2.Text = veri.Length.ToString();
            string[] id = new string[kayitSayi];
            string[] TC = new string[kayitSayi];
            string[] isim = new string[kayitSayi];
            string[] kullaniciadi = new string[kayitSayi];
            string[] parola = new string[kayitSayi];

            for (int i = 0; i < kayitSayi; i++)
            {
                id[i] = veri[i][0];
                TC[i] = veri[i][1];
                isim[i] = veri[i][2];
                kullaniciadi[i] = veri[i][3];
                parola[i] = veri[i][4];
                string[] kisi = { id[i], TC[i], isim[i], kullaniciadi[i], parola[i] };
                ListViewItem kayit = new ListViewItem(kisi);
                listView1.Items.Add(kayit);
            }
        }

        bool KullaniciEkle = true;
        private void setButtonKullaniciEkle()
        {
            KullaniciEkle = true;
            guna2Button3.Text = "Kullanıcı Ekle";
            guna2Button3.FillColor = Color.FromArgb(55, 53, 171);
            guna2Button3.HoverState.FillColor = Color.FromArgb(55, 53, 171);
        }

        private void setButtonKullaniciGuncelle()
        {
            KullaniciEkle = false;
            guna2Button3.Text = "Kullanıcı Güncelle";
            guna2Button3.FillColor = Color.FromArgb(255, 128, 0);
            guna2Button3.HoverState.FillColor = Color.FromArgb(255, 128, 0);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tum Kaydi Silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                GlobalDegiskenler.DB.TumKullanicilariSil();
                Render();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydi Silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                GlobalDegiskenler.DB.KullaniciSil(listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0])].SubItems[0].Text);
                Render();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count > 0)
                for (int i = 0; i < this.listView1.SelectedIndices.Count; i++)
                {
                    this.listView1.Items[this.listView1.SelectedIndices[i]].Selected = false;
                }
            guna2Button5.Enabled = false;
            textbPassword.Text = "";
            textbUsername.Text = "";
            textBTC.Text = "";
            textBTamAd.Text = "";
        }


        private void listView1_Resize(object sender, EventArgs e)
        {
            //lwWidth = listView1.Width;
        }

        private void Kullanicilar_Resize(object sender, EventArgs e)
        {

        }


        private static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        private static string OnlyNumber(string str)
        {
            return Regex.Replace(str, "[^0-9]+", "", RegexOptions.Compiled);
        }


        private bool check()
        {
            if (textbPassword.Text != "" && textbUsername.Text != "" && textBTamAd.Text != "" && textBTC.Text != "" && textBTC.Text.ToString().Length == 11)
            {

                return true;
            }
            else
            {

                return false;
            }
        }


        bool tcAvailable = false;
        bool tcLength = false;
        
      


        private void textbTC_TextChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count == 0)
            {
                textBTC.Text = OnlyNumber(textBTC.Text);
                textBTC.Select(textBTC.Text.ToString().Length, 0);  //cursor arkaya kaydigi icin one getirdim

                if (GlobalDegiskenler.DB.TCVarMi(textBTC.Text)[0] == "0")
                {
                    tcAvailable = true;
                    if (textBTC.Text.Length == 11)
                    {
                        textBTC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                        textBTC.BorderColor = Color.FromArgb(17, 17, 20);

                        label3.Text = "";
                        tcLength = true;
                    }
                    else
                    {
                        tcLength = false;
                    }
                }
                else
                {
                    textBTC.FocusedState.BorderColor = Color.Red;
                    textBTC.BorderColor = Color.Red;
                    label3.Text = "Bu TC'ye sahip bir kayit var";
                    guna2Button3.Enabled = false;
                    tcAvailable = false;
                }

            }
            else
            {
                textBTC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                textBTC.BorderColor = Color.FromArgb(17, 17, 20);
                label3.Text = "";
                guna2Button3.Enabled = true;
            }
            dene();
        }

        private void dene()
        {
            if(tcAvailable && tcLength && tamAd && username && pwd)
            {
                guna2Button3.Enabled = true;

            }
            else
            {
                if(this.listView1.SelectedIndices.Count == 0)
                {
                    guna2Button3.Enabled = false;
                }
            }
        }

        bool pwd = false;
        private void textbPassword_TextChanged(object sender, EventArgs e)
        {
            if (textbPassword.Text.Length > 0)
            {
                pwd = true;
            }
            else
            {
                pwd = false;
            }
            dene();
        }

        bool tamAd = false;
        private void textBTamAd_TextChanged(object sender, EventArgs e)
        {
            if(textBTamAd.Text.Length > 0)
            {
                tamAd = true;
            }
            else
            {
                tamAd = false;
            }
            dene();
        }

        bool username = false;
        
        private void textbUsername_TextChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedIndices.Count == 0)
            {
                if (GlobalDegiskenler.DB.KullaniciAdiVarMi(textBTC.Text)[0] == "0")
                {
                    
                    if (textBTC.Text.Length <= 25 && textBTC.Text.Length > 0)
                    {
                        username = true;
                        textBTC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                        textBTC.BorderColor = Color.FromArgb(17, 17, 20);
                        label3.Text = "";
                    }
                    else
                    {
                        username = false;
                        textBTC.FocusedState.BorderColor = Color.Red;
                        textBTC.BorderColor = Color.Red;
                        label3.Text = "Kullanici Adi 25 karakterden buyuk olamaz";
                    }
                }
                else
                {
                    username = false;
                    textBTC.FocusedState.BorderColor = Color.Red;
                    textBTC.BorderColor = Color.Red;
                    label3.Text = "Bu TC'ye sahip bir kayit var";
                }

            }
            else
            {
                textBTC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                textBTC.BorderColor = Color.FromArgb(17, 17, 20);
                label3.Text = "";
                guna2Button3.Enabled = true;
            }
            dene();
        }
    }


}

