using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belediye_Uygulamasi
{


    public partial class MainSelectForm : Form
    {


        public MainSelectForm()
        {
            InitializeComponent();
            ChangeButtonStyles(this);
            AddDrag(this);
            AddDrag(menuStrip1);
            AddDrag(labelHead);
            AddDrag(pictureBox1);
            menuStrip1.ForeColor = Color.Gray;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }





        public void UpdateMainSelectForm()
        {
            if (GlobalDegiskenler.isAdmin)
            {
                guna2GradientTileButton1.Visible = false;
                guna2GradientTileButton2.Visible = false;
                guna2ImageButton1.Visible = true;
                guna2ImageButton4.Visible = true;
                guna2Button2.Visible = false;
                label10.Text = "";
            }
            else if (GlobalDegiskenler.kullanici != null)
            {
                guna2GradientTileButton1.Visible = false;
                guna2GradientTileButton2.Visible = false;
                guna2ImageButton1.Visible = false;
                guna2ImageButton4.Visible = false;
                label10.Text = GlobalDegiskenler.kullanici;
                guna2Button2.Visible = true;
            }
            else
            {
                guna2GradientTileButton1.Visible = true;
                guna2GradientTileButton2.Visible = true;
                guna2ImageButton1.Visible = false;
                guna2ImageButton4.Visible = false;
                guna2Button2.Visible = false;
                label10.Text = "";
            }
        }

        public void ChangeButtonStyles(Control source)
        {
            foreach (Control con in source.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.FlatAppearance.BorderSize = 0;
                    but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                }
                else
                {
                    ChangeButtonStyles(con);
                }
            }
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            if (GlobalDegiskenler.isAdmin)
            {
                AdminPaneli adminPaneli = new AdminPaneli(this);
                adminPaneli.Show();
                Hide();
            }
            else
            {
                AdminLoginPage adminLoginPage = new AdminLoginPage(this);
                adminLoginPage.Show();
                Hide();
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            guna2GradientTileButton1_Click(new object(), new EventArgs());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //if (e.ClickedItem.ForeColor != Color.LightGray)
            //    e.ClickedItem.ForeColor = Color.LightGray;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void AddDrag(Control Control)
        {
            Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
        }

        private void kurumsalToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            //ToolStripMenuItem itemEvent = sender as ToolStripMenuItem;
            //itemEvent.BackColor = Color.Yellow;
        }

        private void çözümMasasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CozumMasasiBasvuru cozumMasasibasvuru = new CozumMasasiBasvuru(this);
            cozumMasasibasvuru.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CozumMasasiBasvuru cozumMasasibasvuru = new CozumMasasiBasvuru(this);
            cozumMasasibasvuru.Show();
            Hide();
        }
        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            KullaniciLogin kullaniciLoginPage = new KullaniciLogin(this);
            kullaniciLoginPage.Show();
            Hide();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.kullanici = null;
            GlobalDegiskenler.kullaniciTC = null;
            UpdateMainSelectForm();
        }

        private void addRegeditIExplorer()
        {
            try
            {
                var appName = Process.GetCurrentProcess().ProcessName + ".exe";
                WebBrowserHelper.FixBrowserVersion();
                WebBrowserHelper.FixBrowserVersion(appName);
                WebBrowserHelper.FixBrowserVersion(appName, 11);
            }
            catch
            {
                try
                {
                    var appName = Process.GetCurrentProcess().ProcessName + ".exe";
                    WebBrowserHelper.FixBrowserVersion();
                    WebBrowserHelper.FixBrowserVersion(appName);
                    WebBrowserHelper.FixBrowserVersion(appName, 10);
                }
                catch
                {
                    try
                    {
                        var appName = Process.GetCurrentProcess().ProcessName + ".exe";
                        WebBrowserHelper.FixBrowserVersion();
                        WebBrowserHelper.FixBrowserVersion(appName);
                        WebBrowserHelper.FixBrowserVersion(appName, 9);
                    }
                    catch
                    {
                        try
                        {
                            var appName = Process.GetCurrentProcess().ProcessName + ".exe";
                            WebBrowserHelper.FixBrowserVersion();
                            WebBrowserHelper.FixBrowserVersion(appName);
                            WebBrowserHelper.FixBrowserVersion(appName, 8);
                        }
                        catch
                        {
                            //Anyways :)
                        }
                    }
                }
            }

        }

        private void MainSelectForm_Load(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
        }

        private void borçSorgulamaÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnlineTahsilat onlineTahsilat = new OnlineTahsilat(this);
            onlineTahsilat.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OnlineTahsilat onlineTahsilat = new OnlineTahsilat(this);
            onlineTahsilat.Show();
            this.Hide();
        }



        private void MainSelectForm_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width < 911)
            {
                labelHead.Text = "Kütahya Belediyesi";
            }
            else
            {
                labelHead.Text = "Kütahya Belediyesi Uygulaması | Ana Sayfa";
            }
        }


        private void onlineTahsilat_Click_1(object sender, EventArgs e)
        {
            OnlineTahsilat onlineTahsilat = new OnlineTahsilat(this);
            onlineTahsilat.Show();
            this.Hide();
        }

        private void cozumMasasi_Click_1(object sender, EventArgs e)
        {
            CozumMasasiTakip cozumMasasiTakip = new CozumMasasiTakip(this);
            cozumMasasiTakip.Show();
            this.Hide();
        }


        private void hizmetHaritasi_Click_1(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            HizmetHaritasi hizmetHaritasi = new HizmetHaritasi(this);
            hizmetHaritasi.Show();
            this.Hide();
        }

        private void sehirKameralari_Click_1(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            SehirKameralari sehirKameralari = new SehirKameralari(this, true);
            sehirKameralari.Show();
            Hide();
        }

        private void umer_Click_1(object sender, EventArgs e)
        {
            Umer umer = new Umer(this);
            umer.Show();
            Hide();
        }

        private void ulasim_Click_1(object sender, EventArgs e)
        {
            Ulasim ulasim = new Ulasim(this);
            ulasim.Show();
            Hide();
        }

        private void bilgilendirmeBasvuruRehberi_Click(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            Bilgilendirme bilgilendirme = new Bilgilendirme(this);
            bilgilendirme.Show();
            Hide();
        }

        private void imarPlaniDegisikligi_Click(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            Eimar e_imar = new Eimar(this);
            e_imar.Show();
            Hide();
        }

        private void stratejikYonetim_Click(object sender, EventArgs e)
        {
            StratejikYonetim stratejikYonetim = new StratejikYonetim(this);
            stratejikYonetim.Show();
            Hide();
        }

        private void halFiyatlari_Click(object sender, EventArgs e)
        {
            HalFiyatlari halFiyatlari = new HalFiyatlari(this);
            halFiyatlari.Show();
            Hide();
        }

        private void kentBilgi_Click(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            KentBilgi umerBagimliOlma = new KentBilgi(this);
            umerBagimliOlma.Show();
            Hide();
        }

        private void sokakHayvanlari_Click(object sender, EventArgs e)
        {
            SokakHayvanlari umerGenelBilgiler = new SokakHayvanlari(this);
            umerGenelBilgiler.Show();
            this.Hide();
        }

        private void sosyalTesisler_Click(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            SosyalTesisler sosyalTesisler = new SosyalTesisler(this);
            sosyalTesisler.Show();
            Hide();
        }

        private void nobetciEczane_Click(object sender, EventArgs e)
        {
            NobetciEczane nobetciEczane = new NobetciEczane(this);
            nobetciEczane.Show();
            Hide();
        }

        private void projeler_Click(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            Projeler projeler = new Projeler(this);
            projeler.Show();
            this.Hide();
        }

        private void meclisKararlari_Click(object sender, EventArgs e)
        {
            MeclisKararlari meclisKararlari = new MeclisKararlari(this);
            meclisKararlari.Show();
            Hide();
        }

        private void suYukleme_Click(object sender, EventArgs e)
        {
            Vezne vezne = new Vezne(this);
            vezne.Show();
            Hide();
        }

        private void akilliSehir_Click(object sender, EventArgs e)
        {
            AkilliSehir akilliSehir = new AkilliSehir(this);
            akilliSehir.Show();
            Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            CozumMasasiBasvuru cozumMasasibasvuru = new CozumMasasiBasvuru(this);
            cozumMasasibasvuru.Show();
            Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            OnlineTahsilat onlineTahsilat = new OnlineTahsilat(this);
            onlineTahsilat.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void başkanYardımcılarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip.BaskanYardimcilari baskanYardimcilari = new MenuStrip.BaskanYardimcilari(this);
            baskanYardimcilari.Show();
            Hide();
        }

        private void halFiyatlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalFiyatlari halFiyatlari = new HalFiyatlari(this);
            halFiyatlari.Show();
            Hide();
        }

        private void suAboneRehberiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vezne vezne = new Vezne(this);
            vezne.Show();
            Hide();
        }

        private void bilgilendirmeVeBaşvuruRehberiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilgilendirme bilgilendirme = new Bilgilendirme(this);
            bilgilendirme.Show();
            Hide();
        }

        private void eİmzaEvrakDoğrulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ebelediye.kutahya.bel.tr/webportal/index.php?wwsayfa=48");
        }

        private void müdürlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/mudurler.asp");
        }

        private void yönetimŞemasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/yonetimsemasi.asp");
        }

        private void meclisKomisyonlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/komisyonlar.asp");
        }

        private void belediyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/meclis.asp");
        }

        private void belediyeEncümeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/encumen.asp");
        }

        private void etikKomisyonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/etikkomisyonu.asp");
        }

        private void muhtarlarımızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/muhtarlar.asp");
        }

        private void tarihçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/tarihce.asp");
        }

        private void visyonMisyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/vizyon-misyon.asp");
        }

        private void logolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/kurumsalkimlik.asp");
        }

        private void yönetmeliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/yonetmelikler.asp");
        }

        private void belediyeBaşkanlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/belediyebaskanlari.asp");
        }

        private void belediyeŞirketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/sirketler.asp");
        }

        private void kurumsalMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://srv01.turktelekomeposta.com/interface/root#/login");
        }

        private void kentTarihiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/kenttarihi.asp");
        }

        private void turizmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/turizm.asp");
        }

        private void müzelerimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/muzelerimiz.asp");
        }

        private void kütüphanelerimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/kutuphane.asp");
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/firmarehberi.asp");
        }

        private void tarihiYerlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/tarihiyerler.asp");
        }

        private void kütahyadaSanatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/sanat.asp");
        }

        private void kütahyanınDeğeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/degerlerimiz.asp");
        }

        private void geçmişteKütahyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/eskikutahya.asp");
        }

        private void panoramaKütahyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/360/1/2/");
        }

        private void ihalelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/ihaleler.asp");
        }

        private void iletişimBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/iletisim.asp");
        }

        private void birimTelefonlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kutahya.bel.tr/birimtelefon.asp");
        }

        private void bilgiEdinmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ebelediye.kutahya.bel.tr/webportal/index.php?wwsayfa=50");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            Kutahya360 kutahya360 = new Kutahya360(this);
            this.Hide();
            kutahya360.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            SehirKameralari sehirKameralari = new SehirKameralari(this, false);
            sehirKameralari.Show();
            Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            SokakHayvanlari umerGenelBilgiler = new SokakHayvanlari(this);
            umerGenelBilgiler.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            HalFiyatlari halFiyatlari = new HalFiyatlari(this);
            halFiyatlari.Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            addRegeditIExplorer();
            Projeler projeler = new Projeler(this);
            projeler.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Ulasim ulasim = new Ulasim(this);
            ulasim.Show();
            Hide();
        }

        //The END
    }
}
