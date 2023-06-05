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
    public partial class Umer : Form
    {
        MainSelectForm msf;
        public Umer(MainSelectForm prm)
        {
            msf = prm;
            InitializeComponent();
            ChangeButtonStyles(this);
        }

        private void Umer_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }

        private void Umer_Load(object sender, EventArgs e)
        {

        }

        public void ChangeButtonStyles(Control source)
        {
            foreach (Control con in source.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.FlatAppearance.BorderSize = 0;
                    but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                }
                else
                {
                    ChangeButtonStyles(con);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void onlineTahsilat_Click(object sender, EventArgs e)
        {
        
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
