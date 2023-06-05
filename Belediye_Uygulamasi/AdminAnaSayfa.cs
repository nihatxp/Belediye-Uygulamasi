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
    public partial class AdminAnaSayfa : UserControl
    {
        public AdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label4.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void AdminAnaSayfa_Load(object sender, EventArgs e)
        {
            try
            {
                label11.Text += GlobalDegiskenler.DB.SokakHayvanlariSay()[0];
                label10.Text += GlobalDegiskenler.DB.KameraSay()[0];
                label7.Text += GlobalDegiskenler.DB.OtobusSay()[0];
                if(GlobalDegiskenler.DB.MesajSay()[0] != null)
                {
                    int mesajSay = 0;
                    if (GlobalDegiskenler.DB.CevaplanmayanMesajSay()[0] != null)
                    {
                        mesajSay = int.Parse(GlobalDegiskenler.DB.MesajSay()[0]);
                        label9.Text += mesajSay.ToString();
                    }

                    int cevaplanmayanMesajSay = int.Parse(GlobalDegiskenler.DB.CevaplanmayanMesajSay()[0]);
                    label8.Text += cevaplanmayanMesajSay.ToString();
                    guna2ProgressBar1.Maximum = mesajSay;
                    guna2ProgressBar1.Value = cevaplanmayanMesajSay;
                }
            }
            catch
            {
            }
            label22.Text = DateTime.Now.Year.ToString();
        }
    }
}
