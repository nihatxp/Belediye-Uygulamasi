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
    public partial class OnlineTahsilatOdeme : Form
    {
        MainSelectForm msf;
        string tutar, isim, TC;
        public OnlineTahsilatOdeme(MainSelectForm msf, string tutar, string isim, string TC)
        {
            this.TC = TC;
            this.msf = msf;
            this.tutar = tutar;
            this.isim = isim;
            InitializeComponent();
            AddDrag(panel1);
            AddDrag(panel2);
            AddDrag(guna2ImageButton1);
            odemeKontrol();
            for (int i = 1; i <= 12; i++)
            {
                if (i.ToString().Length == 1)
                {
                    ComboBoxMonth.Items.Add("0" + i);
                }
                else
                {
                    ComboBoxMonth.Items.Add(i);
                }
            }
            for (int i = int.Parse(DateTime.Now.Year.ToString()); i <= int.Parse(DateTime.Now.Year.ToString()) + 12; i++)
            {
                ComboBoxYear.Items.Add(i);
            }
            textBKartAdi.Text = isim;
            label13.Text = tutar + " TL";
        }

        private void textBKartAdi_TextChanged(object sender, EventArgs e)
        {
            textBKartAdi.Text = OnlyChar(textBKartAdi.Text);
            textBKartAdi.Select(textBKartAdi.Text.ToString().Length, 0);
            label6.Text = textBKartAdi.Text;
            odemeKontrol();
        }

        private static string OnlyChar(string str)
        {
            return Regex.Replace(str, "[0-9]+", "", RegexOptions.Compiled);
        }

        private void textBKartNumarasi_TextChanged(object sender, EventArgs e)
        {
            textBKartNumarasi.Text = OnlyNumber(textBKartNumarasi.Text);
            textBKartNumarasi.Select(textBKartNumarasi.Text.ToString().Length, 0);

            if (textBKartNumarasi.Text.Length <= 4 && textBKartNumarasi.Text.Length >= 0)
            {
                if (textBKartNumarasi.Text.Length <= 0)
                {
                    label5.Text = "0000";
                }
                if (textBKartNumarasi.Text.Length <= 4)
                {
                    label7.Text = "0000";
                    label8.Text = "0000";
                    label10.Text = "0000";
                }
                char a, b, c, d;
                try
                {
                    a = textBKartNumarasi.Text[0];
                    label5.Text = a + label5.Text.Substring(1, label5.Text.Length - 1);
                    try
                    {
                        b = textBKartNumarasi.Text[1];
                        label5.Text = a.ToString() + b.ToString() + label5.Text.Substring(2, label5.Text.Length - 2);
                        try
                        {
                            c = textBKartNumarasi.Text[2];
                            label5.Text = a.ToString() + b.ToString() + c.ToString() + label5.Text.Substring(3, label5.Text.Length - 3);

                            try
                            {
                                d = textBKartNumarasi.Text[3];
                                label5.Text = a.ToString() + b.ToString() + c.ToString() + d.ToString();
                            }
                            catch
                            {
                                label5.Text = a.ToString() + b.ToString() + c.ToString() + "0";
                            }
                        }
                        catch
                        {
                            label5.Text = a.ToString() + b.ToString() + "0" + label5.Text.Substring(3, label5.Text.Length - 3);
                        }
                    }
                    catch
                    {
                        label5.Text = a.ToString() + "0" + "0" + label5.Text.Substring(3, label5.Text.Length - 3);
                    }
                }
                catch
                {
                    label5.Text = "0" + "0" + "0" + label5.Text.Substring(3, label5.Text.Length - 3);
                }
            }
            else if (textBKartNumarasi.Text.Length <= 8 && textBKartNumarasi.Text.Length >= 4)
            {
                if (textBKartNumarasi.Text.Length <= 8)
                {
                    label7.Text = "0000";
                    label8.Text = "0000";
                    label10.Text = "0000";
                }
                char a, b, c, d;
                try
                {
                    a = textBKartNumarasi.Text[4];
                    label7.Text = a + label7.Text.Substring(1, label7.Text.Length - 1);
                    try
                    {
                        b = textBKartNumarasi.Text[5];
                        label7.Text = a.ToString() + b.ToString() + label7.Text.Substring(2, label7.Text.Length - 2);
                        try
                        {
                            c = textBKartNumarasi.Text[6];
                            label7.Text = a.ToString() + b.ToString() + c.ToString() + label7.Text.Substring(3, label7.Text.Length - 3);

                            try
                            {
                                d = textBKartNumarasi.Text[7];
                                label7.Text = a.ToString() + b.ToString() + c.ToString() + d.ToString();
                            }
                            catch
                            {
                                label7.Text = a.ToString() + b.ToString() + c.ToString() + "0";
                            }
                        }
                        catch
                        {
                            label7.Text = a.ToString() + b.ToString() + "0" + label7.Text.Substring(3, label7.Text.Length - 3);
                        }
                    }
                    catch
                    {
                        label7.Text = a.ToString() + "0" + "0" + label7.Text.Substring(3, label7.Text.Length - 3);
                    }
                }
                catch
                {
                    label7.Text = "0" + "0" + "0" + label7.Text.Substring(3, label7.Text.Length - 3);
                }
            }
            else if (textBKartNumarasi.Text.Length <= 12 && textBKartNumarasi.Text.Length > 8)
            {

                if (textBKartNumarasi.Text.Length <= 12)
                {
                    label10.Text = "0000";
                }
                char a, b, c, d;
                try
                {
                    a = textBKartNumarasi.Text[8];
                    label8.Text = a + label8.Text.Substring(1, label8.Text.Length - 1);
                    try
                    {
                        b = textBKartNumarasi.Text[9];
                        label8.Text = a.ToString() + b.ToString() + label8.Text.Substring(2, label8.Text.Length - 2);
                        try
                        {
                            c = textBKartNumarasi.Text[10];
                            label8.Text = a.ToString() + b.ToString() + c.ToString() + label8.Text.Substring(3, label8.Text.Length - 3);

                            try
                            {
                                d = textBKartNumarasi.Text[11];
                                label8.Text = a.ToString() + b.ToString() + c.ToString() + d.ToString();
                            }
                            catch
                            {
                                label8.Text = a.ToString() + b.ToString() + c.ToString() + "0";
                            }
                        }
                        catch
                        {
                            label8.Text = a.ToString() + b.ToString() + "0" + label8.Text.Substring(3, label8.Text.Length - 3);
                        }
                    }
                    catch
                    {
                        label8.Text = a.ToString() + "0" + "0" + label8.Text.Substring(3, label8.Text.Length - 3);
                    }
                }
                catch
                {
                    label8.Text = "0" + "0" + "0" + label8.Text.Substring(3, label8.Text.Length - 3);
                }
            }
            else if (textBKartNumarasi.Text.Length <= 16 && textBKartNumarasi.Text.Length > 12)
            {

                char a, b, c, d;
                try
                {
                    a = textBKartNumarasi.Text[12];
                    label10.Text = a + label10.Text.Substring(1, label10.Text.Length - 1);
                    try
                    {
                        b = textBKartNumarasi.Text[13];
                        label10.Text = a.ToString() + b.ToString() + label10.Text.Substring(2, label10.Text.Length - 2);
                        try
                        {
                            c = textBKartNumarasi.Text[14];
                            label10.Text = a.ToString() + b.ToString() + c.ToString() + label10.Text.Substring(3, label10.Text.Length - 3);

                            try
                            {
                                d = textBKartNumarasi.Text[15];
                                label10.Text = a.ToString() + b.ToString() + c.ToString() + d.ToString();
                            }
                            catch
                            {
                                label10.Text = a.ToString() + b.ToString() + c.ToString() + "0";
                            }
                        }
                        catch
                        {
                            label10.Text = a.ToString() + b.ToString() + "0" + label10.Text.Substring(3, label10.Text.Length - 3);
                        }
                    }
                    catch
                    {
                        label10.Text = a.ToString() + "0" + "0" + label10.Text.Substring(3, label10.Text.Length - 3);
                    }
                }
                catch
                {
                    label10.Text = "0" + "0" + "0" + label10.Text.Substring(3, label10.Text.Length - 3);
                }
            }
            odemeKontrol();
        }

        private static string OnlyNumber(string str)
        {
            return Regex.Replace(str, "[^0-9]+", "", RegexOptions.Compiled);
        }



        private void textBCVC_TextChanged(object sender, EventArgs e)
        {
            textBCVC.Text = OnlyNumber(textBCVC.Text);
            textBCVC.Select(textBCVC.Text.ToString().Length, 0);
            label11.Text = textBCVC.Text;
            odemeKontrol();
        }

        private void ComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = ComboBoxMonth.SelectedItem.ToString() + label4.Text.Substring(2, label4.Text.Length - 2);
        }

        private void ComboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = label4.Text.Substring(0, label4.Text.Length - 2) + ComboBoxYear.SelectedItem.ToString().Substring(ComboBoxYear.SelectedItem.ToString().Length - 2, ComboBoxYear.SelectedItem.ToString().Length - 2);
        }

        private void odemeKontrol()
        {
            if (textBCVC.Text.Length == 3 && textBKartNumarasi.Text.Length == 16 && textBKartAdi.Text != "" && ComboBoxYear.SelectedIndex != -1 && ComboBoxMonth.SelectedIndex != -1)
            {
                btnOdeme.Enabled = true;
            }
            else
            {
                btnOdeme.Enabled = false;
            }
        }

        private void OnlineTahsilatOdeme_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.Handle, DragForm.WM_NCLBUTTONDOWN, DragForm.HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
        private void AddDrag(Control Control)
        {
            Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnlineTahsilatOdeme_MouseDown);
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnlineTahsilatOdeme_Load(object sender, EventArgs e)
        {

        }

        private void OnlineTahsilatOdeme_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
        int odemeMiktari = 0;

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBOdemeMik.Text = OnlyNumber(textBOdemeMik.Text);
            textBOdemeMik.Select(textBOdemeMik.Text.ToString().Length, 0);
            try
            {
                if (int.Parse(textBOdemeMik.Text) > int.Parse(tutar))
                {
                    btnOdeme.Enabled = false;
                }
                else
                {
                    btnOdeme.Enabled = true;
                }
                odemeMiktari = int.Parse(textBOdemeMik.Text);
            }
            catch { }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            try
            {
                int borc = int.Parse(tutar) - odemeMiktari;
                GlobalDegiskenler.DB.VergiGuncelle(TC, borc, odemeMiktari);
                panel2.Controls.Clear();
                panel2.Controls.Add(guna2ImageButton4);
                guna2ImageButton4.Dock = DockStyle.Fill;
                guna2ImageButton4.Visible = true;
                guna2ImageButton4.AnimatedGIF = true;
                wait(4600);
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
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
    }
}
