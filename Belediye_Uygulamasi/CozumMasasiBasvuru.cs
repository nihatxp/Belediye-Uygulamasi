using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace Belediye_Uygulamasi
{
    public partial class CozumMasasiBasvuru : Form
    {
        public CozumMasasiTakip cmt;
        MainSelectForm msc;
        public CozumMasasiBasvuru(CozumMasasiTakip prm)
        {
            cmt = prm;
            InitializeComponent();
            CozumMasasiBasvuru cmb = this;
        }
        public CozumMasasiBasvuru(MainSelectForm prm)
        {
            msc = prm;
            InitializeComponent();
            CozumMasasiBasvuru cmb = this;
        }

        private void CozumMasasiBasvuru_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cmt!=null)
            {
                cmt.Show();
            }
            else
            {
                msc.Show();
            }
        }

    

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBTC.PlaceholderText = "Pasaport No";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBTC.PlaceholderText = "TC Kimlik No";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = richTextBox1.Text.Length.ToString() + " / 750";
            if (richTextBox1.Text.Length > 750)
            {
                label10.ForeColor = Color.Red;
                label10.Text += "*";
            }
            else
            {
                label10.ForeColor = Color.Green;
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

            if (!(textBTC.Text == "" && textBisim.Text == "" && textBsoyad.Text == "" && textBTelefon.Text == "" && textBeposta.Text == ""))
            {
                string isTurk = radioButton1.Checked ? "1" : "0";
                string TCPASS = textBTC.Text;
                string ad = textBisim.Text;
                string soyad = textBsoyad.Text;
                string dtarih = dateTimeDT.Value.ToString("yyy-dd-MM");
                string telefon = textBTelefon.Text;
                string eposta = textBeposta.Text;
                string mesaj = richTextBox1.Text;

                try
                {
                    GlobalDegiskenler.DB.BasvuruEkle(isTurk, TCPASS, ad, soyad, dtarih, telefon, eposta, mesaj);
                    textBTC.Text = "";
                    textBisim.Text = "";
                    textBsoyad.Text = "";
                    textBTelefon.Text = "";
                    textBeposta.Text = "";
                    richTextBox1.Text = "";
                    MessageBox.Show("Mesajiniz Gonderildi. \nBasvuru Takip Kodunuz : " + GlobalDegiskenler.DB.SonBasvuruyuCek(), "Tebrikler");
                    this.Close();
                }

                catch (Exception j)
                {
                    MessageBox.Show(j.ToString());
                }
            }
        }

        private void CozumMasasiBasvuru_Load(object sender, EventArgs e)
        {
            textBTC.Text = GlobalDegiskenler.kullaniciTC;
            string[] kullanici = GlobalDegiskenler.DB.getKullanici(GlobalDegiskenler.kullaniciTC);
            if(kullanici != null)
            {
                textBisim.Text = kullanici[2].Substring(0, kullanici[2].IndexOf(" "));
                textBsoyad.Text = kullanici[2].Substring(kullanici[2].IndexOf(" "), kullanici[2].ToString().Length - kullanici[2].IndexOf(" "));
                textBTelefon.Text = kullanici[6];
                textBeposta.Text = kullanici[3] + "@kutahyabelediye.com";
            }

        }

        private void textBTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimeDT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBeposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CozumMasasiBasvuru_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void blue_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
    }
}
