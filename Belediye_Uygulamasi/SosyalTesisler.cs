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
    public partial class SosyalTesisler : Form
    {
        MainSelectForm msf;
        public SosyalTesisler(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void SosyalTesisler_Load(object sender, EventArgs e)
        {

        }

        private void SosyalTesisler_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.Window.History.Go(-1);
        }
    }
}
