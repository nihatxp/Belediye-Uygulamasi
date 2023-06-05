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
    public partial class Eimar : Form
    {
        MainSelectForm msf;
        public Eimar(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
           // this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Eimar_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.kutahya.bel.tr:84/imardurumu/index.aspx");
        }

        private void Eimar_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
