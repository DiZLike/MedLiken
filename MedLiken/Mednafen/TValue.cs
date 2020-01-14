using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken.Mednafen
{
    public class TValue
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public string Desc { get; set; }
        public TValue(string key, object value) { Key = key; Value = value; }
    }
}
