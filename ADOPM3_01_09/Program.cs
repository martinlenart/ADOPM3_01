using System;
using System.IO;

namespace ADOPM3_01_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fname("Example4_09.txt")); //location of the file

            File.WriteAllText(fname("Example4_09.txt"), "Hello World");
            Console.WriteLine(File.ReadAllText(fname("Example4_09.txt")));

            static string fname(string name)
            {
                var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                documentPath = Path.Combine(documentPath, "AOOP2", "Examples");
                if (!Directory.Exists(documentPath)) Directory.CreateDirectory(documentPath);
                return Path.Combine(documentPath, name);
            }
        }
    }
}
