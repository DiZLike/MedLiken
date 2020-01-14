using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken.Mednafen.Config.Global
{
    public class TAudio
    {
        public int enable
        {
            get { return TCfg.ReadValue<int>("sound"); }
            set { TCfg.WriteValue<int>("sound", value); }
        }
        public int buffer_time
        {
            get { return TCfg.ReadValue<int>("sound.buffer_time"); }
            set { TCfg.WriteValue<int>("sound.buffer_time", value); }
        }
        public AudioDriver driver
        {
            get { return TCfg.ReadValue<AudioDriver>("sound.driver"); }
            set { TCfg.WriteValue<AudioDriver>("sound.driver", value); }
        }
        public int period_time
        {
            get { return TCfg.ReadValue<int>("sound.period_time"); }
            set { TCfg.WriteValue<int>("sound.period_time", value); }
        }
        public int rate
        {
            get { return TCfg.ReadValue<int>("sound.rate"); }
            set { TCfg.WriteValue<int>("sound.rate", value); }
        }
        public int volume
        {
            get { return TCfg.ReadValue<int>("sound.volume"); }
            set { TCfg.WriteValue<int>("sound.volume", value); }
        }
    }
}
