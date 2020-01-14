using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace MedLiken.Mednafen
{
    public static class TCfg
    {
        public static string[] values;

        public static void Load(string cfg)
        {
            values = File.ReadAllLines(cfg);
        }
        public static void Save(string cfg)
        {
            File.WriteAllLines(cfg, values);
        }
        public static T ReadValue<T>(string key)
        {
            for (int i = 0; i < values.Length; i++)
            {
                var line = values[i];
                if (!Contains(line, key))
                    continue;
                TValue value = ParseLine(line);
                Type type = typeof(T);
                if (type.IsEnum)
                {
                    bool ok = Enum.IsDefined(typeof(T), value.Value);
                    if (!ok)
                        value.Value = "_" + value.Value;

                    return (T)Enum.Parse(typeof(T), value.Value.ToString());
                }
                else if (typeof(T).Equals(typeof(float)))
                {
                    string d = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                    return (T)Convert.ChangeType(value.Value.ToString().Replace(".", d).Replace(",", d), typeof(T));
                }
                else
                    return (T)Convert.ChangeType(value.Value, typeof(T));
            }
            return default(T);
        }
        public static void WriteValue<T>(string key, T value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                var line = values[i];
                if (!Contains(line, key))
                    continue;
                TValue value_ = ParseLine(line);
                Type type = typeof(T);
                if (typeof(T).Equals(typeof(float)))
                {
                    string v = value.ToString();
                    values[i] = value_.Key + " " + v.Replace(',', '.');
                }
                else if (type.IsEnum)
                {
                    string v = value.ToString();
                    if (v[0] == '_')
                        v = v.Substring(1);
                    if (v[v.Length - 1] == '_')
                        v = v.Remove(v.Length - 1);
                    values[i] = value_.Key + " " + v;
                }
                else
                    values[i] = value_.Key + " " + value;
                break;
            }
        }
        private static bool Contains(string line, string key)
        {
            if (line.Length < key.Length)
                return false;
            var sub = line.Substring(0, key.Length);
            return key == sub ? true : false;
        }
        private static TValue ParseLine(string line)
        {
            int spaceIndex = 0;
            string key = "";
            string value = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ')
                {
                    spaceIndex = i;
                    break;
                }
            }
            key = line.Substring(0, spaceIndex);
            value = line.Remove(0, spaceIndex + 1);
            return new TValue(key, value);
        }
    }
}
