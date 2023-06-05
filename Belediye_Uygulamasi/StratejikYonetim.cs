using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belediye_Uygulamasi
{
    public partial class StratejikYonetim : Form
    {
        MainSelectForm msf;
        public StratejikYonetim(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void StratejikYonetim_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

        private void StratejikYonetim_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://drive.google.com/file/d/1w-K4c313muZHxerUYymyHQPiZ-2KW5Ft/view?usp=sharing");

            
            //var nodes = doc.DocumentNode.SelectNodes("//tr[preceding-sibling::tr[@class='LomakeTaustaVari']]");

            //webBrowser1.Navigate(string.Format("{0}Resources\\Pdf\\styonetim.pdf", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"))));
        }
    }
}
