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
    public partial class KullaniciRegister : Form
    {
        KullaniciLogin kl;
        public KullaniciRegister(KullaniciLogin kl)
        {
            this.kl = kl;
            InitializeComponent();
        }

        private void KullaniciRegister_Load(object sender, EventArgs e)
        {
            guna2CheckBox1_CheckedChanged(new object(), new EventArgs());
        }

        private void KullaniciRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            kl.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            kl.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (textBPassword.Text == textBPasswordAgain.Text && textBUsername.Text != "" && textBTamAd.Text != "")
            {
                GlobalDegiskenler.DB.KullaniciEkle(TextBTC.Text,textBTamAd.Text,textBUsername.Text, textBPassword.Text,textBVergiNo.Text, textBCep.Text);
                MessageBox.Show("Kayidiniz Tamamlanmistir Giris Yapabilirsiniz.");
                this.Close();
                kl.Show();
            }
            else
            {
                MessageBox.Show("Hata Kullanici Adi Bos Olamaz\n Parolalarin Eslestiginden Emin Olun");
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                textBPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                textBPasswordAgain.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                textBPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                textBPasswordAgain.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;

            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void mainPNL_Paint(object sender, PaintEventArgs e)
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
        bool tc = false;
        bool username = false;
        private void TextBTC_TextChanged(object sender, EventArgs e)
        {
            TextBTC.Text = OnlyNumber(TextBTC.Text);
            if (GlobalDegiskenler.DB.TCVarMi(TextBTC.Text)[0] == "0")
            {
                if(TextBTC.Text.ToString().Length == 11)
                {
                    TextBTC.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                    TextBTC.BorderColor = Color.FromArgb(17, 17, 20);
                    label1.Text = "";
                    tc = true;
                    if (tc && username)
                    {
                        guna2Button1.Enabled = true;
                    }
                }
                else
                {
                    TextBTC.FocusedState.BorderColor = Color.Red;
                    TextBTC.BorderColor = Color.Red;
                    label1.Text = "TC 11 Haneli Olmalidir";
                    guna2Button1.Enabled = false;
                    tc = false;

                }

            }
            else
            {
                TextBTC.FocusedState.BorderColor = Color.Red;
                TextBTC.BorderColor = Color.Red;
                label1.Text = "Bu TC'ye sahip bir kayit var";
                guna2Button1.Enabled = false;
                tc = false;
            }
        }

    

        private void textBUsername_TextChanged(object sender, EventArgs e)
        {
            textBUsername.Text = RemoveSpecialCharacters(textBUsername.Text);
            textBUsername.Select(textBUsername.Text.ToString().Length, 0);

            if (GlobalDegiskenler.DB.KullaniciAdiVarMi(textBUsername.Text)[0] == "0" && textBUsername.Text != "")
            {
                textBUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
                textBUsername.BorderColor = Color.FromArgb(17, 17, 20);
                username = true;
                if (tc && username)
                {
                    guna2Button1.Enabled = true;
                }
            }
            else
            {
                textBUsername.FocusedState.BorderColor = Color.Red;
                textBUsername.BorderColor = Color.Red;
                guna2Button1.Enabled = false;
                username = false;

            }
        }


        private static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        private static string OnlyNumber(string str)
        {
            return Regex.Replace(str, "[^0-9]+", "", RegexOptions.Compiled);
        }

        private void textBTamAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
