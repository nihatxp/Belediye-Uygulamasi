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
    public partial class AkilliSehir : Form
    {
        MainSelectForm msf;
        public AkilliSehir(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void AkilliSehir_Load(object sender, EventArgs e)
        {
         //   webBrowser1.DocumentText = " < !doctype html >< html >< body style = 'height: 100%; width: 100%; overflow: hidden; margin:0px; background-color: rgb(51, 51, 51);' >< embed name = '88C905880C300AA5E1394110CB418A6F' style = 'position:absolute; left: 0; top: 0;'width = '100%' height = '100%' src = 'https://akillisehir.kutahya.bel.tr/AkilliSehirKutahya.pdf' type = 'application/pdf' internalid = '88C905880C300AA5E1394110CB418A6F' ></ body ></ html > ";
        }

        private void AkilliSehir_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
    }
}
