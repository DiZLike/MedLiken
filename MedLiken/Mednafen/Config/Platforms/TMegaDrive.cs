using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken.Mednafen.Config.Platforms
{
    public class TMegaDrive : TPlatform
    {
        public TMegaDrive() : base("md") { }

        public string cdbios
        {
            get { return TCfg.ReadValue<string>("md.cdbios"); }
            set { TCfg.WriteValue<string>("md.cdbios", value); }
        }
        public int correct_aspect
        {
            get { return TCfg.ReadValue<int>("md.correct_aspect"); }
            set { TCfg.WriteValue<int>("md.correct_aspect", value); }
        }
        public MDRegion region
        {
            get { return TCfg.ReadValue<MDRegion>("md.region"); }
            set { TCfg.WriteValue<MDRegion>("md.region", value); }
        }
        public MDReportedRegion reported_region
        {
            get { return TCfg.ReadValue<MDReportedRegion>("md.reported_region"); }
            set { TCfg.WriteValue<MDReportedRegion>("md.reported_region", value); }
        }
    }
}
