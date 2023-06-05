using System;
using System.Collections;
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
    public partial class CozumMasasiTakipSonuc : Form
    {
        CozumMasasiTakip cmt;
        string TC, Basvuru_No;
        public CozumMasasiTakipSonuc(CozumMasasiTakip prm, string tc, string basvuru_no)
        {
            cmt = prm;
            TC = tc;
            Basvuru_No = basvuru_no;
            InitializeComponent();
            AddDrag(label9);
            AddDrag(label23);
            AddDrag(this);
        }

        bool yanitdurumu;
        string mesaj;
        private void CozumMasasiTakipSonuc_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            try
            {
                string[] data = GlobalDegiskenler.DB.BasvuruCek(TC, Basvuru_No);
                label20.Text = " : " + data[0].ToString();
                label19.Text = " : " + data[1].ToString();
                if (data[1].ToString() == "False")
                {
                    label4.Text = "Pasaport No";
                }
                label18.Text = " :  " + data[2].ToString();
                label17.Text = " : " + data[3].ToString();
                label16.Text = " : " + data[4].ToString();
                label15.Text = " : " + data[5].ToString().Substring(0, data[5].ToString().Length - 8);// Son 8 karakteri sildim
                label14.Text = " : " + data[6].ToString();
                label13.Text = " : " + data[7].ToString();
                mesaj = data[8].ToString();
                if (data[8].ToString().Length > 30)
                {
                    label12.Text = " : " + mesaj.Substring(0, 30) + "...";
                }
                else
                {
                    label12.Text = " : " + mesaj;
                }
                if (data[9].Length > 0)
                {
                    label11.Text = "Yanıtlandı - Mesajı Gör";
                    label11.ForeColor = Color.Green;
                    yanitdurumu = true;
                }
                else
                {
                    yanitdurumu = false;
                    label11.Text = "Yanıtlanmadı";
                    label11.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        bool goster = true;
        string labelinIlkDegeri;
        private void label11_Click(object sender, EventArgs e)
        {
            if (goster)
            {
                if (yanitdurumu == true)
                {
                    labelinIlkDegeri = label11.Text;
                    label11.Text = "Gizle";
                    label11.ForeColor = Color.Red;
                    groupBox1.Visible = true;
                    goster = false;
                }
                if (yanitdurumu)
                {
                    string[] data = GlobalDegiskenler.DB.BasvuruCevapDurumu(TC, Basvuru_No);

                    int i = 1;
                    string tekSatirdakiKelimeToplami = "";
                    label21.Text = "";
                    foreach (var item in Regex.Split(data[0].ToString(), " "))
                    {
                        tekSatirdakiKelimeToplami += item;
                        label21.Text += item + " ";
                        if (tekSatirdakiKelimeToplami.Length > 50)
                        {
                            label21.Text += "\n";
                            tekSatirdakiKelimeToplami = "";
                        }
                        i++;
                    }
                }
            }
            else
            {
                if (yanitdurumu == true)
                {
                    label11.Text = labelinIlkDegeri;
                    label11.ForeColor = Color.Green;
                    groupBox1.Visible = false;
                    goster = true;
                }
                else
                {
                    label11.Text = labelinIlkDegeri;
                    groupBox1.Visible = false;
                }
            }
        }
        private void AddDrag(Control Control)
        {
            Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
        }
        private void label12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mesaj);
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void CozumMasasiTakipSonuc_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmt.Show();
        }
    }
}
