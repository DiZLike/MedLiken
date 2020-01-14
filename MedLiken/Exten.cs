using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedLiken
{
    public static class Exten
    {
        public static string[] CheckSymbols(this string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i][0] == '_')
                    items[i] = items[i].Substring(1);
            }
            return items;
        }
        public static T Check<T>(this string item)
        {
            if (Enum.IsDefined(typeof(T), item))
                return (T)Enum.Parse(typeof(T), item);
            else
                return (T)Enum.Parse(typeof(T), "_" + item);
        }
        public static bool ToBool(this int value)
        {
            return value > 0 ? true : false;
        }
        public static string ToClearStr(this Enum value)
        {
            string val = value.ToString();
            if (val[0] == '_')
                val = val.Substring(1);
            return val;
        }
        public static int ToInt(this bool? value)
        {
            return value.Value ? 1 : 0;
        }
    }
}
