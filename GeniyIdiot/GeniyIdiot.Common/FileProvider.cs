using System.IO;
using System.Text;

namespace GeniyIdiot.Common
{
    public class FileProvider
    {
        public static void Append(string path, string value)
        {
            var writer = new StreamWriter(path, true, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }
        public static void Replace(string path, string value)
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
