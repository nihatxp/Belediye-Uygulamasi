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
    public partial class Vezne : Form
    {
        MainSelectForm msf;
        public Vezne(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void Vezne_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = "<table><tbody><tr style='border: 1px solid #666666;'><td style='border: 1px solid #666666;' height='52' colspan='3' align='center' valign='middle'><h4>1. MOBİL VEZNE ARACI</h4>(43 SP 693) </td></tr><tr><td style='border: 1px solid #666666;' width='175' rowspan='2' align='center' valign='middle'>PAZARTESİ</td><td style='border: 1px solid #666666;' width='139' height='34' align='center' valign='middle'>09:00 - 12:30 </td><td style='border: 1px solid #666666;' width='477' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;DUMLUPINAR MAHALLESİ (SPORKENT) HALK PAZARI</td></tr><tr><td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>13:30 - 16:15 </td><td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;ZİRAAT MAHALLESİ HALK PAZARI</td></tr><tr><td style='border: 1px solid #666666;' height='68' align='center' valign='middle'>SALI</td><td style='border: 1px solid #666666;' align='center' valign='middle'>09:00 - 16:15 </td><td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;EVLİYA ÇELEBİ MAHALLESİ HALK PAZARI</td></tr> <tr> <td style='border: 1px solid #666666;' rowspan='2' align='center' valign='middle'>ÇARŞAMBA</td> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>09:00 - 12:30 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;ZAFERTEPE MAHALLESİ ŞEHİTLER PARKI ÖNÜ</td> </tr> <tr> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>13:30 - 16:15 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;MALTEPE MAHALLESİ RESSAM AHMET YAKUPOĞLU PARKI</td> </tr> <tr> <td style='border: 1px solid #666666;' rowspan='2' align='center' valign='middle'>PERŞEMBE</td> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>09:00 - 12:30 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;OKMEYDANI MAHALLESİ HALK PAZARI</td> </tr> <tr> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>13:30 - 16:15 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;FATİH MAHALLESİ HALK PAZARI (SOSYETE PAZARI)</td> </tr> <tr> <td style='border: 1px solid #666666;' rowspan='2' align='center' valign='middle'>CUMA</td> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>09:00 - 12:30 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;D.P.Ü. EVLİYA ÇELEBİ EĞT. ARAŞ. HASTANESİ ÖNÜ</td> </tr> <tr> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>13:30 - 16:15 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;BAHÇELİEVLER MAHALLESİ (ŞEHİT ŞEKİP ERDEM CADDESİ)</td> </tr> <tr> <td style='border: 1px solid #666666;' height='40' colspan='3' valign='top'><!--DWLayoutEmptyCell-->&nbsp;</td> </tr> <tr> <td style='border: 1px solid #666666;' height='52' colspan='3' align='center' valign='middle'><h4>2. MOBİL VEZNE ARACI</h4>(43 DC 280) </td> </tr> <tr> <td style='border: 1px solid #666666;' height='68' align='center' valign='middle'>PAZARTESİ</td> <td style='border: 1px solid #666666;' align='center' valign='middle'>09:00 - 16:15 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;GAZİ KEMAL MAHALLESİ 30 AĞUSTOS İ.Ö. OKULU KARŞISI</td> </tr> <tr> <td style='border: 1px solid #666666;' height='68' align='center' valign='middle'>SALI</td> <td style='border: 1px solid #666666;' align='center' valign='middle'>09:00 - 16:15 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;YENİDOĞAN MAHALLESİ HALK PAZARI</td> </tr> <tr> <td style='border: 1px solid #666666;' height='68' align='center' valign='middle'>ÇARŞAMBA</td> <td style='border: 1px solid #666666;' align='center' valign='middle'>09:00 - 16:15 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;CUMHURİYET CADDESİ (SEVGİ YOLU GİRİŞİ)</td> </tr> <tr> <td style='border: 1px solid #666666;' rowspan='2' align='center' valign='middle'>PERŞEMBE</td> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>09:00 - 12:30 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;FATİH MAHALLESİ HALK PAZARI (SOSYETE PAZARI)</td> </tr> <tr> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>13:30 - 16:15 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;100. YIL MAHALLESİ (SOSYAL KONUTLAR) MUHTARLIK ÖNÜ</td> </tr> <tr> <td style='border: 1px solid #666666;' rowspan='2' align='center' valign='middle'>CUMA</td> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>09:00 - 12:30 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;TOKİ AKKENT MAHALLESİ KÜLTÜR MERKEZİ MUHTARLIK ÖNÜ</td> </tr> <tr> <td style='border: 1px solid #666666;' height='34' align='center' valign='middle'>13:30 - 16:15 </td> <td style='border: 1px solid #666666;' align='left' valign='middle'>&nbsp;&nbsp;&nbsp;VEFA MAHALLESİ MUHTARLIK ÖNÜ</td> </tr> </tbody> </table> ";
                
        }

        private void Vezne_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
