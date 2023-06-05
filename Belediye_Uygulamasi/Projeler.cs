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
    public partial class Projeler : Form
    {
        MainSelectForm msf;
        public Projeler(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void Projeler_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
    }
}
