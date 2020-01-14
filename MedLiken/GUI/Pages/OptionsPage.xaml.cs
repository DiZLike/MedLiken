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
using MedLiken.Mednafen;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MedLiken.Mednafen.Config.Platforms;

namespace MedLiken.GUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для OptionsPage.xaml
    /// </summary>
    public partial class OptionsPage : Page
    {
        #region
        [DllImport("user32.dll")]
        public static extern bool EnumDisplaySettings(
              string deviceName, int modeNum, ref DEVMODE devMode);
        const int ENUM_CURRENT_SETTINGS = -1;

        const int ENUM_REGISTRY_SETTINGS = -2;

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {

            private const int CCHDEVICENAME = 0x20;
            private const int CCHFORMNAME = 0x20;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;

        }
        #endregion

        TMednafen mednafen;
        TPlatform platform;

        public OptionsPage(TMednafen mednafen, string platform)
        {
            InitializeComponent();
            this.mednafen = mednafen;
            this.platform = new TPlatform(platform);


            SetGUI();
            GetConfigValues();
        }
        private void SetGUI()
        {
            #region
            DEVMODE devMode = new DEVMODE();
            int i = 0;
            fsRes.Items.Add("0x0");
            while (EnumDisplaySettings(null, i, ref devMode))
            {
                bool ok = true;
                string res = devMode.dmPelsWidth + "x" + devMode.dmPelsHeight;
                foreach (var item in fsRes.Items)
                {
                    if (item.ToString() == res)
                        ok = false;
                }

                if (ok)
                    fsRes.Items.Add(res);
                i++;
            }
            #endregion
            for (i = 0; i < 10; i++)
            {
                scalefs.Items.Add(i + 1);
                scale.Items.Add(i + 1);
            }
        }
        private void GetConfigValues()
        {
            monosound.IsChecked = platform.forcemono.ToBool();

            var rX = platform.xres;
            var rY = platform.yres;
            fsRes.Text = rX + "x" + rY;

            var sfX = platform.xscalefs;
            var sfY = platform.yscalefs;
            scalefs.Text = sfX.ToString();

            var swX = platform.xscale;
            var swY = platform.yscale;
            scale.Text = swX.ToString();
        }
        public void Save()
        {
            platform.forcemono = monosound.IsChecked.ToInt();

            var res = fsRes.Text.Split('x');
            platform.xres = int.Parse(res[0]);
            platform.yres = int.Parse(res[1]);

            platform.xscale = int.Parse(scale.Text);
            platform.yscale = int.Parse(scale.Text);

            platform.xscalefs = int.Parse(scalefs.Text);
            platform.yscalefs = int.Parse(scalefs.Text);

            mednafen.SaveConfig();
        }
    }
}
