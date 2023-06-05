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
    public partial class HizmetHaritasi : Form
    {
        MainSelectForm msf;
        public HizmetHaritasi(MainSelectForm prm)
        {
            msf = prm;
            InitializeComponent();
        }

        private void HizmetHaritasi_Load(object sender, EventArgs e)
        {
           webBrowser1.Navigate("https://www.google.com/maps/search/K%C3%BCtahya+Hizmet/@39.4181486,29.9916041,15z");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void HizmetHaritasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
    }
}

