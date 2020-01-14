using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken.Mednafen.Config.Global
{
    public class TNetPlay
    {
        public string gamekey
        {
            get { return TCfg.ReadValue<string>("netplay.gamekey"); }
            set { TCfg.WriteValue<string>("netplay.gamekey", value); }
        }
        public string host
        {
            get { return TCfg.ReadValue<string>("netplay.host"); }
            set { TCfg.WriteValue<string>("netplay.host", value); }
        }
        public int localplayers
        {
            get { return TCfg.ReadValue<int>("netplay.localplayers"); }
            set { TCfg.WriteValue<int>("netplay.localplayers", value); }
        }
        public string nick
        {
            get { return TCfg.ReadValue<string>("netplay.nick"); }
            set { TCfg.WriteValue<string>("netplay.nick", value); }
        }
        public string password
        {
            get { return TCfg.ReadValue<string>("netplay.password"); }
            set { TCfg.WriteValue<string>("netplay.password", value); }
        }
        public int port
        {
            get { return TCfg.ReadValue<int>("netplay.port"); }
            set { TCfg.WriteValue<int>("netplay.port", value); }
        }
    }
}
