using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belediye_Uygulamasi
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            string server = "127.0.0.1";
            int port = 3306;
            string uid = "root";
            string password = "secret";
            string database = "belediye_uygulamasi";


            while (true)
            {
                try
                {
                    GlobalDegiskenler.DB = new DB(server, port, uid, password, database);
                    GlobalDegiskenler.DB.Connect();
                    try
                    {
                        Application.Run(new MainSelectForm());
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch
                {
                    if (MessageBox.Show("Veritabanina Baglanilamadi Tekrar Denemek Ister Misiniz", "Daha Sonra Tekrar Deneyin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        continue;
                    }
                    else { break; };
                }
            }



        }
    }
}
