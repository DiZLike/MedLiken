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
using MedLiken.Mednafen;
using MedLiken.Mednafen.Config.Global;
using MedLiken.Mednafen.Config;

namespace MedLiken.GUI
{
    /// <summary>
    /// Логика взаимодействия для AudioWnd.xaml
    /// </summary>
    public partial class AudioWnd : Window
    {
        TMednafen mednafen;
        TAudio audio;

        public AudioWnd(TMednafen mednafen)
        {
            InitializeComponent();

            this.mednafen = mednafen;
            audio = mednafen.Global.Audio;
            mednafen.LoadConfig();

            SetGUI();
            GetConfigValues();
        }

        private void SetGUI()
        {
            var namesAudioDriver = Enum.GetNames(typeof(AudioDriver)).CheckSymbols();
            driver.ItemsSource = namesAudioDriver;

            rate.Items.Add("22050");
            rate.Items.Add("32000");
            rate.Items.Add("44100");
            rate.Items.Add("48000");

            for (int i = 0; i < 100000; i*=2)
            {
                period_time.Items.Add(i);
                if (i == 0) i++;
            }
            for (int i = 0; i < 1000; i *= 2)
            {
                buffer_time.Items.Add(i);
                if (i == 0) i++;
            }

        }
        private void GetConfigValues()
        {
            sound.IsChecked = audio.enable.ToBool();
            buffer_time.Text = audio.buffer_time.ToString();
            driver.Text = audio.driver.ToClearStr();
            period_time.Text = audio.period_time.ToString();
            rate.Text = audio.rate.ToString();
            volume.Value = audio.volume;
            lVolume.Content = audio.volume;
        }

        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lVolume.Content = volume.Value.ToString();
        }

        private void BtnSave(object sender, RoutedEventArgs e)
        {
            audio.enable = sound.IsChecked.ToInt();
            audio.buffer_time = int.Parse(buffer_time.Text);
            audio.period_time = int.Parse(period_time.Text);
            audio.driver = driver.Text.Check<AudioDriver>();
            audio.rate = int.Parse(rate.Text);
            audio.volume = (int)volume.Value;

            mednafen.SaveConfig();
            Close();
        }
    }
}
