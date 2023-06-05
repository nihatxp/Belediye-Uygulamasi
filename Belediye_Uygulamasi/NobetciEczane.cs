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
    public partial class NobetciEczane : Form
    {
        MainSelectForm msf;
        public NobetciEczane(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void NobetciEczane_Load(object sender, EventArgs e)
        {

        }

        private void NobetciEczane_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
    }
}
