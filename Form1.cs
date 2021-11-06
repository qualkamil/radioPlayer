using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listBox1.Items.Add ("Power FM");
            listBox1.Items.Add("Radyo D");
            listBox1.Items.Add("Arabesk Damar FM");
            listBox1.Items.Add("Hamsi FM");
            listBox1.Items.Add("TRT FM");
            listBox1.Items.Add("90'lar FM");
            listBox1.Items.Add("Kral FM");
            listBox1.Items.Add("Powertürk FM");
            listBox1.Items.Add("Best FM");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
                axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerfm/abr/powerfm/128/playlist.m3u8";
            if(listBox1.SelectedIndex == 1)
                axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/radyod";
            if (listBox1.SelectedIndex == 2)
                axWindowsMediaPlayer1.URL = "https://vofile.ru/turkey/arabesk_damar_fm/icecast.audio";
            if (listBox1.SelectedIndex == 3)
                axWindowsMediaPlayer1.URL = "http://yayin.liderhost.net:8028/;";
            if (listBox1.SelectedIndex == 4)
                axWindowsMediaPlayer1.URL = "https://radio-trtfm.live.trt.com.tr/master.m3u8";
            if (listBox1.SelectedIndex == 5)
                axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
            if (listBox1.SelectedIndex == 6)
                axWindowsMediaPlayer1.URL = "http://kralwmp.radyotvonline.com/;";
            if (listBox1.SelectedIndex == 7)
                axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerturk/abr/powerturk/128/playlist.m3u8";
            if (listBox1.SelectedIndex == 8)
                axWindowsMediaPlayer1.URL = "http://46.20.7.126/;stream.mp3";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
