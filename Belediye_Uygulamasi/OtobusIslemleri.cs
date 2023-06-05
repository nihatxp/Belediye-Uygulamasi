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
    public partial class OtobusIslemleri : UserControl
    {
        AdminPaneli adminPaneli;
        public OtobusIslemleri(AdminPaneli adminPaneli)
        {
            this.adminPaneli = adminPaneli;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminOtobusEkle adminOtobusEkle = new AdminOtobusEkle(adminPaneli, this);
            adminOtobusEkle.Show();
            butonDurumu(false);
        }

        public void butonDurumu(bool durum)
        {
            guna2Button1.Enabled = durum;
            guna2Button2.Enabled = durum;
        }

        public void OtobusIslemleri_Load(object sender, EventArgs e)
        {
            ListViewGuncelle();
            Render();
            this.FindForm().AcceptButton = guna2Button1;
        }

        public void ListViewGuncelle()
        {
            listView1.Columns.Add("ID", adminPaneli.panel2Width / 8);
            listView1.Columns.Add("No", adminPaneli.panel2Width / 6);
            listView1.Columns.Add("Gidis", adminPaneli.panel2Width / 3);
            listView1.Columns.Add("Donus", adminPaneli.panel2Width / 3);
        }

        public void Render()
        {
            listView1.Items.Clear();
            string[][] veri = GlobalDegiskenler.DB.OtobusBilgileri();

            int kayitSayi = veri.Length;
            string[] No = new string[kayitSayi];
            string[] isim = new string[kayitSayi];
            string[] gidis = new string[kayitSayi];
            string[] donus = new string[kayitSayi];


            for (int i = 0; i < kayitSayi; i++)
            {
                No[i] = veri[i][1];
                isim[i] = veri[i][2];
                gidis[i] = veri[i][3];
                donus[i] = veri[i][4];
                string[] otobus = {No[i], isim[i], gidis[i], donus[i] };
                ListViewItem kayit = new ListViewItem(otobus);
                listView1.Items.Add(kayit);
            }
        }

        int lwWidth;
        private void listView1_Resize(object sender, EventArgs e)
        {
            //lwWidth = listView1.Width;
        }

        private void OtobusIslemleri_Resize(object sender, EventArgs e)
        {
            lwWidth = listView1.Width;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                guna2Button2.Enabled = true;
            }
            else
            {
                guna2Button2.Enabled = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0])].SubItems[0].Text);
            GlobalDegiskenler.DB.OtobusSil(listView1.Items[listView1.Items.IndexOf(listView1.SelectedItems[0])].SubItems[0].Text);
            Render();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
