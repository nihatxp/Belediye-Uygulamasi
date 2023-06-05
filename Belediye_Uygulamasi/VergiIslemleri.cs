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
    public partial class VergiIslemleri : UserControl
    {
        AdminPaneli panel;
        public VergiIslemleri(AdminPaneli panel)
        {
            this.panel = panel;
            InitializeComponent();
        }

        private void VergiIslemleri_Load(object sender, EventArgs e)
        {
            
            listView1.Columns.Add("ID", panel.panel2Width / 5 - 2);
            listView1.Columns.Add("TC", panel.panel2Width / 5 - 2);
            listView1.Columns.Add("Tam Ad", panel.panel2Width / 5 - 1);
            listView1.Columns.Add("Vergi No", panel.panel2Width / 5 - 1);
            listView1.Columns.Add("Borc", panel.panel2Width / 5 - 1);
            this.FindForm().AcceptButton = btnUygula;
            Render();
        }


        private void Render()
        {
            listView1.Items.Clear();
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("Hepsi");
            string[][] veri = GlobalDegiskenler.DB.KullaniciBilgileri();
            int kayitSayi = veri.Length;
            label1.Text = "Toplam : "+veri.Length.ToString();
            string[] id = new string[kayitSayi];
            string[] TC = new string[kayitSayi];
            string[] tam_ad = new string[kayitSayi];
            string[] vergi_no = new string[kayitSayi];
            string[] borc_miktari = new string[kayitSayi];
            string[] kulladi = new string[kayitSayi];

            for (int i = 0; i < kayitSayi; i++)
            {
                id[i] = veri[i][0];
                TC[i] = veri[i][1];
                tam_ad[i] = veri[i][2];
                kulladi[i] = veri[i][3];
                vergi_no[i] = veri[i][5];
                borc_miktari[i] = veri[i][7];

                string isim_ve_kulladi = tam_ad[i] + " (" + kulladi[i] + ")";
                string[] kisi = { id[i], TC[i], isim_ve_kulladi, vergi_no[i], borc_miktari[i] };
                ListViewItem kayit = new ListViewItem(kisi);
                listView1.Items.Add(kayit);


                Kullanici kullanici = new Kullanici
                {
                    TC = TC[i],
                    Isim = tam_ad[i]
                };
                addKullanici(kullanici);
            }
            listView1_SelectedIndexChanged(new object(), new EventArgs());

        }

        public void addKullanici(Kullanici kullanici)
        {
            guna2ComboBox1.Items.Add(kullanici);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex > 0)//Hepsi secilmemisse
            {
                addListview(GlobalDegiskenler.DB.getKullanici(guna2ComboBox1.Text.Substring(0, guna2ComboBox1.Text.IndexOf("-"))));
            }
            else
            {
                Render();
            }
        }

        private void addListview(string[] kullanici)
        {
            listView1.Items.Clear(); 
            string[] kisi = { kullanici[0], kullanici[1], kullanici[2] + " (" + kullanici[3] + ")", kullanici[5], kullanici[7] };
            ListViewItem kayit = new ListViewItem(kisi);
            listView1.Items.Add(kayit);
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            if (textBBorcMiktari.Text != "" && TextBVergiNo.Text != "")
            {
                GlobalDegiskenler.DB.KullaniciVergiGuncelle(listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0])].SubItems[0].Text, TextBVergiNo.Text , textBBorcMiktari.Text);
            }
            textBTC.Text = TextBVergiNo.Text = textBBorcMiktari.Text = "";
            Render();

        }

    

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                textBTC.Text = listView1.Items[i].SubItems[1].Text;
                TextBVergiNo.Text = listView1.Items[i].SubItems[3].Text;
                textBBorcMiktari.Text = listView1.Items[i].SubItems[4].Text;
                btnUygula.Enabled = true;
            }
            else
            {
                btnUygula.Enabled = false;
            }
        }

        private void textBTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
