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
using System.Diagnostics;
using IO = System.IO;
using MedLiken.Mednafen.Config;
using MedLiken.Config;

namespace MedLiken.GUI
{
    /// <summary>
    /// Логика взаимодействия для MainWnd.xaml
    /// </summary>
    public partial class MainWnd : Window
    {
        TMednafen mednafen;
        string med = "";
        string cfg = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ml.cfg");
        Conf conf;
        List<string> gList;
        string currentPlatform;

        public MainWnd()
        {
            InitializeComponent();
            SearchMedCfg();
            mednafen = new TMednafen(med);
            mv.Content = "Mednafen " + mednafen.GetVersion();
            conf = new Conf(cfg);
        }

        private void SearchMedCfg()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var med1x = IO.Path.Combine(dir, "mednafen.cfg");
            var med09x = IO.Path.Combine(dir, "mednafen-09x.cfg");
            if (IO.File.Exists(med1x))
                med = med1x;
            else
                med = med09x;
        }

        private void BtnGamesDit(object sender, RoutedEventArgs e)
        {
            new GamesDirWnd().ShowDialog();
        }

        private void BtnVideo(object sender, RoutedEventArgs e)
        {
            new VideoWnd(mednafen).ShowDialog();
        }

        private void BtnAudio(object sender, RoutedEventArgs e)
        {
            new AudioWnd(mednafen).ShowDialog();
        }

        private void BtnNetPlay(object sender, RoutedEventArgs e)
        {
            new NetPlayWnd(mednafen).ShowDialog();
        }

        private void BtnMD(object sender, RoutedEventArgs e)
        {
            new MegaDriveWnd(mednafen).ShowDialog();
        }

        private void btnMd_Click(object sender, RoutedEventArgs e)
        {
            string path = conf.ReadValue("mdpath");
            if (path == "")
                return;
            gl.Items.Clear();

            var l = IO.Directory.GetFiles(path, "*.gen", IO.SearchOption.AllDirectories);
            gList = l.ToList();
            l = IO.Directory.GetFiles(path, "*.md", IO.SearchOption.AllDirectories);
            gList = gList.Concat(l).ToList();
            l = IO.Directory.GetFiles(path, "*.bin", IO.SearchOption.AllDirectories);
            gList = gList.Concat(l).ToList();

            for (int i = 0; i < gList.Count; i++)
            {
                var item = new Item(i + 1, IO.Path.GetFileNameWithoutExtension(gList[i]));
                gl.Items.Add(item);
            }

            currentPlatform = CurrentPlatform.MD;

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            string m = "\"" + IO.Path.Combine(IO.Path.GetDirectoryName(med), "mednafen.exe") + "\"";
            string a1 = "-force_module md \"" + gList[gl.SelectedIndex] + "\"";
            string a = string.Format("-force_module {0} \"{1}\"", currentPlatform, gList[gl.SelectedIndex]);

            Process p = new Process();
            p.StartInfo.FileName = m;
            p.StartInfo.Arguments = a;
            p.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;

            p.Start();

        }
    }
}
