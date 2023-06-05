using CoordinateSharp;
using Innovative.SolarCalculator;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WPFMediaKit.DirectShow.Controls;

namespace Belediye_Uygulamasi
{
    public partial class SehirKameralari : Form
    {

        public MediaUriElement Player { get; set; }

        MainSelectForm msf;
        bool kamera;
        public SehirKameralari(MainSelectForm prm, bool kamera)
        {
            msf = prm;
            InitializeComponent();
            foreach (var item in GlobalDegiskenler.DB.KameralariCek())
            {
                guna2ComboBox1.Items.Add(item[0] + "--" + item[1]);
            }
            this.kamera = kamera;

        }

        private void SehirKameralari_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.uiMode = "none";
            if (kamera)
            {
                panel1.Visible = true;
                guna2ComboBox1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                guna2ComboBox1.Visible = false;
            }

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=kutahya&units=metric&lang=tr&appid=18b7da270bfc7233837e5cb92fd84f38");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            
            try
            {
                axWindowsMediaPlayer1.URL = "https://hls.ibb.gov.tr/tkm2/hls/625.stream/chunklist.m3u8";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    //richTextBox1.Text = result; //json dosya elimizde
                    //richTextBox1.Text = ParseEt(result);
                    //var data = Newtonsoft.Json.JsonConvert.DeserializeObject<HavaDurumu>(result);
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);

                    string[] coord = { (string)data["coord"]["lon"], (string)data["coord"]["lat"] };

                    labelLon.Text = coord[0];
                    labelLat.Text = coord[1];

                    //string bse = (string)data["base"];

                    var weather = data["weather"];

                    // richTextBox1.Text += "hava durumu : " + weather[0].description.ToString();



                    string[] main = { (string)data["main"]["temp"], (string)data["main"]["feels_like"], (string)data["main"]["temp_min"], (string)data["main"]["temp_max"], (string)data["main"]["pressure"], (string)data["main"]["humidity"], (string)data["main"]["sea_level"], (string)data["main"]["grnd_level"] };

                    labelDerece.Text = main[0].ToString() + " " + labelDerece.Text;
                    label17.Text += main[1].ToString();
                    label16.Text += main[4].ToString() + " hPa";
                    label1.Text += main[5].ToString() + "%";
                    label2.Text += main[6].ToString() + " m";

                    string[] wind = { (string)data["wind"]["speed"], (string)data["wind"]["deg"], (string)data["wind"]["gust"] };

                    label6.Text += wind[0].ToString();


                    string visibility = (string)data["visibility"];

                    label3.Text += int.Parse(visibility) / 100 + "%";

                    String Saat = DateTime.Now.ToString("HH");
                    if ((int.Parse(Saat.ToString()) < 5 && int.Parse(Saat.ToString()) >= 0) || (int.Parse(Saat.ToString()) > 17 && int.Parse(Saat.ToString()) <= 23))
                    {
                        label8.Text = "🌒";
                    }
                    else
                    {
                        label8.Text = "⛅";
                    }

                    // ***
                    // *** Display the sunrise
                    // ***

                    //string clouds = (string)data["clouds"]["all"];

                    //string dt = (string)data["dt"];

                    //string[] country = { (string)data["sys"]["country"], (string)data["sys"]["sunrise"], (string)data["sys"]["sunset"] };

                    //string timezone = (string)data["timezone"];

                    //string id = (string)data["id"];

                    //string name = (string)data["name"];

                    //string cod = (string)data["cod"];

                    /*
                    string html = "<html><head>";
                    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    html += "<link href='https://unpkg.com/video.js/dist/video-js.css' rel='stylesheet'>";
                    html += "<script src='https://unpkg.com/video.js/dist/video.js'></script>";
                    html += "<script src='https://unpkg.com/videojs-contrib-hls/dist/videojs-contrib-hls.js'></script>";
                    html += "<video id='my_video' class='video-js vjs-fluid vjs-default-skin' controls preload='auto' data-setup='{}' autoplay>";
                    html += "<source src='" + "https://ddc75c8a6akqr.cloudfront.net/v1/master/80dbfc318ab6b980679b32095ba497236de6d2f9/TRT-1/master.m3u8" + "' type='application/x-mpegURL'>";
                    html += "</video>";
                    html += "<script>";
                    html += "var player = videojs('my_video');";
                    html += "player.play();";
                    html += "</script>";
                    html += "</body></html>";
                    this.webBrowser1.DocumentText = html;
                    */

                    //webBrowser1.DocumentText = "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/DCBg0L8kLfI?start=148\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>";
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());

            }

        }



        private void SehirKameralari_FormClosing(object sender, FormClosingEventArgs e)
        {
            msf.Show();
        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = GlobalDegiskenler.DB.KameraGetir(guna2ComboBox1.SelectedItem.ToString().Substring(0, guna2ComboBox1.SelectedItem.ToString().IndexOf("--")))[2];
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }



}

