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
    public partial class OnlineTahsilat : Form
    {
        MainSelectForm msf;
        public OnlineTahsilat(MainSelectForm prm)
        {
            msf = prm;
            InitializeComponent();
        }

        private void OnlineTahsilat_Load(object sender, EventArgs e)
        {
            if (!(GlobalDegiskenler.kullanici == null))
            {
                textBTC.Text = GlobalDegiskenler.kullaniciTC;
                string[] veri = GlobalDegiskenler.DB.vergiSorgula(textBTC.Text);
                textBVergi.Text = veri[5];
                textBTel.Text = veri[6];
            }
        }

        private void OnlineTahsilat_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

     
        readonly Random r = new Random();
        int x;
        private void btnSMS_Click(object sender, EventArgs e)
        {
            if (textBTC.Text != "" && textBVergi.Text != "" && textBTel.Text != "")
            {
                dogrulamaKoduOlustur();
            }
            else
            {
                label10.Visible = false;
            }
        }

        private void dogrulamaKoduOlustur()
        {
            string Text = "Doğrulama Kodunuz : ";
            x = r.Next(0, 1000000);
            Text += x.ToString();
            label10.Text = Text;
            textBAuth.Text = x.ToString();//kolaylik olsun
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBTC.Text != "" && textBTC.Text != "" && textBVergi.Text != "" && textBTel.Text != "")
            {
                if (textBAuth.Text == x.ToString())
                {
                    dogrulamaKoduOlustur();
                    try
                    {
                        string[] veri = GlobalDegiskenler.DB.vergiSorgula(textBTC.Text);
                        if (veri[5] == textBVergi.Text)
                        {
                            if (int.Parse(veri[7]) > 0)
                            {
                                OnlineTahsilatOdeme onlineTahsilatOdeme = new OnlineTahsilatOdeme(msf, veri[7], veri[2], veri[1]);
                                onlineTahsilatOdeme.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Vergi Borcunuz Bulunmamaktadir.", "Sonuc | " + veri[2] + " " + veri[3]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lutfen Vergi Numaranizi, Sicil Numaranizi ve Abone Numaranizi kontrol ediniz");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Kayit Bulunamadi");
                    }
                }
                else
                {
                    MessageBox.Show("Guvenlik Kodu Hatali Girildi");
                }
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnlineTahsilat_MouseDown(object sender, MouseEventArgs e)
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
