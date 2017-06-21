﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkaArt.Classes
{
    public class LogHandler
    {
        public static bool WriteLine(string text)
        {
            try
            {
                FileStream file = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
                StreamWriter stream = new StreamWriter(file);
                stream.WriteLine(text);
                stream.Close();
                file.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool WriteLine(string text, params object[] parameters)
        {
            try
            {
                FileStream file = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
                StreamWriter stream = new StreamWriter(file);
                stream.WriteLine(text, parameters);
                stream.Close();
                file.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
