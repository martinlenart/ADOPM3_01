using System;
using System.IO;
using System.Text;

namespace ADOPM3_01_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default UTF-8 encoding");
            using (TextWriter w = File.CreateText(fname("Example4_11_1.txt")))
                w.WriteLine("Hello world"); 

            using (Stream s = File.OpenRead(fname("Example4_11_1.txt")))
                for (int b; (b = s.ReadByte()) > -1;)
                    Console.WriteLine(b);

            Console.WriteLine("Unicode a.k.a. UTF-16 encoding");
            using (Stream s = File.Create(fname("Example4_11_2.txt")))
            using (TextWriter w = new StreamWriter(s, Encoding.Unicode))
                w.WriteLine($"Hello world");

            foreach (byte b in File.ReadAllBytes(fname("Example4_11_2.txt")))
                Console.WriteLine(b);

            Console.WriteLine("Unicode a.k.a. UTF-32 encoding");
            using (Stream s = File.Create(fname("Example4_11_3.txt")))
            using (TextWriter w = new StreamWriter(s, new UTF32Encoding()))
                w.WriteLine($"Hello world");

            foreach (byte b in File.ReadAllBytes(fname("Example4_11_3.txt")))
                Console.WriteLine(b);

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
