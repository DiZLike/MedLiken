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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MedLiken.Mednafen.Config.Platforms;
using MedLiken.Mednafen;
using MedLiken.Mednafen.Config;

namespace MedLiken.GUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для FiltersPage.xaml
    /// </summary>
    public partial class FiltersPage : Page
    {
        TMednafen mednafen;
        TPlatform platform;

        public FiltersPage(TMednafen mednafen, string platform)
        {
            InitializeComponent();

            this.mednafen = mednafen;
            this.platform = new TPlatform(platform);

            SetGUI();
            GetConfigValues();
        }

        private void SetGUI()
        {
            var namesVideoip = Enum.GetNames(typeof(Videoip)).CheckSymbols();
            var namesStretch = Enum.GetNames(typeof(MStretch)).CheckSymbols();
            var namesSpecial = Enum.GetNames(typeof(Special)).CheckSymbols();
            var namesShader = Enum.GetNames(typeof(Shader));
            var namesShaderGoatPat = Enum.GetNames(typeof(ShaderGoatPat));

            videoip.ItemsSource = namesVideoip;
            stretch.ItemsSource = namesStretch;
            special.ItemsSource = namesSpecial;
            shader.ItemsSource = namesShader;
            pat.ItemsSource = namesShaderGoatPat;
        }
        private void GetConfigValues()
        {
            videoip.Text = platform.videoip.ToClearStr();
            stretch.Text = platform.stretch.ToClearStr();
            special.Text = platform.special.ToClearStr();
            shader.Text = platform.shader.ToString();

            fprog.IsChecked = platform.shader_goat_fprog.ToBool();
            slen.IsChecked = platform.shader_goat_slen.ToBool();
            pat.Text = platform.shader_goat_pat.ToString();

            rgbh.Value = platform.shader_goat_hdiv;
            lrgbh.Content = platform.shader_goat_hdiv;
            rgbv.Value = platform.shader_goat_vdiv;
            lrgbv.Content = platform.shader_goat_vdiv;
            tp.Value = platform.shader_goat_tp;
            ltp.Content = platform.shader_goat_tp;

            slenop.Value = platform.scanlines;
            lslenop.Content = platform.scanlines;

            tblur.IsChecked = platform.tblur.ToBool();
            accum.IsChecked = platform.tblur_accum.ToBool();
            amount.Value = platform.tblur_accum_amount;
            lamount.Content = platform.tblur_accum_amount;
        }
        public void Save()
        {
            platform.videoip = videoip.Text.Check<Videoip>();
            platform.stretch = stretch.Text.Check<MStretch>();
            platform.special = special.Text.Check<Special>();
            platform.shader = shader.Text.Check<Shader>();

            platform.shader_goat_fprog = fprog.IsChecked.ToInt();
            platform.shader_goat_slen = slen.IsChecked.ToInt();
            platform.shader_goat_pat = pat.Text.Check<ShaderGoatPat>();

            platform.shader_goat_hdiv = (float)rgbh.Value;
            platform.shader_goat_vdiv = (float)rgbv.Value;
            platform.shader_goat_tp = (float)tp.Value;

            platform.scanlines = (int)slenop.Value;

            platform.tblur = tblur.IsChecked.ToInt();
            platform.tblur_accum = accum.IsChecked.ToInt();
            platform.tblur_accum_amount = (float)amount.Value;

            mednafen.SaveConfig();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lrgbh.Content = e.NewValue.ToString();
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lrgbv.Content = e.NewValue.ToString();
        }

        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ltp.Content = e.NewValue.ToString();
        }

        private void slenop_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lslenop.Content = e.NewValue.ToString();
        }

        private void amount_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lamount.Content = e.NewValue.ToString();
        }
    }
}
