using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MedLiken.Mednafen;

namespace MedLiken.Config
{
    public class Conf
    {
        private string file;
        private List<string> values;
        public Conf(string file) { this.file = file; Load(); }
        private List<string> Load()
        {
            if (!File.Exists(file))
                return new List<string>();
            return File.ReadAllLines(file).ToList();
        }
        private TValue ParseLine(string line)
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
        private bool Contains(string line, string key)
        {
            if (line.Length < key.Length)
                return false;
            var sub = line.Substring(0, key.Length);
            return key == sub ? true : false;
        }
        public void Save()
        {
            File.WriteAllLines(file, values.ToArray());
        }
        public void WriteValue(string key, string value, string desc = null)
        {
            //values = Load();
            for (int i = 0; i < values.Count; i++)
            {
                var line = values[i];
                if (!Contains(line, key))
                    continue;
                TValue value_ = ParseLine(line);
                values[i] = value_.Key + " " + value;
                return;
            }
            if (desc != null)
                values.Add("# " + desc);
            values.Add(key + " " + value);
        }
        public string ReadValue(string key)
        {
            values = Load();
            for (int i = 0; i < values.Count; i++)
            {
                var line = values[i];
                if (line[0] == '#')
                    continue;
                if (!Contains(line, key))
                    continue;
                TValue value = ParseLine(line);
                return value.Value.ToString();
            }
            return "";
        }
    }
}
