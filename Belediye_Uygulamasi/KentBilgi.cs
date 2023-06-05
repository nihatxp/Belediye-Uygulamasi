using Microsoft.Win32;
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
    public partial class KentBilgi : Form
    {
        MainSelectForm msf;
        public KentBilgi(MainSelectForm prm)
        {
            msf = prm;
            InitializeComponent();
        }

        private void UmerBagimliOlma_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

        private void UmerBagimliOlma_Load(object sender, EventArgs e)
        {
           // var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";

           // using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
           //     Key.SetValue(appName, 99999, RegistryValueKind.DWord);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.Window.History.Go(-1);
        }
    }
}
