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
    public partial class AdminOtobusEkle : Form
    {
        AdminPaneli adminPaneli;
        OtobusIslemleri otobusIslemleri;

        public AdminOtobusEkle(AdminPaneli adminPaneli, OtobusIslemleri prm)
        {
            otobusIslemleri = prm;
            this.adminPaneli = adminPaneli;
            InitializeComponent();
        }

        private void AdminOtobusEkle_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (textBoxTamAd.Text != "" && textBoxNo.Text != "")
            {
                GlobalDegiskenler.DB.OtobusEkle(textBoxNo.Text, textBoxTamAd.Text, richTextBoxgidis.Text, richTextBoxdonus.Text);
                MessageBox.Show("Kayit Eklendi");
                textBoxNo.Text = "";
                textBoxTamAd.Text = "";
                richTextBoxdonus.Text = "";
                richTextBoxgidis.Text = "";
                otobusIslemleri.Render();
            }
        }

        private void AdminOtobusEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            OtobusIslemleri otobusIslemleri = new OtobusIslemleri(adminPaneli);
            otobusIslemleri.Dock = DockStyle.Fill;
            if (adminPaneli.panel2.Controls.Count > 0)
            {
                adminPaneli.panel2.Controls.Clear();
            }
            adminPaneli.panel2.Controls.Add(otobusIslemleri);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            otobusIslemleri.butonDurumu(true);
            Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminOtobusEkle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void richTextBoxgidis_MouseHover(object sender, EventArgs e)
        {

        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void richTextBoxgidis_Enter(object sender, EventArgs e)
        {
            ChangePanelColor(guna2CustomGradientPanel1);
        }

        private void richTextBoxgidis_Leave(object sender, EventArgs e)
        {
            ResetPanelColor(guna2CustomGradientPanel1);
        }

        private void richTextBoxdonus_Enter(object sender, EventArgs e)
        {
            ChangePanelColor(guna2CustomGradientPanel2);
        }

        private void richTextBoxdonus_Leave(object sender, EventArgs e)
        {
            ResetPanelColor(guna2CustomGradientPanel2);
        }


        int[] hoverPanel = { 55, 53, 171 };
        int[] defaultPanel = { 0, 0, 0 };
        int r, g, b;
        private void ResetPanelColor(Guna.UI2.WinForms.Guna2CustomGradientPanel Panel)
        {
            r = defaultPanel[0];
            g = defaultPanel[1];
            b = defaultPanel[2];
            while (r < hoverPanel[0] && g < hoverPanel[0] && b < hoverPanel[0])
            {
                Panel.FillColor = Color.FromArgb(r, g, b);
                Panel.FillColor2 = Color.FromArgb(r, g, b);
                Panel.FillColor3 = Color.FromArgb(r, g, b);
                Panel.FillColor4 = Color.FromArgb(r, g, b);
                r++;
                g++;
                b++;
                if (r % 500 == 0)
                {
                    wait(10);
                }
            }
        }

        private void ChangePanelColor(Guna.UI2.WinForms.Guna2CustomGradientPanel Panel)
        {
            r = hoverPanel[0];
            g = hoverPanel[1];
            b = hoverPanel[2];
            while (r > defaultPanel[0] && g > defaultPanel[0] && b > defaultPanel[0])
            {
                Panel.FillColor = Color.FromArgb(r, g, b);
                Panel.FillColor2 = Color.FromArgb(r, g, b);
                Panel.FillColor3 = Color.FromArgb(r, g, b);
                Panel.FillColor4 = Color.FromArgb(r, g, b);
                r--;
                g--;
                b--;
                if (r % 50 == 0)
                {
                    wait(10);
                }
            }
        }

    }
}
