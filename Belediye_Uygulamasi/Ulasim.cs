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
    public partial class Ulasim : Form
    {
        readonly MainSelectForm msf;
        public Ulasim(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void Ulasim_Load(object sender, EventArgs e)
        {
            Render();
        }

        private void Render()
        {
            guna2ComboBox1.Items.Clear();
            string[][] veri = GlobalDegiskenler.DB.OtobusIsimleriniCek();

            int kayitSayi = veri.Length;
            label5.Text = veri.Length.ToString();
            string[] isim = new string[kayitSayi];
            string[] No = new string[kayitSayi];

            for (int i = 0; i < kayitSayi; i++)
            {
                No[i] = veri[i][0];
                isim[i] = veri[i][1];
                Test(isim[i], No[i]);
            }
        }

        private void Ulasim_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
        private void Test(string text, string No)
        {
            Otobusler otobus = new Otobusler
            {
                Text = text,
                Value = No
            };
            guna2ComboBox1.Items.Add(otobus);
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] veri = GlobalDegiskenler.DB.OtobusGidisDonusleriniCek((guna2ComboBox1.SelectedItem as Otobusler).Value.ToString());

            string gidis = veri[0];
            //gidis = gidis.Replace("-", "\n");

            string[] ArrGidis = gidis.Split('-');

            richTextBox1.Text = "";
            foreach (var item in ArrGidis)
            {
                richTextBox1.Text += item.Trim()+"\n";
            }
            //gidis = gidis.Replace("\n ", "\n");

            

            string donus = veri[1];
            string[] ArrDonus = gidis.Split('-');

            richTextBox2.Text = "";
            foreach (var item in ArrDonus)
            {
                richTextBox2.Text += item.Trim() + "\n";
            }

           // richTextBox2.Text = donus;
        }
    }
}
