﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belediye_Uygulamasi
{
    public partial class Kutahya360 : Form
    {
        MainSelectForm msf;
        public Kutahya360(MainSelectForm prm)
        {
            msf = prm;
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void deneme_Load(object sender, EventArgs e)
        {
            
           
        }

        
    
      
    



        private void Kutahya360_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }




     

    }
}
