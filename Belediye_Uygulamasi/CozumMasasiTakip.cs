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
    public partial class CozumMasasiTakip : Form
    {
        MainSelectForm msf;
        public CozumMasasiTakip(MainSelectForm prm)
        {
            msf = prm;
            InitializeComponent();
        }

        private void CozumMasasiTakip_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

        private void CozumMasasiTakip_Load(object sender, EventArgs e)
        {
            textBTC.Text = GlobalDegiskenler.kullaniciTC;
            textBBasvuruNo.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CozumMasasiBasvuru cozumMasasibasvuru = new CozumMasasiBasvuru(this);
            cozumMasasibasvuru.Show();
            Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string[] rdr = GlobalDegiskenler.DB.BasvuruCevapDurumu(textBTC.Text, textBBasvuruNo.Text);
            if (rdr != null)
            {
                CozumMasasiTakipSonuc cozumMasasiTakipSonuc = new CozumMasasiTakipSonuc(this, textBTC.Text, textBBasvuruNo.Text);
                cozumMasasiTakipSonuc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayit Bulunamadi");
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CozumMasasiTakip_MouseDown(object sender, MouseEventArgs e)
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
