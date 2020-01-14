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

namespace MedLiken.GUI
{
    /// <summary>
    /// Логика взаимодействия для NetPlay.xaml
    /// </summary>
    public partial class NetPlayWnd : Window
    {
        TMednafen mednafen;
        TNetPlay net;

        public NetPlayWnd(TMednafen mednafen)
        {
            InitializeComponent();

            this.mednafen = mednafen;
            net = mednafen.Global.NetPlay;
            mednafen.LoadConfig();

            SetGUI();
            GetConfigValues();
        }

        private void SetGUI()
        {
            

        }
        private void GetConfigValues()
        {
            server.Text = net.host;
            port.Text = net.port.ToString();
            password.Password = net.password;
            nick.Text = net.nick;
            md5.Text = net.gamekey;
            players.Value = net.localplayers;
        }

        private void BtnSave(object sender, RoutedEventArgs e)
        {
            net.host = server.Text;
            net.port = int.Parse(port.Text);
            net.password = password.Password;
            net.nick = nick.Text;
            net.gamekey = md5.Text;
            net.localplayers = (int)players.Value;

            mednafen.SaveConfig();
            Close();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int p = 0;
            int.TryParse(port.Text, out p);
            int n = 0;
            int.TryParse(port.Text + e.Text, out n);

            if (!char.IsDigit(e.Text, 0) || n > 65535)
                e.Handled = true;
        }

        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lPlayers.Content = players.Value.ToString();
        }
    }
}
