using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken
{
    public class Item
    {
        public int Index { get; set; }
        public string Value { get; set; }
        public Item(int index, string value) { Index = index; Value = value; }
    }
}
