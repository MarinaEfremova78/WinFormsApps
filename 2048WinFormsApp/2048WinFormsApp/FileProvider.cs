using System;
using System.IO;
using System.Text;

namespace _2048WinFormsApp
{
    public class FileProvider
    {
        public static void Append(string path, string value)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        public static string Get(string path)
        {
            var reader = new StreamReader(path, Encoding.UTF8);
            var fileData = reader.ReadToEnd();
            reader.Close();
            return fileData;
        }
        public static bool Exists(string path)
        {
            return File.Exists(path);
        }
        
    }
}
