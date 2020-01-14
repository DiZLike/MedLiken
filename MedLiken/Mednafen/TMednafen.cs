using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedLiken.Mednafen.Config;

namespace MedLiken.Mednafen
{
    public class TMednafen
    {
        private string cfg = @"D:\Personal\Evgeny\Soft\mednafen-1.22.1\mednafen.cfg";
        public TGlobal Global { get; set; }
        public TPlatforms Platforms { get; set; }

        public TMednafen(string cfg)
        {
            this.cfg = cfg;
            TCfg.Load(cfg);
            Global = new TGlobal();
            Platforms = new TPlatforms();
        }
        public string GetVersion()
        {
            return TCfg.values[0].Substring(9);
        }
        public void LoadConfig()
        {
            TCfg.Load(cfg);
        }
        public void SaveConfig()
        {
            TCfg.Save(cfg);
        }
    }
}
