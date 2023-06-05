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
    public partial class KullaniciLogin : Form
    {
        MainSelectForm msf;
        public KullaniciLogin(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
            textBUsername.Select();
            textBUsername.Text = "murat";
            textBPassword.Text = "1";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (GlobalDegiskenler.DB.getKullaniciPass(textBUsername.Text) != null)
            {
                if (!GlobalDegiskenler.isAdmin)
                {
                    if (GlobalDegiskenler.DB.getKullaniciPass(textBUsername.Text)[0] == textBPassword.Text)
                    {
                        GlobalDegiskenler.kullanici = textBUsername.Text;
                        GlobalDegiskenler.kullaniciTC = GlobalDegiskenler.DB.getKullaniciTC(textBUsername.Text)[0];
                        //MessageBox.Show(GlobalDegiskenler.DB.getKullaniciPass(textBUsername.Text)[0]);

                        this.Hide();
                        msf.UpdateMainSelectForm();
                        msf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Yanlis Parola");
                    }
                }
                else
                {
                    MessageBox.Show("Admin Olarak Kullanici Girisi Yapamazsiniz :)");
                }
            }
            else
            {
                MessageBox.Show("Boyle Bir Kullanici Bulunamadi");
            }

        }


        private void label6_Click(object sender, EventArgs e)
        {
            KullaniciRegister kullaniciRegister = new KullaniciRegister(this);
            kullaniciRegister.Show();
            this.Hide();
        }

        private void mainPNL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Close();
            msf.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void textBUsername_TextChanged(object sender, EventArgs e)
        {
            textBUsername.Text = RemoveSpecialCharacters(textBUsername.Text);
        }

        private static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void mainPNL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
    }
}
