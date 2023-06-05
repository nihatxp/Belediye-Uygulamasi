using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Belediye_Uygulamasi
{
    public partial class AdminLoginPage : Form
    {
        MainSelectForm msf;
        private static MD5 provider;

        public AdminLoginPage(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
            textBUsername.Text = "admin";
            textBPassword.Text = "43";
            guna2CheckBox1_CheckedChanged(new object(), new EventArgs());
        }

        public static string MD5(string s)
        {
            provider = System.Security.Cryptography.MD5.Create();
            StringBuilder builder = new StringBuilder();

            foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                builder.Append(b.ToString("x2").ToLower());

            return builder.ToString();
        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Close();
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (GlobalDegiskenler.DB.getAdminPass(textBUsername.Text) != null)
            {
                if (GlobalDegiskenler.DB.getAdminPass(textBUsername.Text)[0] == MD5(textBPassword.Text))
                {
                    GlobalDegiskenler.isAdmin = true;
                    GlobalDegiskenler.kullanici = null;
                    GlobalDegiskenler.kullaniciTC = null;
                }
                else
                {
                    MessageBox.Show("Yanlis Parola");
                }
            }
            else
            {
                MessageBox.Show("Boyle Bir Kullanici Bulunamadi");
            }
            if (GlobalDegiskenler.isAdmin)
            {
                AdminPaneli adminPaneli = new AdminPaneli(msf);
                adminPaneli.Show();
                Hide();
            }
            textBUsername.Text = "";
            textBPassword.Text = "";
        }

        private void AdminLoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unutmasaydin :D");
        }

        private void mainPNL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                textBPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                textBPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void mainPNL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
