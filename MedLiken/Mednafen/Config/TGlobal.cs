using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedLiken.Mednafen.Config.Global;

namespace MedLiken.Mednafen.Config
{
    public class TGlobal
    {
        public TVideo Video { get; set; }
        public TAudio Audio { get; set; }
        public TNetPlay NetPlay { get; set; }

        public TGlobal()
        {
            Video = new TVideo();
            Audio = new TAudio();
            NetPlay = new TNetPlay();
        }
    }
}
