using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken.Mednafen.Config.Global
{
    public class TVideo
    {
        public int blit_timesync
        {
            get { return TCfg.ReadValue<int>("video.blit_timesync"); }
            set { TCfg.WriteValue<int>("video.blit_timesync", value); }
        }
        public Deinterlacer deinterlacer
        {
            get { return TCfg.ReadValue<Deinterlacer>("video.deinterlacer"); }
            set { TCfg.WriteValue<Deinterlacer>("video.deinterlacer", value); }
        }
        public int disable_composition
        {
            get { return TCfg.ReadValue<int>("video.disable_composition"); }
            set { TCfg.WriteValue<int>("video.disable_composition", value); }
        }
        public VideoDriver driver
        {
            get { return TCfg.ReadValue<VideoDriver>("video.driver"); }
            set { TCfg.WriteValue<VideoDriver>("video.driver", value); }
        }
        public int frameskip
        {
            get { return TCfg.ReadValue<int>("video.frameskip"); }
            set { TCfg.WriteValue<int>("video.frameskip", value); }
        }
        public int fs
        {
            get { return TCfg.ReadValue<int>("video.fs"); }
            set { TCfg.WriteValue<int>("video.fs", value); }
        }
        public int fs_display
        {
            get { return TCfg.ReadValue<int>("video.fs.display"); }
            set { TCfg.WriteValue<int>("video.fs.display", value); }
        }
        public int glvsync
        {
            get { return TCfg.ReadValue<int>("video.glvsync"); }
            set { TCfg.WriteValue<int>("video.glvsync", value); }
        }

    }
}
