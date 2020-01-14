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
using WF = System.Windows.Forms;
using MedLiken.Config;
using IO = System.IO;

namespace MedLiken.GUI
{
    /// <summary>
    /// Логика взаимодействия для GamesDirWnd.xaml
    /// </summary>
    public partial class GamesDirWnd : Window
    {
        WF.FolderBrowserDialog fb;
        Conf conf;

        public GamesDirWnd()
        {
            InitializeComponent();
            conf = new Conf(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ml.cfg"));
            tbMD.Text = conf.ReadValue("mdpath");
            tbNES.Text = conf.ReadValue("nespath");
            tbSNES.Text = conf.ReadValue("snespath");
        }

        private void btnMD_Click(object sender, RoutedEventArgs e)
        {
            fb = new WF.FolderBrowserDialog();
            var res = fb.ShowDialog();
            if (res != WF.DialogResult.OK)
                return;
            tbMD.Text = fb.SelectedPath;
        }

        private void btnNES_Click(object sender, RoutedEventArgs e)
        {
            fb = new WF.FolderBrowserDialog();
            var res = fb.ShowDialog();
            if (res != WF.DialogResult.OK)
                return;
            tbNES.Text = fb.SelectedPath;
        }

        private void btnSNES_Click(object sender, RoutedEventArgs e)
        {
            fb = new WF.FolderBrowserDialog();
            var res = fb.ShowDialog();
            if (res != WF.DialogResult.OK)
                return;
            tbSNES.Text = fb.SelectedPath;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            conf.WriteValue("mdpath", tbMD.Text, "Путь к играм md");
            conf.WriteValue("nespath", tbNES.Text, "Путь к играм nes");
            conf.WriteValue("snespath", tbSNES.Text, "Путь к играм snes");
            conf.Save();
            Close();
        }
    }
}
