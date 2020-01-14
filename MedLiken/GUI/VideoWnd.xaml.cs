using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MedLiken.Mednafen.Config;
using MedLiken.Mednafen;
using System.Windows.Forms;
using MedLiken.Mednafen.Config.Global;

namespace MedLiken.GUI
{
    /// <summary>
    /// Логика взаимодействия для VideoWnd.xaml
    /// </summary>
    public partial class VideoWnd : Window
    {
        TMednafen mednafen;
        TVideo video;

        public VideoWnd(TMednafen mednafen)
        {
            InitializeComponent();
            this.mednafen = mednafen;
            video = mednafen.Global.Video;
            mednafen.LoadConfig();

            SetGUI();
            GetConfigValues();
        }

        private void SetGUI()
        {
            var namesDeinterlacer = Enum.GetNames(typeof(Deinterlacer));
            var namesVideoDriver = Enum.GetNames(typeof(VideoDriver)).CheckSymbols();
            deinterlacer.ItemsSource = namesDeinterlacer;
            videoDriver.ItemsSource = namesVideoDriver;

            fs_display.Items.Add("Основной монитор");
            for (int i = 0; i < Screen.AllScreens.Length; i++)
                fs_display.Items.Add(i);

        }
        private void GetConfigValues()
        {
            fs.IsChecked = video.fs.ToBool();
            frameskip.IsChecked = video.frameskip.ToBool();
            blit_timesync.IsChecked = video.blit_timesync.ToBool();
            glvsync.IsChecked = video.glvsync.ToBool();
            disable_composition.IsChecked = video.disable_composition.ToBool();
            videoDriver.Text = video.driver.ToClearStr();
            deinterlacer.Text = video.deinterlacer.ToString();

            if (video.fs_display == -1)
                fs_display.Text = "Основной монитор";
            else
                fs_display.Text = video.fs_display.ToString();

        }

        private void BtnSave(object sender, RoutedEventArgs e)
        {
            video.fs = fs.IsChecked.ToInt();
            video.frameskip = frameskip.IsChecked.ToInt();
            video.blit_timesync = blit_timesync.IsChecked.ToInt();
            video.glvsync = glvsync.IsChecked.ToInt();
            video.disable_composition = disable_composition.IsChecked.ToInt();
            video.driver = videoDriver.Text.Check<VideoDriver>();
            video.deinterlacer = deinterlacer.Text.Check<Deinterlacer>();

            if (fs_display.Text == "Основной монитор")
                video.fs_display = -1;
            else
                video.fs_display = int.Parse(fs_display.Text);

            mednafen.SaveConfig();
            Close();
        }

    }
}
