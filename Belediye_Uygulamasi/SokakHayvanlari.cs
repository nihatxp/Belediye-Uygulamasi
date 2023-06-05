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
    public partial class SokakHayvanlari : Form
    {
        MainSelectForm msf;
        int wt;
        public SokakHayvanlari(MainSelectForm prm)
        {
            msf = prm;
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
            wt = this.Width;

        }

        private void UmerGenelBilgiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }


        int X = 5;
        int Y = -30;
        int i = 0;

        private void SokakHayvanlari_Load(object sender, EventArgs e)
        {
            foreach (var item in GlobalDegiskenler.DB.SokakHayvanlari())
            {
                Label label3 = new Label();
                label3.AutoSize = true;
                label3.Location = new System.Drawing.Point(3, 194);
                label3.Name = "label" + i;
                label3.Size = new System.Drawing.Size(155, 16);
                label3.TabIndex = 5;
                label3.Text = item[2];
                label3.ForeColor = Color.White;

                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Location = new System.Drawing.Point(3, 247);
                label1.Name = "label" + i + i;
                label1.Size = new System.Drawing.Size(34, 16);
                label1.TabIndex = 4;
                label1.Text = "Yasi : " + item[3];
                label1.ForeColor = Color.White;

                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Location = new System.Drawing.Point(3, 220);
                label2.Name = "label" + i + i + i;
                label2.Size = new System.Drawing.Size(100, 16);
                label2.TabIndex = 2;
                label2.Text = item[1];
                label2.ForeColor = Color.White;

                Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();

                var request = WebRequest.Create(item[4]);

                try
                {
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        guna2ImageButton1.Image = Bitmap.FromStream(stream);
                    }
                }
                catch
                {

                }
              
                guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
                guna2ImageButton1.ImageRotate = 0F;
                guna2ImageButton1.Location = new System.Drawing.Point(6, 3);
                guna2ImageButton1.Name = "guna2ImageButton1";
                guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton1.Size = new System.Drawing.Size(191, 188);
                guna2ImageButton1.TabIndex = 3;

                int oran = wt / (306 - 120);

                Panel panel1 = new Panel();
                panel1.Controls.Add(label3);
                panel1.Controls.Add(label1);
                panel1.Controls.Add(guna2ImageButton1);
                panel1.Controls.Add(label2);
                panel1.Location = new System.Drawing.Point(X, Y);
                panel1.Name = "panel" + i;
                panel1.Size = new System.Drawing.Size(150, 306);
                panel1.TabIndex = 2;
                panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                tabPage1.Controls.Add(panel1);
                tabPage1.AutoScroll = true;

                i++;

                X += 306 - 150;
                if (X > (306 - 150) * oran)
                {
                    X = 5;
                    Y += 250;
                }
            }
        }


        private void SokakHayvanlari_Resize(object sender, EventArgs e)
        {
            int wt = this.Width;
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
