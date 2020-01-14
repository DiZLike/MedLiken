using System.Windows;
using MedLiken.Mednafen;
using MedLiken.GUI.Pages;
using MedLiken.Mednafen.Config.Platforms;
using System;
using MedLiken.Mednafen.Config;

namespace MedLiken.GUI
{
    /// <summary>
    /// Логика взаимодействия для MegaDriveWnd.xaml
    /// </summary>
    public partial class MegaDriveWnd : Window
    {
        TMednafen mednafen;
        TMegaDrive md;
        OptionsPage opt;
        FiltersPage fp;

        public MegaDriveWnd(TMednafen mednafen)
        {
            InitializeComponent();
            this.mednafen = mednafen;
            md = mednafen.Platforms.MegaDrive;
            mednafen.LoadConfig();
            SetGUI();
            GetConfigValues();
        }

        private void SetGUI()
        {
            opt = new OptionsPage(mednafen, "md");
            fp = new FiltersPage(mednafen, "md");
            options.Navigate(opt);
            filters.Navigate(fp);

            var namesMDRegion = Enum.GetNames(typeof(MDRegion));
            var namesMDReportedRegion = Enum.GetNames(typeof(MDReportedRegion));
            region.ItemsSource = namesMDRegion;
            reported_region.ItemsSource = namesMDReportedRegion;
        }
        private void GetConfigValues()
        {
            region.Text = md.region.ToString();
            reported_region.Text = md.reported_region.ToString();
            cdbios.Text = md.cdbios;
            correct_aspect.IsChecked = md.correct_aspect.ToBool();
        }

        private void BtnSave(object sender, RoutedEventArgs e)
        {
            md.region = region.Text.Check<MDRegion>();
            md.reported_region = reported_region.Text.Check<MDReportedRegion>();
            md.cdbios = cdbios.Text;
            md.correct_aspect = correct_aspect.IsChecked.ToInt();

            opt.Save();
            fp.Save();
            Close();
        }
    }
}
