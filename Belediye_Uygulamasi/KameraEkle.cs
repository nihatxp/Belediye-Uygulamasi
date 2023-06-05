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
    public partial class KameraEkle : UserControl
    {
        AdminPaneli adminp;
        public KameraEkle(AdminPaneli adminp)
        {
            this.adminp = adminp;
            InitializeComponent();
            foreach (var item in GlobalDegiskenler.DB.KameralariCek())
            {
                guna2ComboBox1.Items.Add(item[0] + "--" + item[1]);
            }
        }

        private void KameraEkle_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = GlobalDegiskenler.DB.KameraGetir("1")[2];
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex > -1)
            {
                guna2Button1.Enabled = true;
            }
            else
            {
                guna2Button1.Enabled = false;
            }
            axWindowsMediaPlayer1.URL = GlobalDegiskenler.DB.KameraGetir(guna2ComboBox1.SelectedItem.ToString().Substring(0, guna2ComboBox1.SelectedItem.ToString().IndexOf("--")))[2];
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GlobalDegiskenler.DB.KameraSil(guna2ComboBox1.SelectedItem.ToString().Substring(0, guna2ComboBox1.SelectedItem.ToString().IndexOf("--")));
            adminp.kameraEkleTikla();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (textBAd.Text != "" && textBStream.Text != "")
            {
                GlobalDegiskenler.DB.KameraEkle(textBAd.Text, textBStream.Text);
                adminp.kameraEkleTikla();
            }
        }


        private void check()
        {
            if (textBAd.Text != "" && textBStream.Text != "")
            {
                guna2Button2.Enabled = true;
            }
            else
            {
                guna2Button2.Enabled = false;
            }
        }

        private void textBStream_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void textBAd_TextChanged(object sender, EventArgs e)
        {
            check();
        }
    }

}
