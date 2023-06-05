using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belediye_Uygulamasi
{
    public partial class SokakHayvanlariAdmin : UserControl
    {
        AdminPaneli admin = new AdminPaneli();
        public SokakHayvanlariAdmin(AdminPaneli admin)
        {
            this.admin = admin;
            InitializeComponent();
        }
        int X = 10;
        int Y = 10;

        private void SokakHayvanlariAdmin_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Items.Clear();
            guna2Button1.Enabled = false;
            int i = 0;
            foreach (var item in GlobalDegiskenler.DB.SokakHayvanlari())
            {
                Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
                guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
               

                guna2ComboBox1.Items.Add(item[0] + "-- Adi : " +item[2]);

                try
                {
                    var request = WebRequest.Create(item[4]);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        guna2ImageButton1.Image = Bitmap.FromStream(stream);
                    };
                }
                catch
                {

                }
                
                guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
                guna2ImageButton1.ImageRotate = 0F;
                guna2ImageButton1.Location = new System.Drawing.Point(6, 6);
                guna2ImageButton1.Name = "guna2ImageButton" + i;
                guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton1.Size = new System.Drawing.Size(103, 85);
                guna2ImageButton1.TabIndex = 3;
                // 
                // label3
                // 
                Label label3 = new Label();
                label3.AutoSize = true;
                label3.Location = new System.Drawing.Point(128, 6);
                label3.Name = "label" + i;
                label3.Size = new System.Drawing.Size(155, 16);
                label3.TabIndex = 5;
                label3.Text = item[2];
                label3.ForeColor = Color.White;
                // 
                // label1
                // 
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Location = new System.Drawing.Point(128, 47);
                label1.Name = "label" + i + i;
                label1.Size = new System.Drawing.Size(34, 16);
                label1.TabIndex = 4;
                label1.Text = "Yasi" + item[3];
                label1.ForeColor = Color.White;
                // 
                // label2
                // 
                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Location = new System.Drawing.Point(128, 31);
                label2.Name = "label"+i + i + i;
                label2.Size = new System.Drawing.Size(100, 16);
                label2.TabIndex = 2;
                label2.Text = item[1];
                label2.ForeColor = Color.White;

                Panel panel1 = new Panel();
                panel1.Controls.Add(label1);
                panel1.Controls.Add(label3);
                panel1.Controls.Add(label2);
                panel1.Controls.Add(guna2ImageButton1);
                panel1.Location = new System.Drawing.Point(X, Y);
                panel1.Name = "panel" + i;
                panel1.Size = new System.Drawing.Size(383, 96);
                panel1.TabIndex = 2;

                panel.Controls.Add(panel1);

                Y += 96;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.DB.SokakHayvaniSil(guna2ComboBox1.SelectedItem.ToString().Substring(0, guna2ComboBox1.SelectedItem.ToString().IndexOf("--")));
            X = 10;
            Y = 10;
            admin.sokakHayvanlariTikla();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex > -1)
            {
                guna2Button1.Enabled = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (textBAd.Text != "" && textBKupeNo.Text != "" && guna2NumericUpDown1.Value >0)
            {
                GlobalDegiskenler.DB.SokakHayvaniEkle(textBKupeNo.Text, textBAd.Text, guna2NumericUpDown1.Value.ToString(), textBFotoUrl.Text);
                X = 10;
                Y = 10;
                SokakHayvanlariAdmin_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Bos Alan Birakmayin  \n Hayvan yasi 0 ve 0'dan kucuk olamaz");
            }
        }

        private void check()
        {
            if(textBAd.Text != "" && textBKupeNo.Text != "" && textBFotoUrl.Text != "")
            {
                guna2Button2.Enabled = true;
            }
            else
            {
                guna2Button2.Enabled = false;
            }
        }
        private void textBAd_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void textBFotoUrl_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void textBKupeNo_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            check();
        }
    }
}
