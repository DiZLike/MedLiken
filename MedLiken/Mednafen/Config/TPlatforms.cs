using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedLiken.Mednafen.Config.Platforms;

namespace MedLiken.Mednafen.Config
{
    public class TPlatforms
    {
        public TMegaDrive MegaDrive { get; set; }

        public TPlatforms()
        {
            MegaDrive = new TMegaDrive();
        }
    }
}
