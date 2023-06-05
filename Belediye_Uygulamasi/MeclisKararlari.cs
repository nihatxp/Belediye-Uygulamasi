﻿using System;
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
    public partial class MeclisKararlari : Form
    {
        MainSelectForm msf;
        public MeclisKararlari(MainSelectForm msf)
        {
            this.msf = msf;
            InitializeComponent();
        }

        private void MeclisKararlari_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = "<div class='container'> <table class='table'> <tbody> <tr> <td style='text-align:left;font-size:18px;'>07.12.2022 TARİHLİ 4. DÖNEM 11. OLAĞAN MECLİS TOPLANTISI</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=138'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=138'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>22.11.2022 TARİHLİ 4. DÖNEM 10. OLAĞAN 2. BİRLEŞİM MECLİS TOPLANTISI</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=137'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=137'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.11.2022 TARİHLİ 4. DÖNEM 10. OLAĞAN MECLİS TOPLANTISI</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=136'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=136'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>05.10.2022 4.DÖNEM 9. OLAĞAN TARİHLİ MECLİS TOPLANTISI</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=134'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=134'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>07.09.2022 tarihli 4. dönem 8. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=133'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=133'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>05.08.2022 TARİHLİ MECLİS TOPLANTISI</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=132'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=132'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>03.08.2022 TARİHLİ MECLİS TOPLANTISI</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=131'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=131'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>01.06.2022 tarihli 4. dönem 6. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=129'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=129'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>10.05.2022 tarihli 4. dönem 5. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=128'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=128'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>05.05.2022 tarihli 4. dönem 5. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=127'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=127'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>06.04.2022 tarihli 4. dönem 4. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=126'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=126'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>02.03.2022 tarihli 4.Dönem, 3.Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=125'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=125'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.02.2022 tarihli 4.Dönem, 2.Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=124'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=124'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>14.01.2022 tarihli 4.Dönem, 1.Olağanüstü Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=123'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=123'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>05.01.2022 4.dönem 1. olağan meclis gündemi</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=122'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=122'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>01.12.2021 Tarihli 3. Dönem 11. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=121'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=121'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>22.11.2021 tarihli 3. Dönem 10. Olağan 2. Birleşim Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=120'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=120'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>03.11.2021 tarihli 3. dönem 10. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=119'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=119'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>06.10.2021 tarihli 3. dönem 9. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=118'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=118'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>01.09.2021 tarihli 3. dönem 8. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=117'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=117'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>04.08.2021 tarihli 3. dönem 7. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=116'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=116'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>07.07.2021 tarihli 3. dönem 1. olağanüstü meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=115'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=115'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.06.2021 tarihli 3. dönem 6. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=114'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=114'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>17.05.2021 tarihli 3. dönem 5. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=113'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=113'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>07.04.2021 tarihli 3. dönem 4. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=112'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=112'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>03.03.2021 tarihli 3. dönem 3. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=111'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=111'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>03.02.2021 tarihli 3. dönem 2. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=110'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=110'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>06.01.2021 tarihli 3. dönem 1. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=109'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=109'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.12.2020 tarihli 2. dönem 9. olağan meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=108'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=108'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>23.11.2020 tarihli 2. Dönem 8. Olağan 2. Birleşim Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=107'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=107'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>04.11.2020 tarihli 2. Dönem 8. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=106'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=106'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>07.10.2020 tarihli 2. Dönem 7. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=105'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=105'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.09.2020 tarihli 2. Dönem 6. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=104'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=104'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>05.08.2020 tarihli 2. Dönem 5. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=103'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=103'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>26.06.2020 tarihli 2. Dönem 4. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=102'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=102'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>22.05.2020 tarihli 2. dönem 2. olağanüstü meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=101'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=101'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>20.04.2020 Tarihli 2. Dönem 1. Olağanüstü Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=100'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=100'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>06.03.2020 tarihli 2. Dönem 3. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=99'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=99'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>05.02.2020 tarihli 2. Dönem 2. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=97'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=97'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>02.01.2020 tarihli 2. Dönem 1. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=96'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=96'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>04.12.2019 tarihli 1. Dönem 8. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=95'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=95'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>22.11.2019 tarihli 1. Dönem 7. Olağan 2. Birleşim Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=94'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=94'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>06.11.2019 tarihli 1. Dönem 7. Olağan 1. Birleşim Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=93'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=93'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>17.10.2019 tarihli 1. Dönem 2. Olağanüstü Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=92'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=92'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.10.2019 tarihli 1. Dönem 6. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=91'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=91'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>04.09.2019 tarihli 1. Dönem 5. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=90'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=90'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>05.08.2019 tarihli 1. Dönem 4. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=89'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=89'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>03.07.2019 tarihli 1. Dönem 1. Olağanüstü Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=88'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=88'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>10.06.2019 tarihli 1. Dönem 3. Olağan Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=87'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=87'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>06.05.2019 tarihli 1. Dönem 2. Olağan 2. Birleşim Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=86'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=86'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.05.2019 tarihli 1. Dönem 2. Olağan 1. Birleşim Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=85'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=85'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>17.04.2019 Tarihli 2. Birleşim Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=84'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=84'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>10.04.2019 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=83'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=83'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>01.03.2019 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=82'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=82'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>07.02.2019 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=81'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=81'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>03.1.2019 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=77'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=77'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>06.12.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=76'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=76'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>20.11.2018 Tarihli Meclis Toplantısı 2. Birleşim</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=75'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=75'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>01.11.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=73'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=73'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>02.10.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=72'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=72'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>04.09.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=71'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=71'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>02.08.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=70'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=70'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>05.06.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=69'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=69'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>03.05.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=68'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=68'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>03.04.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=67'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=67'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>06.03.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=66'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=66'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>01.02.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=65'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=65'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>02.01.2018 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=64'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=64'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>05.12.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=63'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=63'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>21.11.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=62'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=62'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.11.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=61'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=61'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>03.10.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=60'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=60'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>07.09.2017 Tarihli meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=59'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=59'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>01.08.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=58'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=58'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>06.06.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=57'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=57'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>02.05.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=56'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=56'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>04.04.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=55'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=55'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>07.03.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=54'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=54'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>02.02.2017 Tarihli Meclis Toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=53'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=53'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>03.01.2017 tarihli meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=52'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=52'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr> <td style='text-align:left;font-size:18px;'>06.12.2016 tarihli meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=51'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=51'><button type='button' class='btn btn-primary'>Kararlar</button></a></td> </tr> <tr class='active'> <td style='text-align:left;font-size:18px;'>21.11.2016 tarihli 2. birleşim meclis toplantısı</td> <td><a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=gundem&amp;id=50'><button type='button' class='btn btn-primary'>Gündem</button></a>&nbsp;&nbsp;&nbsp;<a href='https://www.kutahya.bel.tr/mecliskarar2.asp?islem=karar&amp;id=50'><button type='button' class=";
        }

        private void MeclisKararlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }
    }
}