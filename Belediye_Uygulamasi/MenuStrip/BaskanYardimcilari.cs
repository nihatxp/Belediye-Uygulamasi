using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belediye_Uygulamasi.MenuStrip
{
    public partial class BaskanYardimcilari : Form
    {
        MainSelectForm msf;
        public BaskanYardimcilari(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void BaskanYardimcilari_Load(object sender, EventArgs e)
        {
        }

        private void BaskanYardimcilari_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
    }
}
