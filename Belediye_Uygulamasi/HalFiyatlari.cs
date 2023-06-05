using HtmlAgilityPack;
using Markdig.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belediye_Uygulamasi
{
    public partial class HalFiyatlari : Form
    {
        MainSelectForm msf;
        public HalFiyatlari(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }
        
        private void HalFiyatlari_Load(object sender, EventArgs e)
        {


            string url = "https://www.kutahya.bel.tr/hal.asp";

            Encoding iso = Encoding.GetEncoding("utf-8");
            HtmlWeb web = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = iso,
            };
            try
            {
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);
                HtmlNode icerik = doc.DocumentNode.SelectSingleNode("//*[@id=\"main\"]/div/table/tbody");
                string ham = icerik.InnerText;

                richTextBox1.Text = ham;

                string islenmisHali = "";
                using (StringReader reader = new StringReader(ham))
                {
                    string line = string.Empty;
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            islenmisHali += (line.Trim()) + "\n";
                        }

                    } while (line != null);
                }
                islenmisHali = islenmisHali.Trim();
                islenmisHali = islenmisHali.Replace("\n\n\n", "");

                //richTextBox1.Text = islenmisHali;

                ekleListView(islenmisHali);
            }catch(Exception err)
            {
                MessageBox.Show("Bilgiler Cekilemedi. Lutfen baglantinizi Kontrol Edip Tekrar Deneyin");
            }
        }

        private void ekleListView(string islenmisHali)
        {
            ArrayList dizi = new ArrayList();
            string row = "";
            //int i= 0;
            foreach (var item in islenmisHali)
            {
                if (item.ToString() == "\n")
                {
                    dizi.Add(row);
                    row = "";
                }
                row += item;
            }

            string[] roww = new string[5];
            int j = 0;
            for (int i = 0; i < dizi.Count; i++)
            {
                if (i <= 4)
                {
                    if (!(i == 4))
                    {
                        listView1.Columns.Add(dizi[i].ToString(), this.Width / 4 - 10);
                    }
                }
                else
                {
                    roww[j] = dizi[i].ToString();
                    j++;

                    if (j == 4)
                    {
                        j = 0;
                        i = i + 2;
                        ListViewItem kayit = new ListViewItem(roww);
                        listView1.Items.Add(kayit);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HalFiyatlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
    }
}
