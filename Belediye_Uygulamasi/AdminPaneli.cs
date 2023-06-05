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
    public partial class AdminPaneli : Form
    {
        MainSelectForm msf;
        public AdminPaneli(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public AdminPaneli()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }



        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            btnAdmin_Click(new object(), new EventArgs());
            panel2_Resize(new object(), new EventArgs());
        }


        private void gunaButton2_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.activePageAdminPanel = "kullanicilar";
            Kullanicilar kullanicilar = new Kullanicilar(this);
            kullanicilar.Dock = DockStyle.Fill;
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            panel2.Controls.Add(kullanicilar);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.activePageAdminPanel = "anaSayfa";
            AdminAnaSayfa adminAnaSayfa = new AdminAnaSayfa();
            adminAnaSayfa.Dock = DockStyle.Fill;
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            panel2.Controls.Add(adminAnaSayfa);
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            GlobalDegiskenler.activePageAdminPanel = "mesajlar";
            Mesajlar mesajlar = new Mesajlar();
            mesajlar.Dock = DockStyle.Fill;
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            panel2.Controls.Add(mesajlar);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

            GlobalDegiskenler.activePageAdminPanel = "otobusIslemleri";
            OtobusIslemleri otobusIslemleri = new OtobusIslemleri(this);
            otobusIslemleri.Dock = DockStyle.Fill;
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            panel2.Controls.Add(otobusIslemleri);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.activePageAdminPanel = "vergiIslemleri";
            VergiIslemleri vergiIslemleri = new VergiIslemleri(this);
            vergiIslemleri.Dock = DockStyle.Fill;
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            panel2.Controls.Add(vergiIslemleri);
        }


        private void gunaButton7_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.activePageAdminPanel = "sokakHayvanlariAdmin";
            SokakHayvanlariAdmin sokakHayvanlariAdmin = new SokakHayvanlariAdmin(this);
            sokakHayvanlariAdmin.Dock = DockStyle.Fill;
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            panel2.Controls.Add(sokakHayvanlariAdmin);
        }

        public void sokakHayvanlariTikla()
        {
            gunaButton7_Click(new object(), new EventArgs());
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.activePageAdminPanel = "KameraEkle";
            KameraEkle kameraEkle = new KameraEkle(this);
            kameraEkle.Dock = DockStyle.Fill;
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            panel2.Controls.Add(kameraEkle);
        }


        private void gunaButton9_Click(object sender, EventArgs e)
        {
            
        }

        public void kameraEkleTikla()
        {
            gunaButton9_Click(new object(), new EventArgs());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (msf != null)
            {
                comebackMain();
            }
            else
            {
                msf = new MainSelectForm();
                comebackMain();
            }

        }

        private void comebackMain()
        {
            msf.UpdateMainSelectForm();
            msf.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
        }


        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool sidebarIsOpen = true;


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (sidebarIsOpen)
            {
                SideBar.Width = panel2Width;
                sidebarIsOpen = false;
                guna2ImageButton4.Visible = true;
                guna2Button2.Visible = false;
                panel3.AutoScroll = false;
                panel2.Location = new Point(54, 0);
                panel2.Width = panel2Width + 225;
            }
            else
            {
                panel2.Width = panel2Width - 225;
                panel2.Location = new Point(269, 0);
                SideBar.Width = 270;
                sidebarIsOpen = true;
                guna2ImageButton4.Visible = false;
                guna2Button2.Visible = true;
                panel3.AutoScroll = true;
            }
        }
        public int panel2Width;
        private void panel2_Resize(object sender, EventArgs e)
        {
            panel2Width = panel2.Width;
            if (GlobalDegiskenler.activePageAdminPanel == "otobusIslemleri")
            {
                gunaButton4_Click(new object(), new EventArgs());
            }
            else if (GlobalDegiskenler.activePageAdminPanel == "kullanicilar")
            {
                gunaButton2_Click(new object(), new EventArgs());
            }

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            guna2Button2_Click(new object(), new EventArgs());
        }

        private void AdminPaneli_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                GlobalDegiskenler.isAdmin = false;
                comebackMain();
                this.Hide();
            }
        }





        /* Bordersiz Formu boyutlandirabilmek icin override kodlari */

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like


        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        new Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }

       

        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

    }
}
